using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.PreferredLocUpdate
{
    public class EditModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public EditModel(SampleProject.Data.WeatherDataDbContext context)
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

            var extuserpreferredlocation =  await _context.ExtUserPreferredLocations.FirstOrDefaultAsync(m => m.UserId == id);
            if (extuserpreferredlocation == null)
            {
                return NotFound();
            }
            ExtUserPreferredLocation = extuserpreferredlocation;
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

            _context.Attach(ExtUserPreferredLocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtUserPreferredLocationExists(ExtUserPreferredLocation.UserId))
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

        private bool ExtUserPreferredLocationExists(int id)
        {
            return _context.ExtUserPreferredLocations.Any(e => e.UserId == id);
        }
    }
}
