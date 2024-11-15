using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertLocationController : ControllerBase
    {
        private readonly IInsertLocation _insertLocationServ;

        public InsertLocationController(IInsertLocation insertLocationServ)
        {
            _insertLocationServ = insertLocationServ;
        }

        [HttpPost("{city}/{state}/{country}")]
        public async Task<ActionResult> InsertLocationGetDetails(string city, string state, string country)
        {
            var result = await _insertLocationServ.InsertLocationGetDetails(city, state, country);

            if (result <= 0)
            {
                return BadRequest("Failed to insert location.");
            }

            // Construct the response object
            var createdLocation = new
            {
                city,
                state,
                country
            };

            // Return 201 Created with location details in the response body
            return CreatedAtAction(nameof(InsertLocationGetDetails), new { city, state, country }, createdLocation);
        }
    }
}