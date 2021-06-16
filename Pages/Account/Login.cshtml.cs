using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using EagleFlight.Models;

using Microsoft.AspNetCore.Authentication;

namespace EagleFlight.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<EagleFlightUser> signInManager;
        private readonly ILogger<RegisterModel> logger;

        public LoginModel(SignInManager<EagleFlightUser> signInManager, ILogger<RegisterModel> logger) {
            this.signInManager = signInManager;
            this.logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [EmailAddress]
            public string Email { get; set; }

            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
        //[BindProperty(SupportsGet=true)]
        //public IList<AuthenticationScheme> ExternalLogins {get; set;}
        public async Task<IActionResult> OnPostAsync() 
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, true);
                if (result.Succeeded) {
                    logger.LogInformation($"User {Input.Email} logged in");
                    return RedirectToPage("LoginSuccess");
                } else { // user does not exist, password invalid, account locked out
                    ModelState.AddModelError(string.Empty, "Login failed (user does not exist, password invalid, or account locked out)");
                }
            }
            return Page();
        }

        // public async Task<IActionResult> OnGetAsync()
        // {
        //     //ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        //     return Page();
        // }

        public void OnGet(){
            
        }
    }
}
