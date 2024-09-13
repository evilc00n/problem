using db_api.Application.Services;
using db_api.Domain.DTO.Cmi.CmiUsers;
using db_api.Domain.Interfaces.Services;
using db_api.Domain.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace db_api.API.Controllers
{
    [Route("api/get-rep")]
    [ApiController]
    public class ReputationController : ControllerBase
    {
        private readonly IReputationService _reputationService;

        public ReputationController(IReputationService reputationService)
        {
            _reputationService = reputationService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BaseResult<CmiUsersDTO>>> GetUserReputation(string uuid)
        {
            var responce = await _reputationService.GetUserReputationByUUIDAsync(uuid);
            if (responce.IsSuccess)
            {
                return Ok(responce);
            }



            return BadRequest(responce);
        }
    }
}
