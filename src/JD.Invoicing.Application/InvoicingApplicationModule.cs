using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JD.Invoicing.Authorization;

namespace JD.Invoicing
{
    [DependsOn(
        typeof(InvoicingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class InvoicingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<InvoicingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(InvoicingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
