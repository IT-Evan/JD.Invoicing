using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using JD.Invoicing.Configuration;
using JD.Invoicing.Web;

namespace JD.Invoicing.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class InvoicingDbContextFactory : IDesignTimeDbContextFactory<InvoicingDbContext>
    {
        public InvoicingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<InvoicingDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            InvoicingDbContextConfigurer.Configure(builder, configuration.GetConnectionString(InvoicingConsts.ConnectionStringName));

            return new InvoicingDbContext(builder.Options);
        }
    }
}
