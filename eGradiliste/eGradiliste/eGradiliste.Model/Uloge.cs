using System.ComponentModel.DataAnnotations;

namespace eGradiliste.eGradiliste.Model;

public class Uloge
{
    [Key]
    public int UlogaId { get; set; }

    public string Naziv { get; set; } = null!;

    public string? Opis { get; set; }
}
