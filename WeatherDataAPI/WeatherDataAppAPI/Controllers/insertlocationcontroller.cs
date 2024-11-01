using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
    [Route("api/[controller]")]
    [ApiController]
{
	public class InsertLocationController : ControllerBase
	{
        private readonly InsertLocationServ _insertLocationServ;

        public InsertLocationController(InsertLocationServ insertLocationServ)
        {
            _insertLocationServ = insertLocationServ;
        }

        [HttpGet("{city}/{state}/{country}")]
        public ActionResult<InsertLocation> InsertLocationGetDetails(string city, string state, string country)
        {
            var locationDetails = _insertLocationServ.InsertLocationGetDetails(city, state, country);
            if (locationDetails == null)
            {
                return NotFound();
            }

            return Ok(locationDetails);
        }
    }
}