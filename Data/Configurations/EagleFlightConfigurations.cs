using EagleFlight.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EagleFlight.Data
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            //fluent api can be used here to specify requirements on entities, like length, range, ...
        }
    }
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            //fluent api can be used here to specify requirements on entities, like length, range, ...
        }
    }

}