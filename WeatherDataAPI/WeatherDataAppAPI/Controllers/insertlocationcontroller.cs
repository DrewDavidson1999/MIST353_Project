using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
{
	public class insertlocationcontroller : Controller
	{
        private readonly InsertLocationServ InsertLocation;
        public insertlocationcontroller(InsertLocationServ InsertLocation)
        {
            this.InsertLocationServ = InsertLocation;
        }

        [HttpGet("{city, state, country}")]
        public async Task<bool<InsertLocation>> InsertLocationGetDetails(string city, string state, string country);
        {
            var LocationDetails = await InsertLocationServ.InsertLocationGetDetails(city, state, country);
            if (LocationDetails == null)
            {
                return NotFound();
            }
            {
                return LocationDetails;
            }
}
