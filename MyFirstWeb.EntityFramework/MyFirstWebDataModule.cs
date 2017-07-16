using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MyFirstWeb.EntityFramework;

namespace MyFirstWeb
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MyFirstWebCoreModule))]
    public class MyFirstWebDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyFirstWebDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
