using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class WeatherDataAddController : Controller
	{

		private readonly IWeatherDataAdd weatherDataAdd;
		public WeatherDataAddController(IWeatherDataAdd weatherDataAdd)
		{
			this.weatherDataAdd = weatherDataAdd;
		}

		[HttpGet("{locationID, city, state, country}")]
		public async Task<List<WeatherDataAdd>> PreLocAddGetDetails(string city, string state, string country)
		{
			var PreLocAddDetails= await weatherDataAdd.PreLocAddGetDetails(city, state, country);
			if (PreLocAddDetails == null)
			{
				//return NotFound();
			}
			{
				return PreLocAddDetails;
			}
		}

	}
}
