using Soccer_Tournament.Models;
using Soccer_Tournament.Respositories;
using Soccer_Tournament.Respositories.Interfaces;
using Soccer_Tournament.Services.Interfaces;
using System.Numerics;

namespace Soccer_Tournament.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<Player> GetPlayerByIdAsync(string id)
        {
            return await _playerRepository.GetByIdAsync(id);
        }

        public async Task<bool> CreatePlayerAsync(Player request)
        {
            var player = new Player
            {
                Name = request.Name,
                Position = request.Position
            };
            await _playerRepository.CreateAsync(player);
            return true;
        }
    }
}
