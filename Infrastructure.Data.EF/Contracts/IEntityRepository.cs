
using Raitan.Infrastructure.Data.EF.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Raitan.Infrastructure.Data.EF.SuperTypes
{
    public interface IEntityRepository<TEntity> : IRepository where TEntity : IEntity
    {
        void Add(TEntity item);
        void Add(IEnumerable<TEntity> items);
        void Delete(TEntity item);
        void Modify(TEntity item);
        void Modify(IEnumerable<TEntity> items);
        IEnumerable<TEntity> GetAll();
        //IEnumerable<K> GetAll<K>() where K : TEntity, new();
        IEnumerable<TEntity> GetPagedElements<S>(int pageIndex, int pageCount,
            Expression<Func<TEntity, S>> orderByExpression, bool ascending = true);
        IEnumerable<TEntity> GetFilteredElements(Expression<Func<TEntity, bool>> filterd);
    }
}