using Microsoft.AspNetCore.Mvc;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangePWController : Controller
    {
        private readonly IChangePW changePW;
        public ChangePWController(IChangePW changePW)
        {
            this.changePW = changePW;
        }
        [HttpGet("{userid, passwordhash}")]
        public async Task<List<ChangePW>> ChangePassword(int userid, string passwordhash)
        {
            var password = await changePW.ChangePassword(userid, passwordhash);
            if (password == null)
            {
                //return NotFound();
            }
            return password;

        }
    }
}
