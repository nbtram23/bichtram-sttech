using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using bichtram.Authorization;

namespace bichtram
{
    [DependsOn(
        typeof(bichtramCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class bichtramApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<bichtramAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(bichtramApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
