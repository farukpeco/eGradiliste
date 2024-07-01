using eGradiliste.Model;
using eGradiliste.Database;
using AutoMapper;

namespace eGradiliste.eGradiliste.Services;

public class KorisnikService : IKorisnikService
{
    public EGradilisteContext _context { get; set; }
    private readonly IMapper _mapper;

    public KorisnikService(EGradilisteContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<Model.Korisnici> Get()
    {
        return _context.Korisnicis.ToList().Select(x => _mapper.Map<Model.Korisnici>(x)).ToList();
    }
}
