using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.Password
{
    public class DeleteModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public DeleteModel(SampleProject.Data.WeatherDataDbContext context)
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

            var extuser = await _context.ExtUsers.FirstOrDefaultAsync(m => m.UserId == id);

            if (extuser == null)
            {
                return NotFound();
            }
            else
            {
                ExtUser = extuser;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extuser = await _context.ExtUsers.FindAsync(id);
            if (extuser != null)
            {
                ExtUser = extuser;
                _context.ExtUsers.Remove(ExtUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
