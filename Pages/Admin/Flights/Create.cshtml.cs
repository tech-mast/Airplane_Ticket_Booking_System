using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EagleFlight.Data;
using EagleFlight.Models;

namespace EagleFlight.Pages.Admin.Flights
{
    public class CreateModel : PageModel
    {
        private readonly EagleFlight.Data.EagleFlightDbContext _context;

        public CreateModel(EagleFlight.Data.EagleFlightDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FlightPlaneId"] = new SelectList(_context.Planes, "Id", "Description");
            return Page();
        }

        [BindProperty]
        public Flight Flight { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Flights.Add(Flight);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
