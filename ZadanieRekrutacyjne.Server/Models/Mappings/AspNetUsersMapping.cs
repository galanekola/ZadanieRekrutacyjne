using FluentNHibernate.Mapping;

namespace ZadanieRekrutacyjne.Server.Models.Mappings;

public class AspNetUsersMapping : ClassMap<AspNetUsers>
{
    public AspNetUsersMapping()
    {
        Table("AspNetUsers");
        Id(x => x.Id).GeneratedBy.Assigned();
            
        Map(x => x.UserName).Length(256).Not.Nullable();
        Map(x => x.NormalizedUserName).Length(256);
        Map(x => x.Email).Length(256);
        Map(x => x.NormalizedEmail).Length(256);
        Map(x => x.EmailConfirmed);
        Map(x => x.PasswordHash).Length(256);
        Map(x => x.SecurityStamp).Length(256);
        Map(x => x.ConcurrencyStamp).Length(256);
        Map(x => x.PhoneNumber).Length(50);
        Map(x => x.PhoneNumberConfirmed);
        Map(x => x.TwoFactorEnabled);
        Map(x => x.LockoutEnd);
        Map(x => x.LockoutEnabled);
        Map(x => x.AccessFailedCount);
    }
}