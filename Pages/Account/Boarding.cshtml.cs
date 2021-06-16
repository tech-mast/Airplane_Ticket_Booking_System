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
    public class BoardingModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Email { get; set; }

        [BindProperty(SupportsGet = true)]
        public InputModel Input { get; set; }
        public class InputModel
        {

            [Display(Name = "ID Name")]
            public string IDName { get; set; }

            [Display(Name = "ID Number")]
            [RegularExpression("^[A-Za-z0-9]+$", ErrorMessage = "Only alphabet and digit are allowed.")]
            public string IDNum { get; set; }

            [Display(Name = "Phone Number")]
            [RegularExpression("^[+]{0,1}[1-9]{1}[0-9]{7,}$", ErrorMessage = "Only + and digit are allowed.")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Picture")]
            public string ImageFile { get; set; }

            [Display(Name = "Tickets")]
            public IList<Ticket> Tickets { get; set; }
        }
        private readonly UserManager<EagleFlightUser> userManager;
        //private readonly SignInManager<IdentityUser> signInManager;
        private readonly ILogger<BoardingModel> logger;



        private readonly EagleFlightDbContext dbContext;


        public BoardingModel(EagleFlightDbContext DbContext, UserManager<EagleFlightUser> userManager,
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
            Email = user.Email;
            Input.IDName = user.IDName;
            Input.IDNum = user.IDNum;
            Input.PhoneNumber = user.PhoneNumber;
            Input.ImageFile = user.ImageFile;
            Input.Tickets = dbContext.Tickets.OrderBy(o => o.BookedFlight.DepartureTime).Where(a => a.PassengerId == user.Id && (a.Seat==null || a.Seat=="")).Include(c => c.BookedFlight).ToList();
            
            return Page();
        }



    }
}
