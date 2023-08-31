using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RunGroopWebApp.Data;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Controllers;

public class RaceController : Controller
{
    private readonly DataContext _context;

    public RaceController(DataContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        List<Race> races = _context.Races.ToList();
        return View(races);
    }
    
    public IActionResult Detail(int id)
    {
        Race race = _context.Races.Include(c => c.Address).FirstOrDefault(c => c.Id == id);
        return View(race);
    }
}