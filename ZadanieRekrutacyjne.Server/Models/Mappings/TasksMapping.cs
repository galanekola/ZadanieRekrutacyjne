using FluentNHibernate.Mapping;

namespace ZadanieRekrutacyjne.Server.Models.Mappings;

public class TasksMapping : ClassMap<Tasks>
{
    public TasksMapping()
    {
        Table("Tasks");
        Id(x => x.Id).GeneratedBy.GuidComb();

        Map(x => x.Nazwa).Length(255).Not.Nullable();
        Map(x => x.Opis).Length(1000).Nullable();
        Map(x => x.Deadline).Nullable();
        Map(x => x.DataUtworzenia).Not.Nullable();
        Map(x => x.Progress).Not.Nullable();
        Map(x => x.TabelaId).Not.Nullable();
    }
}