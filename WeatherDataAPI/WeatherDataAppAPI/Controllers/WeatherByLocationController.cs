using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Repositories;
using System;
using System.Collections.Generic;

namespace WeatherDataAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherByLocationController : ControllerBase
    {
        private readonly WeatherRepository _weatherRepository;

        public WeatherByLocationController(WeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        // Existing HTTP GET method to retrieve weather data by city
        [HttpGet("GetWeatherByCity/{city}")]
        public ActionResult<IEnumerable<IWeatherData>> GetWeatherByCity(string city)
        {
            try
            {
                var result = _weatherRepository.GetCurrentWeatherByCity(city);
                if (result == null || !result.Any())
                {
                    return NotFound($"Weather data for city '{city}' not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        // New HTTP POST method to add a new weather forecast
        [HttpPost("AddWeatherForecast")]
        public IActionResult AddWeatherForecast([FromBody] WeatherForecastRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input data.");
            }

            try
            {
                _weatherRepository.AddWeatherForecast(request.Region, request.ForecastDate, request.Temperature, request.WeatherDescription);
                return Ok("Weather forecast added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }
    }

    // Data Transfer Object for the forecast request payload
    public class WeatherForecastRequest
    {
        public required string Region { get; set; }
        public DateTime ForecastDate { get; set; }
        public double Temperature { get; set; }
        public required string WeatherDescription { get; set; }
    }
}



