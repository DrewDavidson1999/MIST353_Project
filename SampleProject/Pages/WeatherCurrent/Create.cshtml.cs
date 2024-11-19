﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SampleProject.Data;

namespace SampleProject.Pages.WeatherCurrent
{
    public class CreateModel : PageModel
    {
        private readonly SampleProject.Data.WeatherDataDbContext _context;

        public CreateModel(SampleProject.Data.WeatherDataDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ExtWeatherCurrent ExtWeatherCurrent { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ExtWeatherCurrents.Add(ExtWeatherCurrent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}