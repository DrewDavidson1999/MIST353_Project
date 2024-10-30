﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Repositories;
using WeatherDataAppAPI.Data;

namespace WeatherDataAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherByLocationController : ControllerBase
    {
        private readonly WeatherRepository _weatherRepository;

        // Constructor that injects the WeatherRepository
        public WeatherByLocationController(WeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        // Define an HTTP GET method to retrieve weather data by city
        [HttpGet("GetWeatherByCity/{city}")]
        public ActionResult<IEnumerable<IWeatherData>> GetWeatherByCity(string city)
        {
            try
            {
                // Fetch data using the repository
                var result = _weatherRepository.GetCurrentWeatherByCity(city);

                // Check if no results were returned
                if (result == null || !result.Any())
                {
                    return NotFound($"Weather data for city '{city}' not found.");
                }

                return Ok(result); // Return the weather data if found
            }
            catch (Exception ex)
            {
                // Log the exception if necessary (optional)
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }
    }
}

