using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data;

namespace SampleProject.Pages.Weather
{
    public class IndexModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public IndexModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        public IList<ExtUser> ExtUser { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ExtUser = await _context.ExtUsers.ToListAsync();
        }
    }
}
