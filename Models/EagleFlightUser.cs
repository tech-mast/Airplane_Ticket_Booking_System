using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace EagleFlight.Models
{
    public class EagleFlightUser : IdentityUser
    {
        [Required]
        public double Balance {get; set;}
        
        [Required, MinLength(5), MaxLength(50)]
        public string ImageFile { get; set; }
        public string IDName { get; set; }
        public string IDNum { get; set; }
        public List<Ticket> Tickets {get; set;}
    }
}