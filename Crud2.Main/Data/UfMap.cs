using Crud2.Main.Domain;
using FluentNHibernate.Mapping;

namespace Crud2.Main.Data
{
    public class UfMap : ClassMap<Uf>
    {
        public UfMap()
        {
            //Schema("dbo");
            Table("uf");
            Id(x => x.Id).Column("id").GeneratedBy.Identity();
            Map(x => x.Nome).Column("nome").Not.Nullable().Length(50);
            Map(x => x.Sigla).Column("sigla").Not.Nullable().Length(2);
        }
    }
}
