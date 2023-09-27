using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository;

public class UserRepository : IUserRepository
{
    private readonly DataContext _context;

    public UserRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<AppUser>> GetAllUsers()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<AppUser> GetUserById(string id)
    {
        return await _context.Users.FindAsync(id);
    }

    public bool Add(AppUser appUser)
    {
        _context.Add(appUser);
        return Save();
    }

    public bool Update(AppUser appUser)
    {
        _context.Update(appUser);
        return Save();
    }

    public bool Delete(AppUser appUser)
    {
        _context.Remove(appUser);
        return Save();
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}