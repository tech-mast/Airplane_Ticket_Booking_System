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
    public class DetailsModel : PageModel
    {
        private readonly EagleFlight.Data.EagleFlightDbContext _context;

        public DetailsModel(EagleFlight.Data.EagleFlightDbContext context)
        {
            _context = context;
        }

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
    }
}
