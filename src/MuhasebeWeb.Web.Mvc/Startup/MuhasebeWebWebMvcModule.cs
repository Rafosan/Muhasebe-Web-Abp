using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MuhasebeWeb.Configuration;

namespace MuhasebeWeb.Web.Startup
{
    [DependsOn(typeof(MuhasebeWebWebCoreModule))]
    public class MuhasebeWebWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MuhasebeWebWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<MuhasebeWebNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MuhasebeWebWebMvcModule).GetAssembly());
        }
    }
}
