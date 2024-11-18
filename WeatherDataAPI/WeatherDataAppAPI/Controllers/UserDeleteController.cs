using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class UserDeleteController : Controller
	{

		private readonly IUserDelete userDelete;
		public UserDeleteController(IUserDelete userDelete)
		{
			this.userDelete = userDelete;
		}

		[HttpDelete("{userID}")]
		public async Task<List<UserDelete>> UserDeleteDelete(int userID)
		{
			var UserDeleteDelete = await userDelete.UserDeleteDelete(userID);
			if (UserDeleteDelete == null)
			{
				//return NotFound();
			}
			{
				return UserDeleteDelete;
			}
		}

	}
}
