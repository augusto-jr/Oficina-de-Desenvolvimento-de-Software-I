using Crud2.Main.Domain;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace Crud2.Main.Data
{
    public class OcupacaoRepository : RepositoryBase<Ocupacao>, IRepositoryBase<Ocupacao>
    {
        public OcupacaoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Ocupacao> GetOcupacao_NomeCodigocbo(string nome, string codigocbo)
        {
            try
            {
                Ocupacao ocupacao = null;
                var consulta = Session.QueryOver<Ocupacao>(() => ocupacao).OrderBy(x => ocupacao.Nome).Asc;

                if (!String.IsNullOrEmpty(nome))
                    consulta = consulta.Where(x => ocupacao.Nome == nome);

                if (!String.IsNullOrEmpty(codigocbo))
                    consulta = consulta.Where(x => ocupacao.Codigocbo.IsInsensitiveLike(codigocbo + "%"));

                var lista = consulta.List<Ocupacao>();
                return lista;
            }
            catch
            {
                throw;
            }
        }
    }
}
