using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MuhasebeWeb.EntityFrameworkCore;
using MuhasebeWeb.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MuhasebeWeb.Web.Tests
{
    [DependsOn(
        typeof(MuhasebeWebWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MuhasebeWebWebTestModule : AbpModule
    {
        public MuhasebeWebWebTestModule(MuhasebeWebEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MuhasebeWebWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MuhasebeWebWebMvcModule).Assembly);
        }
    }
}