namespace JD.Invoicing.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly InvoicingDbContext _context;

        public InitialHostDbBuilder(InvoicingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
