using Microsoft.AspNetCore.Mvc;
using Soccer_Tournament.Models;
using Soccer_Tournament.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Soccer_Tournament.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchsController : ControllerBase
    {
        // GET: api/<MatchController>
        private readonly IMatchService _matchService;

        public MatchsController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var match = await _matchService.GetMatchByIdAsync(id);
            if (match == null)
                return NotFound();
            return Ok(match);
        }

        [HttpPost("add-match")]
        public async Task<IActionResult> Post([FromBody] Match match)
        {
            var result = await _matchService.CreateMatchAsync(match);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatch(string id)
        {
            var result = await _matchService.DeleteMatchAsync(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
