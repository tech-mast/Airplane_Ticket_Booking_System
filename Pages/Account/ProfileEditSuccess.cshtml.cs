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
    [Authorize]
    public class ProfileEditSuccessModel : PageModel
    {
        [BindProperty(SupportsGet=true)]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Display(Name = "Email")]
            public string Email{get; set;}

            [Display(Name = "ID Name")]
            public string IDName { get; set; }
            
            [Display(Name = "ID Number")]
            public string IDNum { get; set; }
            
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }
            
            [Display(Name = "Picture")]
            public string ImageFile { get; set; }
        } 
        private readonly UserManager<EagleFlightUser> userManager;
        private readonly ILogger<RegisterModel> logger;

        public async Task<IActionResult> OnGetAsync()
        {
            var userName = User.Identity.Name; // userName is email
            var user = await userManager.FindByNameAsync(userName); 
            Input.Email = user.Email;
            Input.IDName = user.IDName;
            Input.IDNum = user.IDNum;
            Input.PhoneNumber = user.PhoneNumber;
            Input.ImageFile = user.ImageFile;
            return Page();
        }

        public ProfileEditSuccessModel(UserManager<EagleFlightUser> userManager, 
                            ILogger<RegisterModel> logger) {
            this.userManager = userManager;
            this.logger = logger;
        }
    }
}
