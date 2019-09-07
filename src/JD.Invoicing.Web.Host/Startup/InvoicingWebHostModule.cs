using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JD.Invoicing.Configuration;

namespace JD.Invoicing.Web.Host.Startup
{
    [DependsOn(
       typeof(InvoicingWebCoreModule))]
    public class InvoicingWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public InvoicingWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InvoicingWebHostModule).GetAssembly());
        }
    }
}
