using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangePreferredLocationController : Controller
    {
        private readonly IUpdatePreferredLocation updatePreferredLocation;
        public ChangePreferredLocationController(IUpdatePreferredLocation updatePreferredLocation)
        {
            this.updatePreferredLocation = updatePreferredLocation;
        }
        [HttpGet("{userid, location}")]

        public async Task<List<UpdatePreferredLocation>> ChangePreferredLocation(int userid, string location)
        {
            var prefLocation = await updatePreferredLocation.ChangePreferredLocation(userid, location);
            if (prefLocation == null)
            {
                // return NotFound();
            }
            return prefLocation;

        }
    }
}
