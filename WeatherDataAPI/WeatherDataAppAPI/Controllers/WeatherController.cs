using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Repositories;
using WeatherDataAppAPI.Data;

namespace WeatherDataAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherRepository _weatherRepository;

        // Constructor that injects the WeatherRepository
        public WeatherController(WeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        // Define an HTTP GET method to retrieve weather data by city
        [HttpGet("GetWeatherByCity/{city}")]
        public ActionResult<IEnumerable<WeatherData>> GetWeatherByCity(string city)
        {
            // Fetch data using the repository
            var result = _weatherRepository.GetCurrentWeatherByCity(city);

            // Check if no results were returned
            if (result == null)
            {
                return NotFound($"Weather data for city '{city}' not found.");
            }

            return Ok(result); // Return the weather data if found
        }
    }
}
