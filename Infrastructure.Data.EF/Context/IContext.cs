using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Raitan.Infrastructure.Data.EF.Context
{
    public interface IContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }
}
