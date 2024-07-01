using eGradiliste.Model;
using eGradiliste.eGradiliste.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGradiliste.Controllers;

[ApiController]
[Route("[controller]")]
public class KorisnikController : Controller
{
    private readonly IKorisnikService _korisnikService;
    public KorisnikController(IKorisnikService korisnikService)
    {
        _korisnikService = korisnikService;
    }

    [HttpGet]
    public IList<Korisnici> Index()
    {
        return _korisnikService.Get();
    }
}
