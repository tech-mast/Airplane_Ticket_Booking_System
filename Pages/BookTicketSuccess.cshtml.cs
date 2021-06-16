using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EagleFlight.Models;
using EagleFlight.Data;
using Microsoft.Extensions.Logging;

namespace EagleFlight.Pages
{
    public class BookTicketSuccessModel : PageModel
    {
        private readonly EagleFlightDbContext db; 
        private readonly ILogger<TicketSummaryModel> logger;

        public BookTicketSuccessModel(EagleFlightDbContext db, ILogger<TicketSummaryModel> logger)
        {
            this.db = db;
            this.logger = logger;  
        }

        public Ticket xtt = TicketSummaryModel.newTicket;
        public Ticket xtt2 = TicketSummaryModel.newTicketTwo;

        public void OnGet()
        {

            db.Tickets.Add(xtt);
            db.SaveChangesAsync();
            db.Tickets.Add(xtt2);
            db.SaveChangesAsync();

        }
    }
}
