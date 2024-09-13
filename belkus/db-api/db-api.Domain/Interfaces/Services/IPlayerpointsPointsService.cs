

using db_api.Domain.DTO.Playerpoints.Points;
using db_api.Domain.Result;

namespace db_api.Domain.Interfaces.Services
{
    public interface IPlayerpointsPointsService
    {
        Task<BaseResult<PlayerpointsPointsDTO>> GetUserPlayerpointsByUUIDAsync(string uuid);
    }
}
