using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MyFirstWeb.EntityFramework.Repositories
{
    public abstract class MyFirstWebRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyFirstWebDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyFirstWebRepositoryBase(IDbContextProvider<MyFirstWebDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyFirstWebRepositoryBase<TEntity> : MyFirstWebRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyFirstWebRepositoryBase(IDbContextProvider<MyFirstWebDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
