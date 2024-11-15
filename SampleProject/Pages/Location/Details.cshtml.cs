using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.Location
{
    public class DetailsModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public DetailsModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        public ExtLocation ExtLocation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extlocation = await _context.ExtLocations.FirstOrDefaultAsync(m => m.LocationId == id);
            if (extlocation == null)
            {
                return NotFound();
            }
            else
            {
                ExtLocation = extlocation;
            }
            return Page();
        }
    }
}
