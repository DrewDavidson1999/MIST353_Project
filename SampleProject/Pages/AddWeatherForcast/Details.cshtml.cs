using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.AddWeatherForcast
{
    public class DetailsModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public DetailsModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        public ExtWeatherForecast ExtWeatherForecast { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extweatherforecast = await _context.ExtWeatherForecasts.FirstOrDefaultAsync(m => m.ForecastId == id);
            if (extweatherforecast == null)
            {
                return NotFound();
            }
            else
            {
                ExtWeatherForecast = extweatherforecast;
            }
            return Page();
        }
    }
}
