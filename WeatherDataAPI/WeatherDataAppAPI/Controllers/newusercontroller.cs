using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewUserController : ControllerBase

	{
        private readonly INewUser _newUserServ;

        public NewUserController(INewUser newUserServ)
        {
            _newUserServ = newUserServ;
        }

        [HttpPost("{userName}/{email}/{passwordHash}")]
        public async Task<ActionResult<int>> InsertNewUserGetDetails(string userName, string email, string passwordHash)
        {
            var result = await _newUserServ.InsertNewUserGetDetails(userName, email, passwordHash);

            if (result <= 0)
            {
                return BadRequest("Failed to insert new user.");
            }

            return Ok(result);
        }
    }
}