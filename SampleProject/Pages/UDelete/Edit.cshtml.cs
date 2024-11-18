using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.UDelete
{
    public class EditModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public EditModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ExtUser ExtUser { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extuser =  await _context.ExtUsers.FirstOrDefaultAsync(m => m.UserId == id);
            if (extuser == null)
            {
                return NotFound();
            }
            ExtUser = extuser;
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

            _context.Attach(ExtUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtUserExists(ExtUser.UserId))
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

        private bool ExtUserExists(int id)
        {
            return _context.ExtUsers.Any(e => e.UserId == id);
        }
    }
}
