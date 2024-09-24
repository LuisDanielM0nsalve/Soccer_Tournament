using Soccer_Tournament.Models;

namespace Soccer_Tournament.Services.Interfaces
{
    public interface IMatchService
    {
        Task<Match> GetMatchByIdAsync(string id);
        Task<bool> CreateMatchAsync(Match match);
        Task<bool> DeleteMatchAsync(string id);
    }
}
