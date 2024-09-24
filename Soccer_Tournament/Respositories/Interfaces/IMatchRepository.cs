using Soccer_Tournament.Models;

namespace Soccer_Tournament.Respositories.Interfaces
{
    public interface IMatchRepository
    {
        Task<Match> GetByIdAsync(string id);
        Task CreateAsync(Match match);
        Task<bool> DeleteAsync(string id);
    }
}
