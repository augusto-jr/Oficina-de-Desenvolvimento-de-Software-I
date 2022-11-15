using Crud2.Main.Domain;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace Crud2.Main.Data
{
    public class UfRepository : RepositoryBase<Uf>, IRepositoryBase<Uf>
    {
        public UfRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Uf> GetUfs_SiglaNome(string sigla,string nome)
        {
            try
            {
                Uf uf = null;
                var consulta = Session.QueryOver<Uf>(() => uf).OrderBy(x => uf.Sigla).Asc;

                if (!String.IsNullOrEmpty(sigla))
                    consulta = consulta.Where(x => uf.Sigla == sigla);

                if (!String.IsNullOrEmpty(nome))
                    consulta = consulta.Where(x => uf.Nome.IsInsensitiveLike(nome + "%"));

                var lista = consulta.List<Uf>();
                return lista;
            }
            catch
            {
                throw;
            }
        }
    }
}
