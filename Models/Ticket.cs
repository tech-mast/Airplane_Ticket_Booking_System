using System.ComponentModel.DataAnnotations;

using System;
using Microsoft.AspNetCore.Identity;

namespace EagleFlight.Models
{
    public class Ticket
    {
        public enum Class
        {
            First,
            Business,
            EconomyPlus,
            Economy
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public int BookedFlightId {get; set;}
        public Flight BookedFlight { get; set;}
        [Required]
        public string PassengerId {get; set;}
        public EagleFlightUser Passenger {get; set;}
        [Required]
        public Class TicketClass { get; set; }
        [Required]
        public double Price {get; set;} // ticket price
        //[MinLength(2), MaxLength(100)]
        //public string PaymentNum {get; set;}
        public string Seat{get; set;} // for boarding. ticket cannot be cancelled after boarding
        [Required]
        public bool IsCancelled {get; set;} // default: false, calcelled: true. user balance shall be adapted
    }
}