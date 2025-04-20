using AutoMapper;
using dotnet_api.DataAcces;
using dotnet_api.Models;
using dotnet_api.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace dotnet_api.Logic
{
    public class PlayerService : IPlayerService
    {
        private readonly HockeyPlayerContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<PlayerService> _logger;
        public PlayerService(HockeyPlayerContext context, IMapper mapper, ILogger<PlayerService> logger)
        {
            this._context = context;
            this._mapper = mapper;
            this._logger = logger;
        }
        public async Task<List<HockeyPlayer>> GetAllPlayersAsync()
        {
            var players = await this._context.HockeyPlayers.OrderBy(h => h.Club).AsNoTracking().ToListAsync();

            int totalAge = 0;
            int totalWeight = 0;

            // Simulerar ett steg av databearbetning
            foreach (var player in players)
            {
                totalAge += player.Age;
                totalWeight += player.WeightInKg;
            }
            double averageAge = players.Count != 0 ? (double)totalAge / players.Count : 0;
            double averageWeight = players.Count != 0 ? (double)totalWeight / players.Count : 0;

            _logger.LogInformation("GetAll: Total Age: {totalAge}, Average Age: {averageAge}, Total Weight: {totalWeight}, AverageWeight: {averageWeight}", totalAge, averageAge, totalWeight, averageWeight);

            return players;
        }
        public async Task<List<HockeyPlayer>> SearchPlayerAsync(string searchVal)
        {
            var results = await _context.HockeyPlayers
                .Where(h => h.FullName.Contains(searchVal))
                .Include(h => h.Nation)
                .OrderBy(h => h.Nation.Nationality)
                .AsNoTracking()
                .ToListAsync();

            int totalAge = 0;
            int totalWeight = 0;

            // Simulerar ett steg av databearbetning
            foreach (var player in results)
            {
                totalAge += player.Age;
                totalWeight += player.WeightInKg;
            }
            double averageAge = results.Count != 0 ? (double)totalAge / results.Count : 0;
            double averageWeight = results.Count != 0 ? (double)totalWeight / results.Count : 0;

            _logger.LogInformation("Search: Total Age: {totalAge}, Average Age: {averageAge}, Total Weight: {totalWeight}, AverageWeight: {averageWeight}", totalAge, averageAge, totalWeight, averageWeight);

            return results;
        }
        public async Task AddPlayerAsync(AddPlayerDTO playerDTO)
        {
            var nation = await this._context.Nations.FirstAsync(n => n.Id == playerDTO.NationId);
            var player = this._mapper.Map<HockeyPlayer>(playerDTO);
            player.Nation = nation;
            await this._context.HockeyPlayers.AddAsync(player);
            await this._context.SaveChangesAsync();
        }
        public async Task<bool> UpdatePlayerAsync(UpdatePlayerDTO player)
        {
            var playerToUpdate = await this._context.HockeyPlayers.FirstOrDefaultAsync(h => h.Id == player.Id);
            if (playerToUpdate == null)
                return false;

            this._context.HockeyPlayers.Entry(playerToUpdate).CurrentValues.SetValues(player);
            await this._context.SaveChangesAsync();
            return true;

        }
        public async Task<bool> DeletePlayerAsync(int Id)
        {
            var playerToRemove = await this._context.HockeyPlayers.FirstOrDefaultAsync(p => p.Id == Id);
            if (playerToRemove != null)
            {
                this._context.HockeyPlayers.Remove(playerToRemove);
                await this._context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
