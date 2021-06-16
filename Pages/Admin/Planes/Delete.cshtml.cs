using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EagleFlight.Data;
using EagleFlight.Models;

namespace EagleFlight.Pages.Admin.Planes
{
    public class DeleteModel : PageModel
    {
        private readonly EagleFlight.Data.EagleFlightDbContext _context;

        public DeleteModel(EagleFlight.Data.EagleFlightDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Plane Plane { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plane = await _context.Planes.FirstOrDefaultAsync(m => m.Id == id);

            if (Plane == null)
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

            Plane = await _context.Planes.FindAsync(id);

            if (Plane != null)
            {
                _context.Planes.Remove(Plane);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
