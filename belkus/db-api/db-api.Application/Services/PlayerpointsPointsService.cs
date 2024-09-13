

using AutoMapper;
using db_api.Application.Resources;
using db_api.Domain.DTO.Playerpoints.Points;
using db_api.Domain.DTO.Reputation;
using db_api.Domain.Entities.Playerpoints;
using db_api.Domain.Enums;
using db_api.Domain.Interfaces.Repositories;
using db_api.Domain.Interfaces.Services;
using db_api.Domain.Result;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace db_api.Application.Services
{
    public class PlayerpointsPointsService : IPlayerpointsPointsService
    {
        private readonly IBaseRepository<PlayerpointsPoints> _playerpointsRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;



        public PlayerpointsPointsService(IBaseRepository<PlayerpointsPoints> playerpointsRepository,
                    IMapper mapper, ILogger logger)
        {
            _playerpointsRepository = playerpointsRepository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<BaseResult<PlayerpointsPointsDTO>> GetUserPlayerpointsByUUIDAsync(string uuid)
        {
            var playerpoints = await _playerpointsRepository.GetAll().FirstOrDefaultAsync(x => x.Uuid == uuid);

            if (playerpoints == null)
            {
                _logger.Error(ErrorMessage.PlayerpointsNotFound);
                return new BaseResult<PlayerpointsPointsDTO>()
                {
                    ErrorMessage = ErrorMessage.PlayerpointsNotFound,
                    ErrorCode = (int)ErrorCodes.PlayerpointsNotFound
                };
            }

            return new BaseResult<PlayerpointsPointsDTO>()
            {
                Data = _mapper.Map<PlayerpointsPointsDTO>(playerpoints),
            };
        }
    }
}
