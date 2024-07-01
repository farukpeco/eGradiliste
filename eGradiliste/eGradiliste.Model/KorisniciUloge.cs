using System;

namespace eGradiliste.Model
{
    public partial class KorisniciUloge
    {
        public int KorisnikUlogaId { get; set; }

        public int KorisnikId { get; set; }

        public int UlogaId { get; set; }

        public DateTime DatumIzmjene { get; set; }
    }
}
