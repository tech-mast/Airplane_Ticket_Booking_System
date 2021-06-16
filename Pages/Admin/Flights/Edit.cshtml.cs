using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EagleFlight.Data;
using EagleFlight.Models;

namespace EagleFlight.Pages.Admin.Flights
{
    public class EditModel : PageModel
    {
        private readonly EagleFlight.Data.EagleFlightDbContext _context;

        public EditModel(EagleFlight.Data.EagleFlightDbContext context)
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
           ViewData["FlightPlaneId"] = new SelectList(_context.Planes, "Id", "Description");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Flight).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightExists(Flight.Id))
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

        private bool FlightExists(int id)
        {
            return _context.Flights.Any(e => e.Id == id);
        }
    }
}
