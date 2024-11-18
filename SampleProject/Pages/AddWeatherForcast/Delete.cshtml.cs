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
    public class DeleteModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public DeleteModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extweatherforecast = await _context.ExtWeatherForecasts.FindAsync(id);
            if (extweatherforecast != null)
            {
                ExtWeatherForecast = extweatherforecast;
                _context.ExtWeatherForecasts.Remove(ExtWeatherForecast);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
