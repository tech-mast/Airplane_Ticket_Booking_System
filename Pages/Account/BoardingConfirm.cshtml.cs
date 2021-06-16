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
using Microsoft.EntityFrameworkCore;

namespace EagleFlight.Pages
{
    [Authorize]
    public class BoardingConfirmModel : PageModel
    {

        private readonly ILogger<BoardingConfirmModel> logger;
        private readonly EagleFlightDbContext dbContext;

        // [BindProperty(SupportsGet = true)]
        [BindProperty(SupportsGet =true)]
        public Ticket Ticket { get; set; }
        private static string seat;
        private static int tid;

        public BoardingConfirmModel(EagleFlightDbContext DbContext,ILogger<BoardingConfirmModel> logger)
        {
            dbContext = DbContext;
            this.logger = logger;
        }


        public void OnGet( int id )
        {
            tid=id;
            Random rand = new Random();
            Ticket =  dbContext.Tickets.Where(r => r.Id == id).FirstOrDefault();
            Ticket.Seat = "EGF-" + (rand.Next(10,99).ToString())+((char)rand.Next(65,72))+" "+(rand.Next(10,99).ToString())+((char)rand.Next(65,72)) ;
            seat = Ticket.Seat;
        }


        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Ticket ticketFromDb = dbContext.Tickets.Where(t => t.Id == tid).First<Ticket>();
            // ticketFromDb.Seat = this.Ticket.Seat;
            ticketFromDb.Seat = Ticket.Seat;
            logger.LogInformation($"Ticket Seat: {Ticket.Seat}");
            dbContext.Tickets.Update(ticketFromDb);
            var result = await dbContext.SaveChangesAsync();
            if (result >0){
                return RedirectToPage("./BoardingSuccess");
            }else{
                return Page();
            }
            
        }
    }
}
