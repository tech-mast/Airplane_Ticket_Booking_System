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

namespace EagleFlight.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        [BindProperty(SupportsGet=true)]
        public string Email{get; set;}
        [BindProperty(SupportsGet=true)]
        public string imageFilePath {get; set;}
        [BindProperty(SupportsGet=true)]
        public InputModel Input { get; set; }
        public class InputModel
        {

            [Display(Name = "ID Name")]
            public string IDName { get; set; }
            
            [Display(Name = "ID Number")]
            [RegularExpression("^[A-Za-z0-9]+$",ErrorMessage="Only alphabet and digit are allowed.")]
            public string IDNum { get; set; }
            
            [Display(Name = "Phone Number")]
            [RegularExpression("^[+]{0,1}[1-9]{1}[0-9]{7,}$",ErrorMessage="Only + and digit are allowed.")]
            public string PhoneNumber { get; set; }
            
            [Display(Name = "Picture")]
            public IFormFile ImageFile { get; set; }
        } 
        private readonly UserManager<EagleFlightUser> userManager;
        //private readonly SignInManager<IdentityUser> signInManager;
        private readonly ILogger<RegisterModel> logger;
        private readonly IWebHostEnvironment _env;

        public async Task<IActionResult> OnGetAsync()
        {
            var userName = User.Identity.Name; // userName is email
            var user = await userManager.FindByNameAsync(userName); 
            Email = user.Email;
            Input.IDName = user.IDName;
            Input.IDNum = user.IDNum;
            Input.PhoneNumber = user.PhoneNumber;
            imageFilePath = user.ImageFile;
            return Page();
        }

        public ProfileModel(UserManager<EagleFlightUser> userManager, 
                            ILogger<RegisterModel> logger, IWebHostEnvironment env) {
            this.userManager = userManager;
            this.logger = logger;
            _env = env;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var userName = User.Identity.Name; // userName is email
                var user = await userManager.FindByNameAsync(userName); 
                if(Input.IDName!=null && Input.IDNum!=null){
                    user.IDName = Input.IDName;
                    user.IDNum = Input.IDNum;
                }
                if(Input.PhoneNumber!=null){
                    user.PhoneNumber = Input.PhoneNumber;
                }
                if(Input.ImageFile!=null && Input.ImageFile.FileName!=null){
                    string fileExtension = Path.GetExtension(Input.ImageFile.FileName).ToLower();
                    string[] allowedExtensions = { ".jpg", ".jpeg", ".gif", ".png" };
                    if (!allowedExtensions.Contains(fileExtension)) {
                        ModelState.AddModelError(string.Empty, "Only image files (jpg, jpeg, gif, png) are allowed");
                        return Page();
                    }
                    var file = Path.Combine(_env.ContentRootPath, "wwwroot","uploads", Input.ImageFile.FileName);
                    try{
                        using (var fileStream = new FileStream(file, FileMode.Create))
                        {
                            await Input.ImageFile.CopyToAsync(fileStream);
                        }
                    }catch (Exception ex) when (ex is IOException || ex is SystemException) {
                        string msg_file_io_err = "Internal error saving the uploaded file";
                        logger.LogInformation(msg_file_io_err);
                        ModelState.AddModelError(string.Empty, msg_file_io_err);
                        return Page();
                    }
                    user.ImageFile=$"/uploads/{Input.ImageFile.FileName}";
                }
                // FIXME: Role as normal user shall be set here
                var result = await userManager.UpdateAsync(user);
                if(result.Succeeded){
                    logger.LogInformation($"User {user.Email} is updated");
                    return RedirectToPage("ProfileEditSuccess", new {email=user.Email});
                }
                foreach ( var error in result.Errors){
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }

    }
}
