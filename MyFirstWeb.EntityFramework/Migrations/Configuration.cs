using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using MyFirstWeb.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace MyFirstWeb.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<MyFirstWeb.EntityFramework.MyFirstWebDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyFirstWeb";
        }

        protected override void Seed(MyFirstWeb.EntityFramework.MyFirstWebDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
