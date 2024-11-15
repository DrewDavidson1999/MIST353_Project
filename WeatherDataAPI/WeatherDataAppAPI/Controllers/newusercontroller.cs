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

        [HttpPost("InsertNewUser/{userName}/{email}/{passwordHash}")]
        public async Task<ActionResult> InsertNewUserGetDetails(string userName, string email, string passwordHash)
        {
            var result = await _newUserServ.InsertNewUserGetDetails(userName, email, passwordHash);

            if (result <= 0)
            {
                return BadRequest("Failed to insert new user.");
            }

            // Construct the response object
            var createdUser = new
            {
                userName,
                email
            };

            // Return 201 Created with user details in the response body
            return CreatedAtAction(nameof(InsertNewUserGetDetails), new { userName, email, passwordHash }, createdUser);
        }
    }
}