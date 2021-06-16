using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EagleFlight.Models;
using EagleFlight.Data;

namespace EagleFlight.Pages
{
    public class PaymentModel : PageModel
    {
        public Ticket xtt = TicketSummaryModel.newTicket;
        public Ticket xtt2 = TicketSummaryModel.newTicketTwo;
 
        public void OnGet()
        {
        }
    }
}
