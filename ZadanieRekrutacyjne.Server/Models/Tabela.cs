namespace ZadanieRekrutacyjne.Server.Models;

public class Tabela
{
    public virtual Guid Id { get; set; }
    public virtual string Nazwa_Tabeli { get; set; }
    public virtual string Tag { get; set; }
    public virtual int Progress { get; set; }
    public virtual Guid WorkspaceId { get; set; }
}