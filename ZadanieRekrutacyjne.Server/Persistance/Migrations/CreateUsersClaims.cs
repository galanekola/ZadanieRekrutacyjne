using FluentMigrator;

namespace ZadanieRekrutacyjne.Server.Persistance.Migrations;
[Migration (003)]
public class CreateUsersClaims : Migration
{
    public override void Up()
    {
        Create.Table("AspNetUserClaims")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("UserId").AsString(128).NotNullable()
            .WithColumn("ClaimType").AsString(256).NotNullable()
            .WithColumn("ClaimValue").AsString(256).NotNullable();
    }
    public override void Down()
    {
        Delete.Table("AspNetUserClaims");
    }
}