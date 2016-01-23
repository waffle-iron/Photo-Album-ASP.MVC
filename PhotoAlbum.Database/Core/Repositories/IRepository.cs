using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PhotoAlbum.Domain.Core.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void AddRemove(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
    }
}
