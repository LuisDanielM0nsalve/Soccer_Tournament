using MongoDB.Driver;
using Soccer_Tournament.Models;
using Soccer_Tournament.Respositories.Interfaces;

namespace Soccer_Tournament.Respositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly IMongoCollection<Match> _matches;

        public MatchRepository(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDb"));
            var database = client.GetDatabase("FootballDb");
            _matches = database.GetCollection<Match>("Matches");
        }

        public async Task<Match> GetByIdAsync(string id)
        {
            return await _matches.Find(match => match.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Match match)
        {
            await _matches.InsertOneAsync(match);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var result = await _matches.DeleteOneAsync(match => match.Id == id);
            return result.DeletedCount > 0;
        }
    }

}
