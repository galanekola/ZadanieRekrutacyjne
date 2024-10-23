using FluentMigrator;

namespace ZadanieRekrutacyjne.Server.Persistance.Migrations;
[Migration(006)]
public class CreateTableTasks : Migration
{
    public override void Up()
    {
        Create.Table("Tasks")
            .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
            .WithColumn("Nazwa").AsString().NotNullable()
            .WithColumn("Opis").AsString().Nullable()
            .WithColumn("Deadline").AsDateTime().Nullable()
            .WithColumn("DataUtworzenia").AsDateTime().NotNullable()
            .WithColumn("Progress").AsInt32().NotNullable()
            .WithColumn("TabelaId").AsGuid().NotNullable();
        
        Create.ForeignKey("FK_Tasks_Tabela")
            .FromTable("Tasks").ForeignColumn("TabelaId")
            .ToTable("Tabela").PrimaryColumn("Id");
    }
    public override void Down()
    {
        Delete.ForeignKey("FK_Tasks_Tabela").OnTable("Tasks");
        Delete.Table("Tasks");
    }
}