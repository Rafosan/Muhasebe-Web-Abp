using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MuhasebeWeb.Configuration;

namespace MuhasebeWeb.Web.Host.Startup
{
    [DependsOn(
       typeof(MuhasebeWebWebCoreModule))]
    public class MuhasebeWebWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MuhasebeWebWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MuhasebeWebWebHostModule).GetAssembly());
        }
    }
}
