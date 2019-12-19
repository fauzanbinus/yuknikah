namespace yuknikah.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly yuknikahDbContext _context;

        public InitialHostDbBuilder(yuknikahDbContext context)
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
