using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository;

public class RaceRepository : IRaceRepository
{
    private readonly DataContext _context;

    public RaceRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Race>> GetRaces()
    {
        return await _context.Races.ToListAsync();
    }

    public async Task<Race> GetRace(int id)
    {
        return await _context.Races.Include(c => c.Address).FirstOrDefaultAsync(r => r.Id == id);
    }
    
    public async Task<IEnumerable<Race>> GetRaceByCity(string city)
    {
        return await _context.Races.Where(x => x.Address.City.Contains(city)).ToListAsync();
    }


    public bool Add(Race race)
    {
        _context.Add(race);
        return Save();
    }

    public bool Update(Race race)
    {
        _context.Update(race);
        return Save();
    }

    public bool Delete(Race race)
    {
        _context.Remove(race);
        return Save();
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}