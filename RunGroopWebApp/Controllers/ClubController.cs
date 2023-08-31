using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Controllers;

public class ClubController : Controller
{
    private readonly DataContext _context;

    public ClubController(DataContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        List<Club> clubs = _context.Clubs.ToList();
        return View(clubs);
    }

    public IActionResult Detail(int id)
    {
        Club club = _context.Clubs.Include(c => c.Address).FirstOrDefault(c => c.Id == id);
        return View(club);
    }
}