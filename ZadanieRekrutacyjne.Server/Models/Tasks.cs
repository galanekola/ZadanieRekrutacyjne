namespace ZadanieRekrutacyjne.Server.Models;

public class Tasks
{
    public virtual Guid Id { get; set; }
    public virtual string Nazwa { get; set; }
    public virtual string? Opis { get; set; }
    public virtual DateTime? Deadline { get; set; }
    public virtual DateTime DataUtworzenia { get; set; }
    public virtual int Progress { get; set; }
    public virtual Guid TabelaId { get; set; }
}