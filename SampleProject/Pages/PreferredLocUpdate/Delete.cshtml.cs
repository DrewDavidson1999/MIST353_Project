using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.PreferredLocUpdate
{
    public class DeleteModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public DeleteModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ExtUserPreferredLocation ExtUserPreferredLocation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extuserpreferredlocation = await _context.ExtUserPreferredLocations.FirstOrDefaultAsync(m => m.UserId == id);

            if (extuserpreferredlocation == null)
            {
                return NotFound();
            }
            else
            {
                ExtUserPreferredLocation = extuserpreferredlocation;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extuserpreferredlocation = await _context.ExtUserPreferredLocations.FindAsync(id);
            if (extuserpreferredlocation != null)
            {
                ExtUserPreferredLocation = extuserpreferredlocation;
                _context.ExtUserPreferredLocations.Remove(ExtUserPreferredLocation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
