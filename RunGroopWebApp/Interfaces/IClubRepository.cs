using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interfaces;

public interface IClubRepository
{
    Task<IEnumerable<Club>> GetClubs();
    Task<Club> GetClub(int id);
    Task<IEnumerable<Club>> GetClubByCity(string city);
    bool Add(Club club);
    bool Update(Club club);
    bool Delete(Club club);
    bool Save();
}