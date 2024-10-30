using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class WeatherDataDeleteController : Controller
	{

		private readonly IWeatherDataDelete weatherDataDelete;
		public WeatherDataDeleteController(IWeatherDataDelete weatherDataDelete)
		{
			this.weatherDataDelete = weatherDataDelete;
		}

		[HttpDelete("{locationID}")]
		public async Task<List<WeatherDataDelete>> PreLocDeleteDelete(int locationID)
		{
			var PreLocDeleteDelete = await weatherDataDelete.PreLocDeleteDelete(locationID);
			if (PreLocDeleteDelete == null)
			{
				//return NotFound();
			}
			{
				return PreLocDeleteDelete;
			}
		}

	}
}
