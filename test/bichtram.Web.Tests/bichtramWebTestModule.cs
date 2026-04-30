using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using bichtram.EntityFrameworkCore;
using bichtram.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace bichtram.Web.Tests
{
    [DependsOn(
        typeof(bichtramWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class bichtramWebTestModule : AbpModule
    {
        public bichtramWebTestModule(bichtramEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(bichtramWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(bichtramWebMvcModule).Assembly);
        }
    }
}