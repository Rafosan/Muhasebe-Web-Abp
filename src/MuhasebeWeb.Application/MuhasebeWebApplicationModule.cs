using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MuhasebeWeb.Authorization;

namespace MuhasebeWeb
{
    [DependsOn(
        typeof(MuhasebeWebCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MuhasebeWebApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MuhasebeWebAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MuhasebeWebApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
