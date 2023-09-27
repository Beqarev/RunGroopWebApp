using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<AppUser>> GetAllUsers();
    Task<AppUser> GetUserById(string id);
    bool Add(AppUser appUser);
    bool Update(AppUser appUser);
    bool Delete(AppUser appUser);
    bool Save();
}