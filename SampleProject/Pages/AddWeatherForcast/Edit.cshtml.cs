using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.AddWeatherForcast
{
    public class EditModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public EditModel(SampleProject.Data.WeatherDataDbContext context)
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

            var extweatherforecast =  await _context.ExtWeatherForecasts.FirstOrDefaultAsync(m => m.ForecastId == id);
            if (extweatherforecast == null)
            {
                return NotFound();
            }
            ExtWeatherForecast = extweatherforecast;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ExtWeatherForecast).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtWeatherForecastExists(ExtWeatherForecast.ForecastId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExtWeatherForecastExists(int id)
        {
            return _context.ExtWeatherForecasts.Any(e => e.ForecastId == id);
        }
    }
}
