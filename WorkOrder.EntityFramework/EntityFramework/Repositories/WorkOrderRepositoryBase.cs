using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace WorkOrder.EntityFramework.Repositories
{
    public abstract class WorkOrderRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<WorkOrderDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WorkOrderRepositoryBase(IDbContextProvider<WorkOrderDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class WorkOrderRepositoryBase<TEntity> : WorkOrderRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected WorkOrderRepositoryBase(IDbContextProvider<WorkOrderDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
