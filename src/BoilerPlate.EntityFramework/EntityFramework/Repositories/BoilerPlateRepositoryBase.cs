using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace BoilerPlate.EntityFramework.Repositories
{
    public abstract class BoilerPlateRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BoilerPlateDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BoilerPlateRepositoryBase(IDbContextProvider<BoilerPlateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BoilerPlateRepositoryBase<TEntity> : BoilerPlateRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BoilerPlateRepositoryBase(IDbContextProvider<BoilerPlateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
