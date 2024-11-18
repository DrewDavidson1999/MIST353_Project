using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.WeatherCurrent
{
    public class IndexModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public IndexModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        public IList<ExtWeatherCurrent> ExtWeatherCurrent { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ExtWeatherCurrent = await _context.ExtWeatherCurrents.ToListAsync();
        }
    }
}
