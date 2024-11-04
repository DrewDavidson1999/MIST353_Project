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
        private INewUser _newUserServ;

        public NewUserController(INewUser newUserServ)
        {
            _newUserServ = newUserServ;
        }

        [HttpGet("{userName}/{email}/{passwordHash}")]
        public ActionResult<NewUser> InsertNewUserGetDetails(string userName, string email, string passwordHash)
        {
            var newUserDetails = _newUserServ.InsertNewUserGetDetails(userName, email, passwordHash);
            if (newUserDetails == null)
            {
                return NotFound();
            }

            return Ok(newUserDetails);
        }
    }
}