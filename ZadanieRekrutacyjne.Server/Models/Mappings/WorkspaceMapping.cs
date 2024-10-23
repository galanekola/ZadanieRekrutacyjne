using FluentNHibernate.Mapping;

namespace ZadanieRekrutacyjne.Server.Models.Mappings;

public class WorkspaceMapping : ClassMap<Workspace>
{
    public WorkspaceMapping()
    {
        Table("Workspace");
        Id(x => x.Id).GeneratedBy.GuidComb();
        Map(x => x.Uzytkownik).Not.Nullable();
    }
}