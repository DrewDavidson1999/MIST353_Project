using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.WeatherCurrent
{
    public class SearchModel : PageModel
    {
        private readonly WeatherDataDbContext _context;

        public SearchModel(WeatherDataDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string? City { get; set; }

        public IList<ExtWeatherCurrent> ExtWeatherCurrent { get; set; } = new List<ExtWeatherCurrent>();

        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(City))
            {
                // Filter the results by city
                ExtWeatherCurrent = await _context.ExtWeatherCurrents
                    .Where(w => EF.Functions.Like(w.Location, $"%{City}%"))
                    .ToListAsync();
            }
            else
            {
                // Show all results if no specific city is entered
                ExtWeatherCurrent = await _context.ExtWeatherCurrents.ToListAsync();
            }
        }
    }
}
