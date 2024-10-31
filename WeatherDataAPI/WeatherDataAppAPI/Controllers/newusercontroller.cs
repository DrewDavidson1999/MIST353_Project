using Microsoft.AspNetCore.Mvc;

namespace WeatherDataAppAPI.Controllers
{
	public class newusercontroller : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
