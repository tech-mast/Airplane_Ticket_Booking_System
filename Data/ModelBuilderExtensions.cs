using EagleFlight.Models;
using EagleFlight.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;

namespace EagleFlight.Data
{
    public static class ModelBuilderExtensions
    {
        private const string adminRoleId = "2301D882-221A-1E56-B509-0113DCC063E1";
        private const string clientRoleId = "01B168FE-810B-8E9F-9010-233BA0B380E9";
        private const string adminUserId = "B22698B8-62A2-8915-9631-1C2D1E2AC5F7";
        private const string clientUserId = "A265D8578-62A2-8915-9631-5C2D1E2A5F1A";
        private const string clientUserId2 = "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B";
        private const string clientUserId3 = "Y265D8578-62A2-8915-9631-5C2D1E2A5F1C";
        private const string clientUserId4 = "X265D8578-62A2-8915-9631-5C2D1E2A5F1D";
        private const string clientUserId5 = "W265D8578-62A2-8915-9631-5C2D1E2A5F1E";
        private const string clientUserId6 = "V265D8578-62A2-8915-9631-5C2D1E2A5F1F";

        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = clientRoleId,
                    Name = "Client",
                    NormalizedName = "CLIENT"
                }
            );
            //admin user
            var admin = new EagleFlightUser
            {
                Id = adminUserId,
                UserName = "master@admin.com",
                NormalizedUserName = "MASTER@ADMIN.COM",
                Email = "master@admin.com",
                NormalizedEmail = "MASTER@ADMIN.COM",
                EmailConfirmed = true,   
                ImageFile = @"/img/avatar.png",
                Balance = 0       
            };
            var passHash = new PasswordHasher<EagleFlightUser>();
            admin.PasswordHash = passHash.HashPassword(admin, "Masteradmin123!");
            modelBuilder.Entity<EagleFlightUser>().HasData(admin);

            IdentityUserRole<string> iur = new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(iur);
            //client user
            var client = new EagleFlightUser
            {
                Id = clientUserId,
                UserName = "kate@lee.ca",
                NormalizedUserName = "KATE@LEE.CA",
                Email = "kate@lee.ca",
                NormalizedEmail = "KATE@LEE.CA",
                EmailConfirmed = true,   
                ImageFile = @"/uploads/kate.jpg",
                IDName = "Kate Lee",
                IDNum = "POH876590123A",
                PhoneNumber = "4386952657",
                Balance = 200       
            };
            passHash = new PasswordHasher<EagleFlightUser>();
            client.PasswordHash = passHash.HashPassword(client, "Kate123!");
            modelBuilder.Entity<EagleFlightUser>().HasData(client);

            iur = new IdentityUserRole<string>
            {
                RoleId = clientRoleId,
                UserId = clientUserId
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(iur);

            client = new EagleFlightUser
            {
                Id = clientUserId2,
                UserName = "mike@lee.ca",
                NormalizedUserName = "MIKE@LEE.CA",
                Email = "mike@lee.ca",
                NormalizedEmail = "MIKE@LEE.CA",
                EmailConfirmed = true,   
                ImageFile = @"/img/avatar.png",
                IDName = "Mike Lee",
                IDNum = "OU879653802K",
                PhoneNumber = "5147258965",
                Balance = 50       
            };
            passHash = new PasswordHasher<EagleFlightUser>();
            client.PasswordHash = passHash.HashPassword(client, "Mike123!");
            modelBuilder.Entity<EagleFlightUser>().HasData(client);

            iur = new IdentityUserRole<string>
            {
                RoleId = clientRoleId,
                UserId = clientUserId2
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(iur);

            client = new EagleFlightUser
            {
                Id = clientUserId3,
                UserName = "philip@ng.ca",
                NormalizedUserName = "PHILIP@NG.CA",
                Email = "philip@ng.ca",
                NormalizedEmail = "PHILIP@NG.CA",
                EmailConfirmed = true,   
                ImageFile = @"/img/avatar.png",
                IDName = "Philip Ng",
                IDNum = "KT5268523025H",
                PhoneNumber = "5145625369",
                Balance = 0       
            };
            passHash = new PasswordHasher<EagleFlightUser>();
            client.PasswordHash = passHash.HashPassword(client, "Philip123!");
            modelBuilder.Entity<EagleFlightUser>().HasData(client);

            iur = new IdentityUserRole<string>
            {
                RoleId = clientRoleId,
                UserId = clientUserId3
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(iur);
            
            client = new EagleFlightUser
            {
                Id = clientUserId4,
                UserName = "cathy@lee.ca",
                NormalizedUserName = "CATHY@LEE.CA",
                Email = "cathy@lee.ca",
                NormalizedEmail = "CATHY@LEE.CA",
                EmailConfirmed = true,   
                ImageFile = @"/img/avatar.png",
                Balance = 0       
            };
            passHash = new PasswordHasher<EagleFlightUser>();
            client.PasswordHash = passHash.HashPassword(client, "Cathy123!");
            modelBuilder.Entity<EagleFlightUser>().HasData(client);

            iur = new IdentityUserRole<string>
            {
                RoleId = clientRoleId,
                UserId = clientUserId4
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(iur);
            
            client = new EagleFlightUser
            {
                Id = clientUserId5,
                UserName = "gerry@lee.ca",
                NormalizedUserName = "GERRY@LEE.CA",
                Email = "gerry@lee.ca",
                NormalizedEmail = "GERRY@LEE.CA",
                EmailConfirmed = true,   
                ImageFile = @"/img/avatar.png",
                Balance = 0       
            };
            passHash = new PasswordHasher<EagleFlightUser>();
            client.PasswordHash = passHash.HashPassword(client, "Gerry123!");
            modelBuilder.Entity<EagleFlightUser>().HasData(client);

            iur = new IdentityUserRole<string>
            {
                RoleId = clientRoleId,
                UserId = clientUserId5
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(iur);
            
            client = new EagleFlightUser
            {
                Id = clientUserId6,
                UserName = "victoria@lee.ca",
                NormalizedUserName = "VICTORIA@LEE.CA",
                Email = "victoria@lee.ca",
                NormalizedEmail = "VICTORIA@LEE.CA",
                EmailConfirmed = true,   
                ImageFile = @"/img/avatar.png",
                Balance = 0       
            };
            passHash = new PasswordHasher<EagleFlightUser>();
            client.PasswordHash = passHash.HashPassword(client, "Victoria123!");
            modelBuilder.Entity<EagleFlightUser>().HasData(client);

            iur = new IdentityUserRole<string>
            {
                RoleId = clientRoleId,
                UserId = clientUserId6
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(iur);

            // Plan seed
            modelBuilder.Entity<Plane>().HasData(
               new Plane
                {
                    Id = 11,
                    Description = "AC747, Enjoy exclusive services and amenities on board, as well as a seamless airport experience with dedicated counters and boarding lanes, lounge access, expedited security clearance and immigration, priority baggage handling and more.",
                    ImageFile = "/img/AC747.jpg",
                    MaxPassenger = 220
                },
                new Plane
                {
                    Id = 12,
                    Description = "BC550, Signature Class is not offered on flights between Toronto and Montréal or Ottawa, or between Montréal and Halifax.",
                    ImageFile = "/img/BC550.jpg",
                    MaxPassenger = 330
                },
                new Plane
                {
                    Id = 13,
                    Description = "TC370, Premium Economy delivers superior comfort in a dedicated cabin, with ample room to stretch out and get comfortable. Indulge in premium cuisine, and enjoy access to priority airport services for an optimal travel experience.",
                    ImageFile = "/img/TC370.jpg",
                    MaxPassenger = 158
                },
                new Plane
                {
                    Id = 14,
                    Description = "JC680, Optimize your airport experience with access to dedicated check-in counters, priority baggage handling and exclusive boarding lanes.",
                    ImageFile = "/img/JC680.jpg",
                    MaxPassenger = 210
                },
                new Plane
                {
                    Id = 15,
                    Description = "HT909, offers you a wide variety of tasty meals and snacks for purchase, all carefully selected for quality and freshness. Enjoy hearty and nutritious breakfast options, delicious hot and cold meals on flights departing before 10 pm, and fresh Lavazza coffee, tea and juice, always on the house!.",
                    ImageFile = "/img/HT909.jpg",
                    MaxPassenger = 275
                },
                new Plane
                {
                    Id = 16,
                    Description = "WV308, With hundreds of hours of top-rated entertainment on your own personal touch-screen entertainment system*, you may wish your flight were longer. Enjoy all the best films, music, TV programming and audio books at your fingertips – gate-to-gate.",
                    ImageFile = "/img/WV308.jpg",
                    MaxPassenger = 330
                }
               
            );

            // flight seed
            modelBuilder.Entity<Flight>().HasData( 
                new Flight
                {
                    Id = 1,
                    FlightPlaneId = 11,
                    DepartureTime = System.DateTime.Parse("2021-08-10 09:54:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-10 12:54:12"),
                    Origin = "BBT",
                    Destination = "VWY",
                    FlightType= Flight.Type.International,
                    TicketPrice = 550
                },
                new Flight
                {
                    Id = 2,
                    FlightPlaneId = 12,
                    DepartureTime = System.DateTime.Parse("2021-08-10 15:54:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-10 17:00:12"),
                    Origin = "BBT",
                    Destination = "VWY",
                    FlightType= Flight.Type.International,
                    TicketPrice = 770
                },
                new Flight
                {
                    Id = 3,
                    FlightPlaneId = 13,
                    DepartureTime = System.DateTime.Parse("2021-08-08 05:54:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-08 09:54:12"),
                    Origin = "YZY",
                    Destination = "YUL",
                    FlightType= Flight.Type.Domestic,
                    TicketPrice = 1024
                },
                new Flight
                {
                    Id = 4,
                    FlightPlaneId = 14,
                    DepartureTime = System.DateTime.Parse("2021-08-08 18:54:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-08 22:24:12"),
                    Origin = "YZY",
                    Destination = "YUL",
                    FlightType= Flight.Type.Domestic,
                    TicketPrice = 770
                },
                new Flight
                {
                    Id = 5,
                    FlightPlaneId = 15,
                    DepartureTime = System.DateTime.Parse("2021-08-09 05:54:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-10 12:54:12"),
                    Origin = "YZY",
                    Destination = "YUL",
                    FlightType= Flight.Type.Domestic,
                    TicketPrice = 880
                },
                new Flight
                {
                    Id = 6,
                    FlightPlaneId = 16,
                    DepartureTime = System.DateTime.Parse("2021-08-09 16:54:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-09 19:40:12"),
                    Origin = "TTY",
                    Destination = "SUU",
                    FlightType= Flight.Type.International,
                    TicketPrice = 660
                },
                new Flight
                {
                    Id = 7,
                    FlightPlaneId = 13,
                    DepartureTime = System.DateTime.Parse("2021-08-09 09:54:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-09 12:54:12"),
                    Origin = "TTY",
                    Destination = "SUU",
                    FlightType= Flight.Type.International,
                    TicketPrice = 851
                },
                new Flight
                {
                    Id = 8,
                    FlightPlaneId = 14,
                    DepartureTime = System.DateTime.Parse("2021-08-11 00:04:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-11 12:54:12"),
                    Origin = "TTY",
                    Destination = "SUU",
                    FlightType= Flight.Type.International,
                    TicketPrice = 1137
                },
                new Flight
                {
                    Id = 9,
                    FlightPlaneId = 15,
                    DepartureTime = System.DateTime.Parse("2021-08-11 09:26:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-11 13:54:12"),
                    Origin = "TTY",
                    Destination = "SUU",
                    FlightType= Flight.Type.International,
                    TicketPrice = 752
                },
                new Flight
                {
                    Id = 10,
                    FlightPlaneId = 16,
                    DepartureTime = System.DateTime.Parse("2021-08-11 19:04:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-11 22:54:12"),
                    Origin = "YZY",
                    Destination = "YUL",
                    FlightType= Flight.Type.International,
                    TicketPrice = 1274
                },
                new Flight
                {
                    Id = 11,
                    FlightPlaneId = 15,
                    DepartureTime = System.DateTime.Parse("2021-08-11 16:04:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-11 19:54:12"),
                    Origin = "YUL",
                    Destination = "YZY",
                    FlightType= Flight.Type.International,
                    TicketPrice = 1011
                },
                new Flight
                {
                    Id = 12,
                    FlightPlaneId = 14,
                    DepartureTime = System.DateTime.Parse("2021-08-10 21:04:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-11 22:54:12"),
                    Origin = "YUL",
                    Destination = "YZY",
                    FlightType= Flight.Type.International,
                    TicketPrice = 899
                },
                new Flight
                {
                    Id = 13,
                    FlightPlaneId = 13,
                    DepartureTime = System.DateTime.Parse("2021-08-10 09:04:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-10 10:54:12"),
                    Origin = "YUL",
                    Destination = "YZY",
                    FlightType= Flight.Type.International,
                    TicketPrice = 666
                },
                new Flight
                {
                    Id = 14,
                    FlightPlaneId = 12,
                    DepartureTime = System.DateTime.Parse("2021-08-11 15:04:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-11 22:54:12"),
                    Origin = "YUL",
                    Destination = "YZY",
                    FlightType= Flight.Type.International,
                    TicketPrice = 1054
                },
                new Flight
                {
                    Id = 15,
                    FlightPlaneId = 16,
                    DepartureTime = System.DateTime.Parse("2021-08-09 10:04:12"),
                    ArriveTime = System.DateTime.Parse("2021-08-09 20:54:12"),
                    Origin = "YUL",
                    Destination = "YZY",
                    FlightType= Flight.Type.International,
                    TicketPrice = 785
                }
            );

            // ticket seed
            modelBuilder.Entity<Ticket>().HasData( 
                // TODO: Add more tickets here below, separated by ,
                new Ticket
                {
                    Id = 21081001,
                    BookedFlightId = 1,
                    PassengerId = clientUserId,
                    TicketClass = Ticket.Class.Economy,
                    Price = 550,
                    IsCancelled = false
                },
                new Ticket
                {
                    Id = 21081002,
                    BookedFlightId = 3,
                    PassengerId = clientUserId2,
                    TicketClass = Ticket.Class.Business,
                    Price = 440,
                    IsCancelled = false
                },
                new Ticket
                {
                    Id = 21081003,
                    BookedFlightId = 5,
                    PassengerId = clientUserId,
                    TicketClass = Ticket.Class.Business,
                    Price = 880,
                    IsCancelled = false
                },
                new Ticket
                {
                    Id = 21081004,
                    BookedFlightId = 2,
                    PassengerId = clientUserId2,
                    TicketClass = Ticket.Class.Economy,
                    Price = 330,
                    IsCancelled = false
                },
                new Ticket
                {
                    Id = 21081005,
                    BookedFlightId = 4,
                    PassengerId = clientUserId,
                    TicketClass = Ticket.Class.Economy,
                    Price = 550,
                    IsCancelled = false
                },
                new Ticket
                {
                    Id = 21081006,
                    BookedFlightId = 5,
                    PassengerId = clientUserId2,
                    TicketClass = Ticket.Class.Business,
                    Price = 1760,
                    IsCancelled = false
                },
                new Ticket
                {
                    Id = 21081007,
                    BookedFlightId = 1,
                    PassengerId = clientUserId3,
                    TicketClass = Ticket.Class.Economy,
                    Price = 550,
                    IsCancelled = false
                }
            );
            return modelBuilder;
        }
    }
}