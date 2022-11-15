using Crud2.Main.Domain;
using FluentNHibernate.Mapping;

namespace Crud2.Main.Data
{
    public class OcupacaoMap : ClassMap<Ocupacao>
    {
        public OcupacaoMap()
        {

            Table("ocupacao");
            Id(x => x.Ocupacaoid).Column("ocupacaoid").GeneratedBy.Identity();
            Map(x => x.Nome).Column("nome").Not.Nullable().Length(300);
            Map(x => x.Codigocbo).Column("codigocbo").Not.Nullable().Length(300);
        }
    }
}
