using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace JD.Invoicing.EntityFrameworkCore
{
    public static class InvoicingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<InvoicingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<InvoicingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
