using Microsoft.AspNetCore.Mvc;
using Soccer_Tournament.Models;
using Soccer_Tournament.Services;
using Soccer_Tournament.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Soccer_Tournament.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var player = await _playerService.GetPlayerByIdAsync(id);
            if (player == null)
                return NotFound();
            return Ok(player);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Player players)
        {
            var player = await _playerService.CreatePlayerAsync(players);
            return Ok(player);
        }
    }
}
