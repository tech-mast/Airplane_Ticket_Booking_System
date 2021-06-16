using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EagleFlight.Data;
using EagleFlight.Models;
using Microsoft.AspNetCore.Authorization;

namespace EagleFlight.Pages.Admin.Flights
{
    [Authorize(Roles="Admin")]
    public class IndexModel : PageModel
    {
        private readonly EagleFlight.Data.EagleFlightDbContext _context;

        public IndexModel(EagleFlight.Data.EagleFlightDbContext context)
        {
            _context = context;
        }

        public IList<Flight> Flight { get;set; }

        public async Task OnGetAsync()
        {
            Flight = await _context.Flights
                .Include(f => f.FlightPlane).ToListAsync();
        }
    }
}
