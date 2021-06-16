using EagleFlight.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EagleFlight.Data
{
    public class EagleFlightDbContext : IdentityDbContext
    {
        public EagleFlightDbContext(DbContextOptions<EagleFlightDbContext> options) : base(options) { }
        public DbSet<Flight> Flights { get; set; } // Map to table in database
        public DbSet<Ticket> Tickets { get; set; } // Map to table in database
        public DbSet<Plane> Planes { get; set; } // Map to table in database
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=EagleFlight.sqlite");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  // added for IdentityUser
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.Entity<Plane>(
                entity =>
                {
                    entity.HasMany(p => p.Flights)
                        .WithOne(f => f.FlightPlane)
                        .HasForeignKey("FlightPlaneId");
                });
                
            modelBuilder.Entity<Ticket>(
                entity =>
                {
                    entity.HasOne(t => t.BookedFlight)
                        .WithMany(f => f.Tickets)
                        .HasForeignKey("BookedFlightId");
                });

            modelBuilder.Entity<Ticket>(
                entity =>
                {
                    entity.HasOne(t => t.Passenger)
                        .WithMany(p => p.Tickets)
                        .HasForeignKey("PassengerId");
                });
            modelBuilder.Seed();
        }
    }
}