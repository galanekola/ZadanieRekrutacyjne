using FluentMigrator;

namespace ZadanieRekrutacyjne.Server.Persistance.Migrations;

[Migration(005)] // Użyj odpowiedniego numeru wersji migracji
public class CreateTableTabela: Migration
{
    public override void Up()
    {
        Create.Table("Tabela")
            .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
            .WithColumn("Nazwa_Tabeli").AsString().NotNullable()
            .WithColumn("Tag").AsString().Nullable()
            .WithColumn("Progress").AsInt32().NotNullable()
            .WithColumn("WorkspaceId").AsGuid().NotNullable();
        
        Create.ForeignKey("FK_Tabela_Workspace")
            .FromTable("Tabela").ForeignColumn("WorkspaceId")
            .ToTable("Workspace").PrimaryColumn("Id");
    }
    public override void Down()
    {
        Delete.ForeignKey("FK_Tabela_Workspace").OnTable("Tabela");
        Delete.Table("Tabela");
    }
}