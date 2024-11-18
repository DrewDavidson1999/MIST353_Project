using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.WeatherCurrent
{
    public class EditModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public EditModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ExtWeatherCurrent ExtWeatherCurrent { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extweathercurrent =  await _context.ExtWeatherCurrents.FirstOrDefaultAsync(m => m.WeatherId == id);
            if (extweathercurrent == null)
            {
                return NotFound();
            }
            ExtWeatherCurrent = extweathercurrent;
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

            _context.Attach(ExtWeatherCurrent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtWeatherCurrentExists(ExtWeatherCurrent.WeatherId))
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

        private bool ExtWeatherCurrentExists(int id)
        {
            return _context.ExtWeatherCurrents.Any(e => e.WeatherId == id);
        }
    }
}
