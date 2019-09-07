using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using JD.Invoicing.Authorization.Roles;
using JD.Invoicing.Authorization.Users;
using JD.Invoicing.MultiTenancy;
using JD.Invoicing.Entitys;

namespace JD.Invoicing.EntityFrameworkCore
{
    public class InvoicingDbContext : AbpZeroDbContext<Tenant, Role, User, InvoicingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public InvoicingDbContext(DbContextOptions<InvoicingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Goods> Goods { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
    }
}
