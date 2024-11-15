using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.Location
{
    public class EditModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public EditModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ExtLocation ExtLocation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extlocation =  await _context.ExtLocations.FirstOrDefaultAsync(m => m.LocationId == id);
            if (extlocation == null)
            {
                return NotFound();
            }
            ExtLocation = extlocation;
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

            _context.Attach(ExtLocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtLocationExists(ExtLocation.LocationId))
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

        private bool ExtLocationExists(int id)
        {
            return _context.ExtLocations.Any(e => e.LocationId == id);
        }
    }
}
