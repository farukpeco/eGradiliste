using System;
using System.Collections.Generic;

namespace eGradiliste.Database;

public partial class Proizvodi
{
    public int ProizvodiId { get; set; }

    public string Naziv { get; set; } = null!;

    public string Sifra { get; set; } = null!;

    public decimal Cijena { get; set; }

    public int VrstaId { get; set; }

    public int JedinicaMjereId { get; set; }

    public byte[] Slika { get; set; } = null!;

    public byte[] SlikaThumb { get; set; } = null!;

    public bool? Status { get; set; }

    public string StateMachine { get; set; } = null!;
}
