
using AutoMapper;
using db_api.Application.Resources;
using db_api.Domain.DTO.Cmi.CmiUsers;
using db_api.Domain.Entities.Cmi;
using db_api.Domain.Enums;
using db_api.Domain.Interfaces.Repositories;
using db_api.Domain.Interfaces.Services;
using db_api.Domain.Result;
using Microsoft.EntityFrameworkCore;
using Serilog;



namespace db_api.Application.Services
{
    public class CmiUsersService : ICmiUsersService
    {
        private readonly IBaseRepository<CmiUsers> _cmiRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;



        public CmiUsersService(IBaseRepository<CmiUsers> cmiRepository, 
                    IMapper mapper, ILogger logger)
        {
            _cmiRepository = cmiRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<BaseResult<CmiUsersDTO>> GetUserByUsernameAsync(string username)
        {
            var user = await _cmiRepository.GetAll().FirstOrDefaultAsync(x => x.Username == username);

            if (user == null)
            {
                _logger.Error(ErrorMessage.UserNotFound);
                return new BaseResult<CmiUsersDTO>()
                {
                    ErrorMessage = ErrorMessage.UserNotFound,
                    ErrorCode = (int)ErrorCodes.UserNotFound
                };
            }

            return new BaseResult<CmiUsersDTO>()
            {
                Data = _mapper.Map<CmiUsersDTO>(user),
            };
        }
    }
}
