using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyFirstWeb.EntityFramework;

namespace MyFirstWeb.Migrator
{
    [DependsOn(typeof(MyFirstWebDataModule))]
    public class MyFirstWebMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyFirstWebDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}