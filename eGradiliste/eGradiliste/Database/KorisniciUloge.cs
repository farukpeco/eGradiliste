using System;
using System.Collections.Generic;

namespace eGradiliste.Database;

public partial class KorisniciUloge
{
    public int KorisnikUlogaId { get; set; }

    public int KorisnikId { get; set; }

    public int UlogaId { get; set; }

    public DateTime DatumIzmjene { get; set; }

    public int? KorisniciKorisnikId { get; set; }

    public virtual Korisnici? KorisniciKorisnik { get; set; }

    public virtual Uloge Uloga { get; set; } = null!;
}
