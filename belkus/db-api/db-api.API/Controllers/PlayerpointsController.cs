using db_api.Application.Services;
using db_api.Domain.DTO.Cmi.CmiUsers;
using db_api.Domain.Interfaces.Services;
using db_api.Domain.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace db_api.API.Controllers
{
    [Route("api/get-wallet/belkoin")]
    [ApiController]
    public class PlayerpointsController : ControllerBase
    {
        private readonly IPlayerpointsPointsService _playerpointsPointsService;

        public PlayerpointsController(IPlayerpointsPointsService playerpointsPointsService)
        {
            _playerpointsPointsService = playerpointsPointsService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BaseResult<CmiUsersDTO>>> GetUserPlayerpoints(string uuid)
        {
            var responce = await _playerpointsPointsService
                .GetUserPlayerpointsByUUIDAsync(uuid);
            if (responce.IsSuccess)
            {
                return Ok(responce);
            }



            return BadRequest(responce);
        }

    }
}
