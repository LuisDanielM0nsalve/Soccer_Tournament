using Soccer_Tournament.Models;

namespace Soccer_Tournament.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<Player> GetPlayerByIdAsync(string id);
        Task<bool> CreatePlayerAsync(Player request);
    }
}
