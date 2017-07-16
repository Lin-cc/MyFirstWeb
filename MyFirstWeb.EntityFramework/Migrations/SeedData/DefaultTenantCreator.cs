using System.Linq;
using MyFirstWeb.EntityFramework;
using MyFirstWeb.MultiTenancy;

namespace MyFirstWeb.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MyFirstWebDbContext _context;

        public DefaultTenantCreator(MyFirstWebDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
