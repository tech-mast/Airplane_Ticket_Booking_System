using Microsoft.Extensions.Caching.Memory;
using EagleFlight.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using EagleFlight.Data;
using System;
namespace EagleFlight.Services
{
    public interface ITicketService
    {
        public string Boarding(int ticketId);
    }
    public class TicketService : ITicketService
    {
         private readonly ILogger<TicketService> _logger;
        private readonly EagleFlightDbContext _db;

        public TicketService(EagleFlightDbContext db, ILogger<TicketService> logger)
        {
            _db = db;
            _logger = logger;
        }

        public string Boarding(int ticketId){
            Random rand = new Random();
            var ticket = _db.Tickets.Where(t=>t.Id==ticketId).FirstOrDefault();
            var seat = (rand.Next(10,99).ToString())+((char)rand.Next(65,72));
            ticket.Seat = seat;
            _db.Tickets.Update(ticket);
            var result = _db.SaveChanges();
            if (result >0){
                return seat;
            }else{
                return String.Empty;
            }
        }
    }
}