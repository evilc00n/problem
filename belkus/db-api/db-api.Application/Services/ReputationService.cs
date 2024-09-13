
using AutoMapper;
using db_api.Application.Resources;
using db_api.Domain.DTO.Reputation;
using db_api.Domain.Entities.Reputation;
using db_api.Domain.Enums;
using db_api.Domain.Interfaces.Repositories;
using db_api.Domain.Interfaces.Services;
using db_api.Domain.Result;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace db_api.Application.Services
{
    public class ReputationService : IReputationService
    {

        private readonly IBaseRepository<Reputation> _reputationRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;



        public ReputationService(IBaseRepository<Reputation> reputationRepository,
                    IMapper mapper, ILogger logger)
        {
            _reputationRepository = reputationRepository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<BaseResult<ReputationDTO>> GetUserReputationByUUIDAsync(string uuid)
        {
            var reputation = await _reputationRepository.GetAll().FirstOrDefaultAsync(x => x.Uuid == uuid);

            if (reputation == null)
            {
                _logger.Error(ErrorMessage.ReputationNotFound);
                return new BaseResult<ReputationDTO>()
                {
                    ErrorMessage = ErrorMessage.ReputationNotFound,
                    ErrorCode = (int)ErrorCodes.ReputationNotFound
                };
            }

            return new BaseResult<ReputationDTO>()
            {
                Data = _mapper.Map<ReputationDTO>(reputation),
            };
        }
    }
}
