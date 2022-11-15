using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud2.Main.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ISession Session { get; set; }

        void BeginTransaction();
        void Commit();
        void RollBack();
    }
}
