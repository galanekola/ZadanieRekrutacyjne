using FluentNHibernate.Mapping;

namespace ZadanieRekrutacyjne.Server.Models.Mappings;

public class TabelaMapping : ClassMap<Tabela>
{
    public TabelaMapping()
    {
        Table("Tabela");
        Id(x => x.Id).GeneratedBy.GuidComb();

        Map(x => x.Nazwa_Tabeli).Length(255).Not.Nullable();
        Map(x => x.Tag).Length(255).Nullable();
        Map(x => x.Progress).Not.Nullable();
        Map(x => x.WorkspaceId).Not.Nullable();
    }
}