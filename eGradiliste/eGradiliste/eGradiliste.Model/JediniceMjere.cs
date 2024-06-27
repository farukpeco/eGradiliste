using System.ComponentModel.DataAnnotations;

namespace eGradiliste.eGradiliste.Model;

public class JediniceMjere
{
    [Key]
    public int JedinicaMjereId { get; set; }
    public string Naziv { get; set; } = null!;
}
