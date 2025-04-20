using dotnet_api.Logic;
using dotnet_api.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dotnet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HockeyPlayerController : ControllerBase
    {
        private readonly IPlayerService _service;

        public HockeyPlayerController(IPlayerService service)
        {
            this._service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPlayersAsync()
        {
            var players = await this._service.GetAllPlayersAsync();
            return Ok(new { players.Count, Players = players });
        }
        [HttpGet("{searchVal}")]
        public async Task<IActionResult> SearchPlayerByNameAsync(string searchVal)
        {
            var result = await this._service.SearchPlayerAsync(searchVal);
            return Ok(new { result.Count, Players = result });
        }
        [HttpPost]
        public async Task<IActionResult> AddPlayerAsync([FromBody] AddPlayerDTO player)
        {
            if (player.NationId < 1 || player.NationId > 6)
                return BadRequest("NationId must be between 1 and 6");
            await this._service.AddPlayerAsync(player);
            return Ok("player added");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePlayerAsync([FromBody] UpdatePlayerDTO player)
        {
            if (player.NationId < 1 || player.NationId > 6)
                return BadRequest("NationId must be between 1 and 6");
            bool check = await this._service.UpdatePlayerAsync(player);
            if (check)
                return Ok("Player Updated");
            else
                return BadRequest("Player dose not exist");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerAsync(int id)
        {
            bool check = await this._service.DeletePlayerAsync(id);
            if (check)
                return Ok($"Player with Id: {id} deleted");
            else
                return StatusCode(202,$"Player with Id: {id} dose not exist");
        }
    }
}
