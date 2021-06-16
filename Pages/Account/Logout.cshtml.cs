using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using EagleFlight.Models;

namespace EagleFlight.Pages
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<EagleFlightUser> signInManager;
        private readonly ILogger<RegisterModel> logger;

        public LogoutModel(SignInManager<EagleFlightUser> signInManager, ILogger<RegisterModel> logger) {
            this.signInManager = signInManager;
            this.logger = logger;
        }        
        public async Task<IActionResult> OnGetAsync()
        {

            if (signInManager.IsSignedIn(User)){
                logger.LogInformation($"User {User.Identity.Name} logged out");
                await signInManager.SignOutAsync();
                TempData["message"] = "You are logged out.";
            }else{
                TempData["message"] = "Something wrong in logging out.";
            }
            // add flash message of log out
            return RedirectToPage("/Index");
        }
    }
}
