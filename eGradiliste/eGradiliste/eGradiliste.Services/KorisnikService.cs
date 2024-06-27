using eGradiliste.eGradiliste.Model;
using eGradiliste.eGradiliste.Services.Database;

namespace eGradiliste.eGradiliste.Services;

public class KorisnikService : IKorisnikService
{
    public eGradilisteContext _context { get; set; }

    public KorisnikService(eGradilisteContext context)
    {
        _context = context;
    }

    public List<Korisnici> Get()
    {
        return _context.Korisnici.ToList();
    }
}
