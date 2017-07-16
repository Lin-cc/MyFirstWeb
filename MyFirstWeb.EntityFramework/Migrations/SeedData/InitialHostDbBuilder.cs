using MyFirstWeb.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MyFirstWeb.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MyFirstWebDbContext _context;

        public InitialHostDbBuilder(MyFirstWebDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
