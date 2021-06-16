using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EagleFlight.Models
{
    public class Flight
    {
        public enum Type
        {
            Domestic,
            International,
            Private
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public int FlightPlaneId {get; set;}
        public Plane FlightPlane {get; set;}
        [Required]
        public DateTime DepartureTime {get; set;}
        [Required]
        public DateTime ArriveTime {get; set;}
        [Required, MinLength(3), MaxLength(5)]
        public string Origin { get; set; }
        [Required, MinLength(3), MaxLength(5)]
        public string Destination { get; set; }
        [Required]
        public Type FlightType { get; set; }
        [Required]
        public double TicketPrice {get; set;} 
        // a base price for ticket balance calculation by classes
        // e class = 4/5 e+ = 1/2 biz = 1/4 fist 
        public List<Ticket> Tickets {get; set;}
    }
}