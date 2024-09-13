using db_api.Application.Services;
using db_api.Domain.DTO.Cmi.CmiUsers;
using db_api.Domain.Interfaces.Services;
using db_api.Domain.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace db_api.API.Controllers
{
    [Route("api/get-lands")]
    [ApiController]
    public class LandsController : ControllerBase
    {
        private readonly ILandsLandsService _landsLandsService;

        public LandsController(ILandsLandsService landsLandsService)
        {
            _landsLandsService = landsLandsService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BaseResult<CmiUsersDTO>>> GetUserReputation(string uuid)
        {
            var responce = await _landsLandsService.GetLandsByUUIDAsync(uuid);
            if (responce.IsSuccess)
            {
                return Ok(responce);
            }



            return BadRequest(responce);
        }
    }
}
