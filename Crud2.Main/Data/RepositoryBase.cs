using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Crud2.Main.Data
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected IUnitOfWork _unitOfWork;

        public RepositoryBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected ISession Session { get { return _unitOfWork.Session; } }

        public void Add(TEntity entity)
        {
            Session.Save(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            var obj = Session.QueryOver<TEntity>().Where(where).List().FirstOrDefault();
            return obj;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Session.Query<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return Session.Get<TEntity>(id);
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            var listObjects = Session.QueryOver<TEntity>().Where(where).List();
            return listObjects;
        }

        public void Remove(int id)
        {
            Session.Delete(Session.Load<TEntity>(id));
        }

        public void Remove(TEntity entity)
        {
            Session.Delete(entity);
        }

        public void Remove(IList<TEntity> listObjects)
        {
            foreach (TEntity obj in listObjects)
                Remove(obj);
        }

        public void Remove(Expression<Func<TEntity, bool>> where)
        {
            var listObjects = Session.QueryOver<TEntity>().Where(where).List();
            Remove(listObjects);
        }

        public void Update(TEntity entity)
        {
            Session.SaveOrUpdate(entity);
        }

        public void Flush()
        {
            Session.Flush();
        }
    }
}
