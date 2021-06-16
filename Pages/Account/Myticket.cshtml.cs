using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using EagleFlight.Models;
using EagleFlight.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EagleFlight.Pages
{
    public class MyticketModel : PageModel
    {
        [BindProperty,Display(Name = "List of Your Tickets")]
        public IList<Ticket> Tickets { get; set; }
        private readonly UserManager<EagleFlightUser> userManager;
        //private readonly SignInManager<IdentityUser> signInManager;
        private readonly ILogger<BoardingModel> logger;
        private readonly EagleFlightDbContext dbContext;


        public MyticketModel(EagleFlightDbContext DbContext, UserManager<EagleFlightUser> userManager,
                            ILogger<BoardingModel> logger)
        {
            dbContext = DbContext;
            this.userManager = userManager;
            this.logger = logger;
        }


        public async Task<IActionResult> OnGetAsync()
        {
            var userName = User.Identity.Name; // userName is email
            var user = await userManager.FindByNameAsync(userName);

            Tickets = dbContext.Tickets.Where(a => a.PassengerId == user.Id && a.Seat !=null).Include(c => c.BookedFlight).ToList();
            
            return Page();
        }

    }
}
