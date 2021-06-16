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

namespace EagleFlight.Pages
{
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<EagleFlightUser> userManager;
        //private readonly SignInManager<IdentityUser> signInManager;
        private readonly ILogger<ConfirmEmailModel> logger;
        public ConfirmEmailModel(UserManager<EagleFlightUser> userManager, 
                            ILogger<ConfirmEmailModel> logger) {
            this.userManager = userManager;
            this.logger = logger;
        }
        public async Task<IActionResult> OnGetAsync(string userId, string token)
        { 
            if(userId==null || token==null){
                return RedirectToPage("/Index");
            }
            var user = await userManager.FindByIdAsync(userId);
            if(user==null){
                return NotFound();
            }
            var result = await userManager.ConfirmEmailAsync(user, token);
            if(result.Succeeded){
                return Page();
            }else{
                return NotFound();
            }
        }
    }
}
