using dotnet_api.Models;
using dotnet_api.Models.DTO;

namespace dotnet_api.Logic
{
    public interface IPlayerService
    {
        Task<List<HockeyPlayer>> GetAllPlayersAsync();
        Task<List<HockeyPlayer>> SearchPlayerAsync(string searchVal);
        Task AddPlayerAsync(AddPlayerDTO player);
        Task<bool> UpdatePlayerAsync(UpdatePlayerDTO player);
        Task<bool> DeletePlayerAsync(int Id);
    }
}
