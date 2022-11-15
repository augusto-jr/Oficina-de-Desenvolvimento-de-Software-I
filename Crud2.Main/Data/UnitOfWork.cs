using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud2.Main.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ISessionFactory _sessionFactory;
        private ITransaction _transaction;       

        public ISession Session { get; set; }

        //static UnitOfWork()
        //{
        //    // Initialise singleton instance of ISessionFactory, static constructors are only executed once during the 
        //    // application lifetime - the first time the UnitOfWork class is used
        //    _sessionFactory = Fluently.Configure()
        //        .Database(MsSqlConfiguration.MsSql2012.ConnectionString(x => x.FromConnectionStringWithKey("NHibernate.connectionString")))
        //        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<EntityConfig.Configuracao.FilialMap>())
        //        .BuildSessionFactory();
        //}

        public UnitOfWork()
        {   

        // Initialise singleton instance of ISessionFactory, static constructors are only executed once during the 
        // application lifetime - the first time the UnitOfWork class is used
        _sessionFactory = Fluently.Configure()
            .Database(MySQLConfiguration.Standard.ConnectionString(x => x.FromConnectionStringWithKey("NHibernate.connectionString")))
            .Mappings(c => c.FluentMappings.AddFromAssemblyOf<UfMap>().AddFromAssemblyOf<OcupacaoMap>())
            .BuildSessionFactory();

            //Session = _sessionFactory.OpenSession();
        }

        public void BeginTransaction()
        {
            Session = _sessionFactory.OpenSession();
            _transaction = Session.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                // commit transaction if there is one active
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Commit();
            }
            catch
            {
                // rollback if there was an exception
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();

                throw;
            }
            finally
            {
                Session.Dispose();
            }
        }

        public void RollBack()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();
            }
            finally
            {
                Session.Dispose();
            }
        }

        public void Dispose()
        {
            if (Session == null) return;
            if (Session.IsOpen)
                Session.Close();
            Session = null;
        }
    }
}
