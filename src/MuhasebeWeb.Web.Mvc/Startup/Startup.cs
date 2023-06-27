using System;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Castle.Facilities.Logging;
using Abp.AspNetCore;
using Abp.AspNetCore.Mvc.Antiforgery;
using Abp.Castle.Logging.Log4Net;
using MuhasebeWeb.Authentication.JwtBearer;
using MuhasebeWeb.Configuration;
using MuhasebeWeb.Identity;
using MuhasebeWeb.Web.Resources;
using Abp.AspNetCore.SignalR.Hubs;
using Abp.Dependency;
using Abp.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.WebEncoders;
using Newtonsoft.Json.Serialization;
using Microsoft.OpenApi.Models;

namespace MuhasebeWeb.Web.Startup
{
    public class Startup
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IConfigurationRoot _appConfiguration;

        private readonly string _apiVersion = "v1.0";
        public Startup(IWebHostEnvironment env)
        {
            _hostingEnvironment = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // MVC
            services.AddControllersWithViews(
                    options =>
                    {
                        options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                        options.Filters.Add(new AbpAutoValidateAntiforgeryTokenAttribute());
                    }
                )
                .AddRazorRuntimeCompilation()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new AbpMvcContractResolver(IocManager.Instance)
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    };
                });

            IdentityRegistrar.Register(services);
            AuthConfigurer.Configure(services, _appConfiguration);

            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });
            
            services.AddScoped<IWebResourceManager, WebResourceManager>();

            services.AddSignalR();

            //Swagger entregrasyonunu burda yapacam
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(_apiVersion, new OpenApiInfo
                {
                    Version = _apiVersion,
                    Title = "Muhasebe API",
                    Description = "Abp Boilerplate",
                    Contact = new OpenApiContact
                    {
                        Name = "MuhasebeWeb",
                        Email = string.Empty,
                        Url = new Uri("https://example.com"),
                    }
                });
                options.DocInclusionPredicate((docname, description) => true);
                options.AddSecurityDefinition("bearerAuth", new OpenApiSecurityScheme()
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization:Bearer{token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });   
            });


            // Configure Abp and Dependency Injection
            services.AddAbpWithoutCreatingServiceProvider<MuhasebeWebWebMvcModule>(
                // Configure Log4Net logging
                options => options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig(
                        _hostingEnvironment.IsDevelopment()
                            ? "log4net.config"
                            : "log4net.Production.config"
                        )
                )
            );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(); // Initializes ABP framework.

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseJwtTokenMiddleware();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<AbpCommonHub>("/signalr");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("defaultWithArea", "{area}/{controller=Home}/{action=Index}/{id?}");
            });
            //Swaggerı burda çağırcam
            app.UseSwagger(options =>
            {
                options.RouteTemplate = "swagger/{documentname}/swagger.json";
            });
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint($"/swagger/{_apiVersion}/swagger.json",$"Muhasebe API {_apiVersion}");
                options.DisplayRequestDuration();
            });
        }
    }
}
