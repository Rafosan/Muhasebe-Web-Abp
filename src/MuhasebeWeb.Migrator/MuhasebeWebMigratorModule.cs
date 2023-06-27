using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MuhasebeWeb.Configuration;
using MuhasebeWeb.EntityFrameworkCore;
using MuhasebeWeb.Migrator.DependencyInjection;

namespace MuhasebeWeb.Migrator
{
    [DependsOn(typeof(MuhasebeWebEntityFrameworkModule))]
    public class MuhasebeWebMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MuhasebeWebMigratorModule(MuhasebeWebEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MuhasebeWebMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MuhasebeWebConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MuhasebeWebMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
