using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using MyFirstWeb.Authorization.Roles;
using MyFirstWeb.MultiTenancy;
using MyFirstWeb.Users;

namespace MyFirstWeb.EntityFramework
{
    public class MyFirstWebDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MyFirstWebDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyFirstWebDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyFirstWebDbContext since ABP automatically handles it.
         */
        public MyFirstWebDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MyFirstWebDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MyFirstWebDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
        /// <summary>
        /// add by clh@20170701 修改表前缀
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("Lin");

        }
    }
}
