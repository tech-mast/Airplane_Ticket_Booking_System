using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using EagleFlight.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;

namespace EagleFlight.Pages
{
    public class RegisterModel : PageModel
    {

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

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

        public void OnGet()
        {
        }

        public RegisterModel(UserManager<EagleFlightUser> userManager, 
                            ILogger<RegisterModel> logger, IWebHostEnvironment env) {
            this.userManager = userManager;
            this.logger = logger;
            _env = env;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new EagleFlightUser{ UserName=Input.Email, Email=Input.Email, Balance=0 };
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
                }else{
                    user.ImageFile=@"/img/avatar.png";
                }
                // FIXME: Role as normal user shall be set here
                var result = await userManager.CreateAsync(user, Input.Password);
                if(result.Succeeded){
                    var roleResult = await userManager.AddToRoleAsync(user, "Client");
                    if(roleResult.Succeeded){
                        logger.LogInformation($"User {Input.Email} is created");
                        // email confirmation token and link
                        var ectoken = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        var confirmationLink = Url.Action(null, null, new {userId=user.Id, token=ectoken}, Request.Scheme);
                        confirmationLink = confirmationLink.Replace("Register", "ConfirmEmail");
                        // FIXME: the linkage format is not same as expected
                        logger.LogInformation($">>email confirm: {confirmationLink} <<");
                        // sending email
                        try{
                            using (var smtpClient = new SmtpClient("smtp.gmail.com", 587)){
                                smtpClient.Credentials = new NetworkCredential("eagleflight.ipd24@gmail.com", "wwafvnmwpdlcmemx");
                                smtpClient.UseDefaultCredentials = false; // uncomment if you don't want to use the network credentials
                                smtpClient.EnableSsl = true;
                                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtpClient.EnableSsl = true;
                                //Setting From , To , Subject and Body
                                var from = new MailAddress("eagleflight.ipd24@gmail.com", "Eagle Flight", System.Text.Encoding.UTF8);
                                var to = new MailAddress(user.Email);
                                MailMessage mail = new MailMessage(from, to);
                                mail.Subject = "Welcome to Eagle Flight";
                                mail.SubjectEncoding =  System.Text.Encoding.UTF8;
                                mail.Body = String.Format("Click below link to confirm your email:\n{0}", confirmationLink);
                                mail.BodyEncoding =  System.Text.Encoding.UTF8;
                                smtpClient.Send(mail);
                            }
                        }catch(Exception e){
                            logger.LogInformation(e.Message);
                            var delResult = await userManager.DeleteAsync(user);
                            return RedirectToPage("/InternalError");
                        }
                        return RedirectToPage("/Account/RegisterSuccess", new {email=Input.Email});
                    }else{
                        var delResult = await userManager.DeleteAsync(user);
                        logger.LogInformation($"User {Input.Email} is not created due to internal error.");
                        return RedirectToPage("/InternalError");
                    }
                }
                foreach ( var error in result.Errors){
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }
    }
}
