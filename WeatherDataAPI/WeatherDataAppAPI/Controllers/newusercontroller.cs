using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
{
	public class newusercontroller : Controller
	{
        private readonly NewUserServ NewUser;
        public newusercontroller(NewUserServ NewUser)
        {
            this.NewUserServ = NewUser;
        }

        [HttpGet("{userName, email, passwordHash}")]
        public async Task<bool<NewUser>> InsertNewUserGetDetails(string userName, string email, string passwordHash);
        {
            var NewUserDetails = await NewUserServ.InsertNewUserGetDetails(userName, email, passwordHash);
            if (NewUserDetails == null)
            {
                return NotFound();
            }
            {
                return NewUserDetails;
            }
	}
}
