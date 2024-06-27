using System.ComponentModel.DataAnnotations;

namespace eGradiliste.eGradiliste.Model;

public class VrsteProizvoda
{
    [Key]
    public int VrstaId { get; set; }
    public string Naziv { get; set; } = null!;
}
