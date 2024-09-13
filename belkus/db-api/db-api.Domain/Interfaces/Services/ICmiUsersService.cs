using db_api.Domain.DTO.Cmi.CmiUsers;
using db_api.Domain.Result;

namespace db_api.Domain.Interfaces.Services
{
    public interface ICmiUsersService
    {
        Task<BaseResult<CmiUsersDTO>> GetUserByUsernameAsync(string username);
    }
}
