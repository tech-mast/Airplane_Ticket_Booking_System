using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EagleFlight.Data;
using EagleFlight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EagleFlight.Pages
{
    public class SearchResultModel : PageModel
    {
        private readonly EagleFlightDbContext db; 
        private readonly ILogger<IndexModel> logger;

        public SearchResultModel(EagleFlightDbContext db, ILogger<IndexModel> logger)
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

        [BindProperty]
        public string FlightClass { get; set; }
        [BindProperty]
        public string FlightId { get; set; }

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

            var userName = User.Identity.Name; // userName is email
            var user = db.Users.Where(u => u.UserName == userName).FirstOrDefault(); // find user record

            if(user != null){
                if(TripType == "1"){
                return RedirectToPage("/TicketSummary", new { FlightId = FlightId, FlightClass = FlightClass,TripType=TripType});
                }
                if(TripType == "0"){
                // return RedirectToPage("/TicketSummary", new { FlightId = FlightId, FlightClass = FlightClass});
                return new RedirectToPageResult("/SearchResultTripTwo", new { DepartureDate = ArriveTime, ArriveTime = DepartureDate, OriginLocation =  ArriveLocation, ArriveLocation = OriginLocation, TripType=TripType,FlightId = FlightId, FlightClass = FlightClass});
                }

            }else{
                return RedirectToPage("UserAccessDenied");
            }

        }
        return Page();
        }


    }
}
