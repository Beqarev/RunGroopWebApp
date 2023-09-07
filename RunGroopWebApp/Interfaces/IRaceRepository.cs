using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interfaces;

public interface IRaceRepository
{
    public Task<IEnumerable<Race>> GetRaces();
    public Task<Race> GetByIdAsync(int id);
    Task<Race> GetByIdAsyncNoTracking(int id);
    Task<IEnumerable<Race>> GetRaceByCity(string city);
    bool Add(Race race);
    bool Update(Race race);
    bool Delete(Race race);
    bool Save();
}