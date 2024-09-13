
using AutoMapper;
using db_api.Application.Resources;
using db_api.Domain.DTO.Lands.LandsLands;
using db_api.Domain.DTO.Playerpoints.Points;
using db_api.Domain.DTO.Reputation;
using db_api.Domain.Entities.Lands;
using db_api.Domain.Entities.Reputation;
using db_api.Domain.Enums;
using db_api.Domain.Interfaces.Repositories;
using db_api.Domain.Interfaces.Services;
using db_api.Domain.Result;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace db_api.Application.Services
{
    public class LandsLandsService : ILandsLandsService
    {
        private readonly IAdvancedLandsRepository _advancedLandsRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public LandsLandsService(IAdvancedLandsRepository advancedLandsRepository, 
                                 IMapper mapper, 
                                 ILogger logger)
        {
            _advancedLandsRepository = advancedLandsRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CollectionResult<LandsLandsDTO>> GetLandsByUUIDAsync(string uuid)
        {
            //var lands = await _advancedLandsRepository.GetLandsByUUID(uuid).ToArrayAsync();
            var lands = await _advancedLandsRepository.GetAll().ToArrayAsync();

            if (lands == null)
            {
                _logger.Error(ErrorMessage.UserNotFound);
                return new CollectionResult<LandsLandsDTO>()
                {
                    ErrorMessage = ErrorMessage.UserNotFound,
                    ErrorCode = (int)ErrorCodes.UserNotFound
                };
            }

            if (!lands.Any())
            {
                return new CollectionResult<LandsLandsDTO>
                {
                    ErrorMessage = ErrorMessage.LandsNotFound,
                    ErrorCode = (int)ErrorCodes.LandsNotFound
                };
            }

            return new CollectionResult<LandsLandsDTO>
            {
                Data = _mapper.Map<IEnumerable<LandsLandsDTO>>(lands),
                Count = lands.Length
            };
        }
    }
}
