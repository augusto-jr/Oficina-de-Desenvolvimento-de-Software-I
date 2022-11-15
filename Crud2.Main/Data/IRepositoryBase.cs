using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Crud2.Main.Data
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Flush();
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(int id);
        void Remove(TEntity obj);
        void Remove(IList<TEntity> listObjects);
        void Remove(Expression<Func<TEntity, bool>> where);
        TEntity GetById(int id);
        TEntity Get(Expression<Func<TEntity, bool>> where);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);
    }
}
