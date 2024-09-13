using db_api.Domain.DTO.Cmi.CmiUsers;
using db_api.Domain.Interfaces.Services;
using db_api.Domain.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace db_api.API.Controllers
{
    [Route("api/get-user")]
    [ApiController]
    public class CmiController : ControllerBase
    {
        private readonly ICmiUsersService _cmiUsersService;

        public CmiController(ICmiUsersService cmiUsersService)
        {
            _cmiUsersService = cmiUsersService;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BaseResult<CmiUsersDTO>>> GetUserData(string username)
        {
            var responce = await _cmiUsersService.GetUserByUsernameAsync(username);
            if (responce.IsSuccess)
            {
                return Ok(responce);
            }



            return BadRequest(responce);
        }
    }
}
