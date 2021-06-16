using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EagleFlight.Data;
using EagleFlight.Models;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EagleFlight.Pages
{
    public class AjaxsearchResultTwoModel : PageModel
    {
        private readonly EagleFlightDbContext db; 
        private readonly ILogger<IndexModel> logger;

        public AjaxsearchResultTwoModel(EagleFlightDbContext db, ILogger<IndexModel> logger)
        {
            this.db = db;
            this.logger = logger;  
        }

        public List<Flight> FlightSearchList { get; set; } = new List<Flight>();

        [BindProperty(SupportsGet =true)]
        public String OriginLocation { get; set; }

        [BindProperty(SupportsGet =true)]
        public String ArriveLocation { get; set; }

        [BindProperty(SupportsGet =true),Required, Display(Name="DepartureDate")]
        public DateTime DepartureDate { get; set; }

        [BindProperty(SupportsGet =true)]
        public DateTime ArriveTime { get; set; }

        [BindProperty(SupportsGet =true)]
        public string FlightClass { get; set; }
        [BindProperty(SupportsGet =true)]
        public string FlightId { get; set; }

        [BindProperty]
        public string FlightClassTwo { get; set; }
        [BindProperty]
        public string FlightIdTwo { get; set; }

        [BindProperty(SupportsGet =true)]
        public string TripType { get; set; }

        public async Task OnGetAsync()
        {
            // FlightSearchList = await db.Flights.Join(db.Planes, Flight =>Flight.FlightPlane.Id, Plane => Plane.Id,(Flight,Plane) =>new{Flight,Plane}).Where(u =>u.Origin == OriginLocation && u.Destination == ArriveLocation && u.DepartureTime.Date == DepartureDate.Date).ToListAsync();
            FlightSearchList = await db.Flights.Include(Flight => Flight.FlightPlane).Where(u =>u.Origin == OriginLocation && u.Destination == ArriveLocation && u.DepartureTime.Date == DepartureDate.Date).ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
        if (ModelState.IsValid)
        {            
            logger.LogInformation($"flightId: {FlightId}");
            logger.LogInformation($"flightClass: {FlightClass}");
            logger.LogInformation($"flightIdTwo: {FlightIdTwo}");
            logger.LogInformation($"flightClassTwo: {FlightClassTwo}");
            return RedirectToPage("/TicketSummary", new { FlightId = FlightId, FlightClass = FlightClass,TripType=TripType,FlightIdTwo = FlightIdTwo, FlightClassTwo = FlightClassTwo});
            
        }
        return Page();
        }
    }
}
