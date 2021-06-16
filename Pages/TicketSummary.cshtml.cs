using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using EagleFlight.Data;
using EagleFlight.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace EagleFlight.Pages
{
    [Authorize(Roles="Client")]
    public class TicketSummaryModel : PageModel
    {
        private readonly EagleFlightDbContext db; 
        private readonly ILogger<TicketSummaryModel> logger;
        private readonly UserManager<EagleFlightUser> userManager;

        public TicketSummaryModel(EagleFlightDbContext db, ILogger<TicketSummaryModel> logger,UserManager<EagleFlightUser> userManager)
        {
            this.userManager = userManager;
            this.db = db;
            this.logger = logger;  
        }

        [BindProperty(SupportsGet =true)]
        public int flightId { get; set; }

        [BindProperty(SupportsGet =true)]
        public String flightClass { get; set; }

        [BindProperty(SupportsGet =true)]
        public int FlightIdTwo { get; set; }

        [BindProperty(SupportsGet =true)]
        public String FlightClassTwo { get; set; }

        [BindProperty(SupportsGet =true)]
        public String TripType { get; set; }

        [BindProperty]
        public Flight TripOne { get; set; }

        [BindProperty]
        public Flight TripTwo { get; set; }
        [BindProperty]
        public double UserAccountBalance { get; set; }

        [BindProperty]
        public double GrossTicketPrice { get; set; }

        [BindProperty]
        public double TicketOnePrice { get; set; }

        [BindProperty]
        public double TicketTwoPrice { get; set; }


        public async Task OnGetAsync()
        {
            logger.LogInformation($"flightId: {flightId}");
            logger.LogInformation($"flightClass: {flightClass}");
            logger.LogInformation($"flightIdTwo: {FlightIdTwo}");
            logger.LogInformation($"flightClassTwo: {FlightClassTwo}");

            TripOne = await db.Flights.Include(Flight => Flight.FlightPlane).FirstOrDefaultAsync(x => x.Id == flightId);
if(TripType=="0"){
            TripTwo = await db.Flights.Include(Flight => Flight.FlightPlane).FirstOrDefaultAsync(x => x.Id == FlightIdTwo);
}
            var userName = User.Identity.Name; // userName is email
            var user = await userManager.FindByNameAsync(userName); 
            UserAccountBalance = user.Balance;
            // TripOne = db.Flights.Find(flightId);
            
        }
        public static Ticket newTicket = new Ticket();
        public static Ticket newTicketTwo = new Ticket();
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Ticket newTicket = new Ticket();
            var userName = User.Identity.Name; // userName is email
            var user = await userManager.FindByNameAsync(userName); 
            if(flightClass == "E"){
                newTicket= new Ticket
                    {
                        BookedFlightId = flightId,
                        PassengerId = user.Id,
                        TicketClass = Ticket.Class.Economy,
                        Price = TicketOnePrice,
                        IsCancelled = false
                    };
            } else if(flightClass == "B"){
                newTicket= new Ticket
                    {
                        BookedFlightId = flightId,
                        PassengerId = user.Id,
                        TicketClass = Ticket.Class.Business,
                        Price = TicketOnePrice,
                        IsCancelled = false
                    };
            }
        if(TripType=="0"){
            if(FlightClassTwo == "E"){
                newTicketTwo= new Ticket
                    {
                        BookedFlightId = FlightIdTwo,
                        PassengerId = user.Id,
                        TicketClass = Ticket.Class.Economy,
                        Price = TicketTwoPrice,
                        IsCancelled = false
                    };
            } else if(FlightClassTwo == "B"){
                newTicketTwo= new Ticket
                    {
                        BookedFlightId = FlightIdTwo,
                        PassengerId = user.Id,
                        TicketClass = Ticket.Class.Business,
                        Price = TicketTwoPrice,
                        IsCancelled = false
                    };
            }
        }
            // db.Tickets.Add(newTicket);
            // await db.SaveChangesAsync();
            // return Page();
            return RedirectToPage("Payment");
        }        




    }
}
