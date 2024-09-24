using Soccer_Tournament.Models;

namespace Soccer_Tournament.Respositories.Interfaces
{
    public interface IPlayerRepository
    {
        Task<Player> GetByIdAsync(string id);
        Task CreateAsync(Player player);
    }
}
