using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository;

public class ClubRepository : IClubRepository
{
    private readonly DataContext _context;

    public ClubRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Club>> GetClubs()
    {
        return await _context.Clubs.ToListAsync();
    }

    public async Task<Club> GetClub(int id)
    {
        return await _context.Clubs.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Club>> GetClubByCity(string city)
    {
        return await _context.Clubs.Where(c => c.Address.City.Contains(city)).ToListAsync();
    }

    public bool Add(Club club)
    {
        _context.Add(club);
        return Save();
    }

    public bool Update(Club club)
    {
        _context.Update(club);
        return Save();
    }

    public bool Delete(Club club)
    {
        _context.Remove(club);
        return Save();
    }

    public bool Save()
    {
        throw new NotImplementedException();
    }
}