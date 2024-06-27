using Microsoft.AspNetCore.Mvc;

namespace eGradiliste.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
