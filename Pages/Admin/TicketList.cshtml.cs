using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using EagleFlight.Models;
using EagleFlight.Data;

namespace EagleFlight.Pages
{
    [Authorize(Roles="Admin")]        
    public class TicketListModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public IList<Ticket> Tickets { get; set; }
        [BindProperty(SupportsGet = true)]
        public int FlightId { get; set; }
        [BindProperty(SupportsGet = true)]
        public IList<Flight> Flights { get; set; }
        private readonly UserManager<EagleFlightUser> userManager;
        private readonly ILogger<TicketListModel> _logger;
        private readonly EagleFlightDbContext _db;
        public TicketListModel(EagleFlightDbContext db, UserManager<EagleFlightUser> userManager,
                            ILogger<TicketListModel> logger)
        {
            _db = db;
            this.userManager = userManager;
            _logger = logger;
        }

        public async Task<IActionResult> OnGetAsync(int flightId)
        {
            FlightId = flightId;
            if(flightId==0){
                Flights = _db.Flights.Where(f => f.Tickets.Count>0).ToList();
            }else{
                Flights = _db.Flights.Where(f => f.Id==flightId).ToList();
            }
            Tickets.Clear();
            foreach(var f in Flights){
                //_logger.LogInformation($"flight # {f.Id} / plane #{f.FlightPlaneId}");
                var _tickets = _db.Tickets.Where(t=>t.BookedFlightId==f.Id).ToList();
                foreach(var t in _tickets){
                    //_logger.LogInformation($"flight # {f.Id} / plane #{f.FlightPlaneId} / ticket #{t.Id}");
                    Tickets.Add(t);
                }
            }
            return Page();
        }
    }
}
