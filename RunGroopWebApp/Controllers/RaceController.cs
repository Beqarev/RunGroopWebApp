using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RunGroopWebApp.Controllers;

public class RaceController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}