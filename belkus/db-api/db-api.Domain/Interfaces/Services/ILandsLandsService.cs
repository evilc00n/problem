

using db_api.Domain.DTO.Lands.LandsLands;
using db_api.Domain.Result;

namespace db_api.Domain.Interfaces.Services
{
    public interface ILandsLandsService
    {
        Task<CollectionResult<LandsLandsDTO>> GetLandsByUUIDAsync(string uuid);
    }
}
