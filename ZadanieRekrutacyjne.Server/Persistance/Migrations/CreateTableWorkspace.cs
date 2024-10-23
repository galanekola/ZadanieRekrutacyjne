using FluentMigrator;

namespace ZadanieRekrutacyjne.Server.Persistance.Migrations;

[Migration(004)]
public class CreateWorkspaceTable : Migration
{
    public override void Up()
    {
        Create.Table("Workspace")
            .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
            .WithColumn("Uzytkownik").AsString().NotNullable();
        
        Create.ForeignKey("FK_Workspace_AspNetUsers")
            .FromTable("Workspace").ForeignColumn("Uzytkownik")
            .ToTable("AspNetUsers").PrimaryColumn("Id");
    }
    public override void Down()
    {
        Delete.ForeignKey("FK_Workspace_AspNetUsers").OnTable("Workspace");
        Delete.Table("Workspace");
    }
}