using db_api.Domain.DTO.Reputation;
using db_api.Domain.Result;

namespace db_api.Domain.Interfaces.Services
{
    public interface IReputationService
    {
        Task<BaseResult<ReputationDTO>> GetUserReputationByUUIDAsync(string uuid);
    }
}
