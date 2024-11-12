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
        public async Task<ActionResult<int>> InsertLocationGetDetails(string city, string state, string country)
        {
            var result = await _insertLocationServ.InsertLocationGetDetails(city, state, country);

            if (result <= 0)
            {
                return BadRequest("Failed to insert location.");
            }

            return Ok(result);
        }
    }
}