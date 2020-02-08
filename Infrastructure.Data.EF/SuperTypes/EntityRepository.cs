using Raitan.Infrastructure.Data.EF.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Raitan.Infrastructure.Data.EF.SuperTypes
{
    public abstract class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : Entity
    {
        protected IContext _context;
        protected IDbSet<TEntity> _dbSet;

        public EntityRepository(IContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            else
            {
                foreach (TEntity entity in entities)
                {
                    _dbSet.Add(entity);
                }
                _context.SaveChanges();
            }
        }

        public virtual void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsEnumerable<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetFilteredElements(Expression<Func<TEntity, bool>> filterd)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> GetPagedElements<S>(int pageIndex, int pageCount, Expression<Func<TEntity, S>> orderByExpression, bool ascending = true)
        {
            throw new NotImplementedException();
        }

        public virtual void Modify(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public virtual void Modify(IEnumerable<TEntity> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("entities");
            }
            foreach (TEntity entity in collection)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }
    }
}
