using MongoDB.Driver;
using Soccer_Tournament.Models;
using Soccer_Tournament.Respositories.Interfaces;

namespace Soccer_Tournament.Respositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly IMongoCollection<Player> _players;

        public PlayerRepository(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDb"));
            var database = client.GetDatabase("FootballDb");
            _players = database.GetCollection<Player>("Players");
        }

        public async Task<Player> GetByIdAsync(string id)
        {
            return await _players.Find(player => player.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Player player)
        {
            await _players.InsertOneAsync(player);
        }
    }

}

