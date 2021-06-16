using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace EagleFlight.Pages
{
    public class BoardingSuccessModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string returnLink {get; set;}

        // [BindProperty(SupportsGet = true)]
        // public int Id { get; set; }
        //         [BindProperty(SupportsGet = true)]
        // public string Origin { get; set; }
        //         [BindProperty(SupportsGet = true)]
        // public string Destination { get; set; }
        //         [BindProperty(SupportsGet = true)]
        // public string DepartDate{ get; set; }
        //         [BindProperty(SupportsGet = true)]
        // public string Seat { get; set; }
        public void OnGet()
        {
            if(User.IsInRole("Admin")){
                returnLink = "/Admin/Index";
            }else{
                returnLink = "/Account/MyTicket";
            }
        }
    }
}
