using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Shop.EntityFramework.Repositories
{
    public abstract class ShopRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ShopDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ShopRepositoryBase(IDbContextProvider<ShopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ShopRepositoryBase<TEntity> : ShopRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ShopRepositoryBase(IDbContextProvider<ShopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
