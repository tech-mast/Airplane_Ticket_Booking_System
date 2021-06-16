using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EagleFlight.Models
{
    public class Plane
    {
        [Required]
        public int Id { get; set; }
        [Required, MinLength(1), MaxLength(50)]
        public string Description { get; set; }
        [Required, MinLength(5), MaxLength(500)]
        public string ImageFile { get; set; }
        [Required, Range(1,900)]
        public int MaxPassenger { get; set; }

        public List<Flight> Flights {get; set;}
    }
}