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

namespace EagleFlight.Pages.Admin
{
    [Authorize(Roles = "Admin")]

    public class IndexModel : PageModel
    {
        private readonly EagleFlightDbContext _dbContext;
        private readonly ILogger<BoardingConfirmModel> logger;
         private readonly UserManager<EagleFlightUser> userManager;
        public IndexModel(EagleFlightDbContext DbContext, ILogger<BoardingConfirmModel> logger,UserManager<EagleFlightUser> userManager)
        {
            _dbContext = DbContext;
            this.logger = logger;
             this.userManager = userManager;
        }
        
        public void OnGet()
        {

           
        }



    }
}
