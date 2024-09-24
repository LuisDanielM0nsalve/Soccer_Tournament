using Soccer_Tournament.Models;
using Soccer_Tournament.Respositories;
using Soccer_Tournament.Respositories.Interfaces;
using Soccer_Tournament.Services.Interfaces;

namespace Soccer_Tournament.Services
{
    
        public class MatchService : IMatchService
        {
            private readonly IMatchRepository _matchRepository;

            public MatchService(IMatchRepository matchRepository)
            {
                _matchRepository = matchRepository;
            }

            public async Task<Match> GetMatchByIdAsync(string id)
            {
                return await _matchRepository.GetByIdAsync(id);
            }

            public async Task<bool> CreateMatchAsync(Match request)
            {
                var match = new Match
                {
                    Team1 = request.Team1,
                    Team2 = request.Team2,
                    Category = request.Category,
                    TeamLoser = request.TeamLoser,
                    TeamWinner = request.TeamWinner,
                    Time = request.Time,
                };
                await _matchRepository.CreateAsync(match);
                return true;
            }

            public async Task<bool> DeleteMatchAsync(string id)
            {
                return await _matchRepository.DeleteAsync(id);
            }
        }

}
