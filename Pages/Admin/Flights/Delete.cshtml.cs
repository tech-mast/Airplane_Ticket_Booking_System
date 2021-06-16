using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EagleFlight.Data;
using EagleFlight.Models;

namespace EagleFlight.Pages.Admin.Flights
{
    public class DeleteModel : PageModel
    {
        private readonly EagleFlight.Data.EagleFlightDbContext _context;

        public DeleteModel(EagleFlight.Data.EagleFlightDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Flight Flight { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight = await _context.Flights
                .Include(f => f.FlightPlane).FirstOrDefaultAsync(m => m.Id == id);

            if (Flight == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight = await _context.Flights.FindAsync(id);

            if (Flight != null)
            {
                _context.Flights.Remove(Flight);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
