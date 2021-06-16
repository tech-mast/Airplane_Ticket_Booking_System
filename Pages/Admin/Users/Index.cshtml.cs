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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using EagleFlight.Data;

namespace EagleFlight.Pages.Admin.Users
{
    [Authorize]
    public class IndexModel : PageModel
    {

        private readonly EagleFlightDbContext _dbContext;
        private readonly ILogger<BoardingConfirmModel> logger;
        private readonly UserManager<EagleFlightUser> userManager;
        [BindProperty]
        public string TargetUser { get; set; }

        //user list
        [BindProperty]
        public IList<EagleFlightUser> userList { get; set; }

       public void OnGet()
        {
            var userName = User.Identity.Name;
            userList =  userManager.Users.ToList();
        }

        public IndexModel(EagleFlightDbContext DbContext, ILogger<BoardingConfirmModel> logger, UserManager<EagleFlightUser> userManager)
        {
            _dbContext = DbContext;
            this.logger = logger;
            this.userManager = userManager;
        }

        public IActionResult OnPost()
        {


            if (!ModelState.IsValid)
            {
                return Page(); // PageResult();
            }


            return new RedirectToPageResult("/Admin/Users/AdminEditUser", new { EditUser = TargetUser });

        }

    }
}
