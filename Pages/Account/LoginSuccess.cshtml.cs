using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace EagleFlight.Pages
{
    public class LoginSuccessModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string indexLink {get; set;}
        public void OnGet()
        {
            if(User.IsInRole("Admin")){
                indexLink = "/Admin/Index";
            }else{
                indexLink = "/Index";
            }
        }
    }
}
