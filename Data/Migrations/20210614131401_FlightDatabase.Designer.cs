﻿// <auto-generated />
using System;
using EagleFlight.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EagleFlight.Data.Migrations
{
    [DbContext(typeof(EagleFlightDbContext))]
    [Migration("20210614131401_FlightDatabase")]
    partial class FlightDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("EagleFlight.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ArriveTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<int>("FlightPlaneId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FlightType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<double>("TicketPrice")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FlightPlaneId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArriveTime = new DateTime(2021, 8, 10, 12, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 10, 9, 54, 12, 0, DateTimeKind.Unspecified),
                            Destination = "VWY",
                            FlightPlaneId = 11,
                            FlightType = 1,
                            Origin = "BBT",
                            TicketPrice = 550.0
                        },
                        new
                        {
                            Id = 2,
                            ArriveTime = new DateTime(2021, 8, 10, 17, 0, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 10, 15, 54, 12, 0, DateTimeKind.Unspecified),
                            Destination = "VWY",
                            FlightPlaneId = 12,
                            FlightType = 1,
                            Origin = "BBT",
                            TicketPrice = 770.0
                        },
                        new
                        {
                            Id = 3,
                            ArriveTime = new DateTime(2021, 8, 8, 9, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 8, 5, 54, 12, 0, DateTimeKind.Unspecified),
                            Destination = "YUL",
                            FlightPlaneId = 13,
                            FlightType = 0,
                            Origin = "YZY",
                            TicketPrice = 1024.0
                        },
                        new
                        {
                            Id = 4,
                            ArriveTime = new DateTime(2021, 8, 8, 22, 24, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 8, 18, 54, 12, 0, DateTimeKind.Unspecified),
                            Destination = "YUL",
                            FlightPlaneId = 14,
                            FlightType = 0,
                            Origin = "YZY",
                            TicketPrice = 770.0
                        },
                        new
                        {
                            Id = 5,
                            ArriveTime = new DateTime(2021, 8, 10, 12, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 9, 5, 54, 12, 0, DateTimeKind.Unspecified),
                            Destination = "YUL",
                            FlightPlaneId = 15,
                            FlightType = 0,
                            Origin = "YZY",
                            TicketPrice = 880.0
                        },
                        new
                        {
                            Id = 6,
                            ArriveTime = new DateTime(2021, 8, 9, 19, 40, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 9, 16, 54, 12, 0, DateTimeKind.Unspecified),
                            Destination = "SUU",
                            FlightPlaneId = 16,
                            FlightType = 1,
                            Origin = "TTY",
                            TicketPrice = 660.0
                        },
                        new
                        {
                            Id = 7,
                            ArriveTime = new DateTime(2021, 8, 9, 12, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 9, 9, 54, 12, 0, DateTimeKind.Unspecified),
                            Destination = "SUU",
                            FlightPlaneId = 13,
                            FlightType = 1,
                            Origin = "TTY",
                            TicketPrice = 851.0
                        },
                        new
                        {
                            Id = 8,
                            ArriveTime = new DateTime(2021, 8, 11, 12, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 11, 0, 4, 12, 0, DateTimeKind.Unspecified),
                            Destination = "SUU",
                            FlightPlaneId = 14,
                            FlightType = 1,
                            Origin = "TTY",
                            TicketPrice = 1137.0
                        },
                        new
                        {
                            Id = 9,
                            ArriveTime = new DateTime(2021, 8, 11, 13, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 11, 9, 26, 12, 0, DateTimeKind.Unspecified),
                            Destination = "SUU",
                            FlightPlaneId = 15,
                            FlightType = 1,
                            Origin = "TTY",
                            TicketPrice = 752.0
                        },
                        new
                        {
                            Id = 10,
                            ArriveTime = new DateTime(2021, 8, 11, 22, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 11, 19, 4, 12, 0, DateTimeKind.Unspecified),
                            Destination = "YUL",
                            FlightPlaneId = 16,
                            FlightType = 1,
                            Origin = "YZY",
                            TicketPrice = 1274.0
                        },
                        new
                        {
                            Id = 11,
                            ArriveTime = new DateTime(2021, 8, 11, 19, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 11, 16, 4, 12, 0, DateTimeKind.Unspecified),
                            Destination = "YZY",
                            FlightPlaneId = 15,
                            FlightType = 1,
                            Origin = "YUL",
                            TicketPrice = 1011.0
                        },
                        new
                        {
                            Id = 12,
                            ArriveTime = new DateTime(2021, 8, 11, 22, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 10, 21, 4, 12, 0, DateTimeKind.Unspecified),
                            Destination = "YZY",
                            FlightPlaneId = 14,
                            FlightType = 1,
                            Origin = "YUL",
                            TicketPrice = 899.0
                        },
                        new
                        {
                            Id = 13,
                            ArriveTime = new DateTime(2021, 8, 10, 10, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 10, 9, 4, 12, 0, DateTimeKind.Unspecified),
                            Destination = "YZY",
                            FlightPlaneId = 13,
                            FlightType = 1,
                            Origin = "YUL",
                            TicketPrice = 666.0
                        },
                        new
                        {
                            Id = 14,
                            ArriveTime = new DateTime(2021, 8, 11, 22, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 11, 15, 4, 12, 0, DateTimeKind.Unspecified),
                            Destination = "YZY",
                            FlightPlaneId = 12,
                            FlightType = 1,
                            Origin = "YUL",
                            TicketPrice = 1054.0
                        },
                        new
                        {
                            Id = 15,
                            ArriveTime = new DateTime(2021, 8, 9, 20, 54, 12, 0, DateTimeKind.Unspecified),
                            DepartureTime = new DateTime(2021, 8, 9, 10, 4, 12, 0, DateTimeKind.Unspecified),
                            Destination = "YZY",
                            FlightPlaneId = 16,
                            FlightType = 1,
                            Origin = "YUL",
                            TicketPrice = 785.0
                        });
                });

            modelBuilder.Entity("EagleFlight.Models.Plane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageFile")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxPassenger")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Planes");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Description = "AC747, Enjoy exclusive services and amenities on board, as well as a seamless airport experience with dedicated counters and boarding lanes, lounge access, expedited security clearance and immigration, priority baggage handling and more.",
                            ImageFile = "/img/AC747.jpg",
                            MaxPassenger = 220
                        },
                        new
                        {
                            Id = 12,
                            Description = "BC550, Signature Class is not offered on flights between Toronto and Montréal or Ottawa, or between Montréal and Halifax.",
                            ImageFile = "/img/BC550.jpg",
                            MaxPassenger = 330
                        },
                        new
                        {
                            Id = 13,
                            Description = "TC370, Premium Economy delivers superior comfort in a dedicated cabin, with ample room to stretch out and get comfortable. Indulge in premium cuisine, and enjoy access to priority airport services for an optimal travel experience.",
                            ImageFile = "/img/TC370.jpg",
                            MaxPassenger = 158
                        },
                        new
                        {
                            Id = 14,
                            Description = "JC680, Optimize your airport experience with access to dedicated check-in counters, priority baggage handling and exclusive boarding lanes.",
                            ImageFile = "/img/JC680.jpg",
                            MaxPassenger = 210
                        },
                        new
                        {
                            Id = 15,
                            Description = "HT909, offers you a wide variety of tasty meals and snacks for purchase, all carefully selected for quality and freshness. Enjoy hearty and nutritious breakfast options, delicious hot and cold meals on flights departing before 10 pm, and fresh Lavazza coffee, tea and juice, always on the house!.",
                            ImageFile = "/img/HT909.jpg",
                            MaxPassenger = 275
                        },
                        new
                        {
                            Id = 16,
                            Description = "WV308, With hundreds of hours of top-rated entertainment on your own personal touch-screen entertainment system*, you may wish your flight were longer. Enjoy all the best films, music, TV programming and audio books at your fingertips – gate-to-gate.",
                            ImageFile = "/img/WV308.jpg",
                            MaxPassenger = 330
                        });
                });

            modelBuilder.Entity("EagleFlight.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookedFlightId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PassengerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Seat")
                        .HasColumnType("TEXT");

                    b.Property<int>("TicketClass")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookedFlightId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 21081001,
                            BookedFlightId = 1,
                            IsCancelled = false,
                            PassengerId = "A265D8578-62A2-8915-9631-5C2D1E2A5F1A",
                            Price = 550.0,
                            TicketClass = 3
                        },
                        new
                        {
                            Id = 21081002,
                            BookedFlightId = 3,
                            IsCancelled = false,
                            PassengerId = "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B",
                            Price = 440.0,
                            TicketClass = 1
                        },
                        new
                        {
                            Id = 21081003,
                            BookedFlightId = 5,
                            IsCancelled = false,
                            PassengerId = "A265D8578-62A2-8915-9631-5C2D1E2A5F1A",
                            Price = 880.0,
                            TicketClass = 1
                        },
                        new
                        {
                            Id = 21081004,
                            BookedFlightId = 2,
                            IsCancelled = false,
                            PassengerId = "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B",
                            Price = 330.0,
                            TicketClass = 3
                        },
                        new
                        {
                            Id = 21081005,
                            BookedFlightId = 4,
                            IsCancelled = false,
                            PassengerId = "A265D8578-62A2-8915-9631-5C2D1E2A5F1A",
                            Price = 550.0,
                            TicketClass = 3
                        },
                        new
                        {
                            Id = 21081006,
                            BookedFlightId = 5,
                            IsCancelled = false,
                            PassengerId = "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B",
                            Price = 1760.0,
                            TicketClass = 1
                        },
                        new
                        {
                            Id = 21081007,
                            BookedFlightId = 1,
                            IsCancelled = false,
                            PassengerId = "Y265D8578-62A2-8915-9631-5C2D1E2A5F1C",
                            Price = 550.0,
                            TicketClass = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "2301D882-221A-1E56-B509-0113DCC063E1",
                            ConcurrencyStamp = "009ce1a2-b3af-47e6-ac63-6403c27069fc",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "01B168FE-810B-8E9F-9010-233BA0B380E9",
                            ConcurrencyStamp = "1b949a22-9304-4ec7-bec1-71a9b1ee8b3e",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "B22698B8-62A2-8915-9631-1C2D1E2AC5F7",
                            RoleId = "2301D882-221A-1E56-B509-0113DCC063E1"
                        },
                        new
                        {
                            UserId = "A265D8578-62A2-8915-9631-5C2D1E2A5F1A",
                            RoleId = "01B168FE-810B-8E9F-9010-233BA0B380E9"
                        },
                        new
                        {
                            UserId = "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B",
                            RoleId = "01B168FE-810B-8E9F-9010-233BA0B380E9"
                        },
                        new
                        {
                            UserId = "Y265D8578-62A2-8915-9631-5C2D1E2A5F1C",
                            RoleId = "01B168FE-810B-8E9F-9010-233BA0B380E9"
                        },
                        new
                        {
                            UserId = "X265D8578-62A2-8915-9631-5C2D1E2A5F1D",
                            RoleId = "01B168FE-810B-8E9F-9010-233BA0B380E9"
                        },
                        new
                        {
                            UserId = "W265D8578-62A2-8915-9631-5C2D1E2A5F1E",
                            RoleId = "01B168FE-810B-8E9F-9010-233BA0B380E9"
                        },
                        new
                        {
                            UserId = "V265D8578-62A2-8915-9631-5C2D1E2A5F1F",
                            RoleId = "01B168FE-810B-8E9F-9010-233BA0B380E9"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EagleFlight.Models.EagleFlightUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("IDName")
                        .HasColumnType("TEXT");

                    b.Property<string>("IDNum")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageFile")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("EagleFlightUser");

                    b.HasData(
                        new
                        {
                            Id = "B22698B8-62A2-8915-9631-1C2D1E2AC5F7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "79e80ea4-9952-4177-a5f4-46b8867a8d47",
                            Email = "master@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MASTER@ADMIN.COM",
                            NormalizedUserName = "MASTER@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOQiJu4gMsEWxeIRbbUV7C4G+eE6loi8nGvHXIi8ljB2qtFbqdMUb42mChDPdHpFMg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ea4de89c-d23a-4425-9c23-74c8209f9a20",
                            TwoFactorEnabled = false,
                            UserName = "master@admin.com",
                            Balance = 0.0,
                            ImageFile = "/img/avatar.png"
                        },
                        new
                        {
                            Id = "A265D8578-62A2-8915-9631-5C2D1E2A5F1A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f38b13b3-774e-4490-857b-eb48958c8156",
                            Email = "kate@lee.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "KATE@LEE.CA",
                            NormalizedUserName = "KATE@LEE.CA",
                            PasswordHash = "AQAAAAEAACcQAAAAEM80KOeg5f5J7kGwvs0RPomb/0RiUTcnxyhcc1JAqk9fS4es9+gEjdwpLJO7OBrBXQ==",
                            PhoneNumber = "4386952657",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "777df6bd-bd1d-41a6-846d-69df700dd280",
                            TwoFactorEnabled = false,
                            UserName = "kate@lee.ca",
                            Balance = 200.0,
                            IDName = "Kate Lee",
                            IDNum = "POH876590123A",
                            ImageFile = "/uploads/kate.jpg"
                        },
                        new
                        {
                            Id = "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f280a8a-f96c-459a-902f-7e83072458e7",
                            Email = "mike@lee.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MIKE@LEE.CA",
                            NormalizedUserName = "MIKE@LEE.CA",
                            PasswordHash = "AQAAAAEAACcQAAAAEC6mjLAMrz020R+lUayUGksSKGv6pz5M+ZhIzFc9Mb93IXLVC/aFhi+TGwlXmw34LQ==",
                            PhoneNumber = "5147258965",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2f3fa245-023a-4a0c-97ed-d6a1612cf96e",
                            TwoFactorEnabled = false,
                            UserName = "mike@lee.ca",
                            Balance = 50.0,
                            IDName = "Mike Lee",
                            IDNum = "OU879653802K",
                            ImageFile = "/img/avatar.png"
                        },
                        new
                        {
                            Id = "Y265D8578-62A2-8915-9631-5C2D1E2A5F1C",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0252d5f3-3c1c-4368-9f52-c686f4e2f789",
                            Email = "philip@ng.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PHILIP@NG.CA",
                            NormalizedUserName = "PHILIP@NG.CA",
                            PasswordHash = "AQAAAAEAACcQAAAAEAfYdlBooh04C1PrjxIkK57+syfvXFU68jwmgCgaZx5M9I+01s0/9C24UXg4YmYP8Q==",
                            PhoneNumber = "5145625369",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "da02e940-ad95-426c-bd2f-4bb023a47fba",
                            TwoFactorEnabled = false,
                            UserName = "philip@ng.ca",
                            Balance = 0.0,
                            IDName = "Philip Ng",
                            IDNum = "KT5268523025H",
                            ImageFile = "/img/avatar.png"
                        },
                        new
                        {
                            Id = "X265D8578-62A2-8915-9631-5C2D1E2A5F1D",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "344d4966-f9f7-4be3-a6f1-6cb7bea4e81d",
                            Email = "cathy@lee.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CATHY@LEE.CA",
                            NormalizedUserName = "CATHY@LEE.CA",
                            PasswordHash = "AQAAAAEAACcQAAAAENLC8LRtU8IbhXKcRrxSg1cGyL1p4OGQVHcQcqa4BBQmjdh8YYWErpHetw8/8A8Tgw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "07b8154c-151f-4247-962a-f96b75340937",
                            TwoFactorEnabled = false,
                            UserName = "cathy@lee.ca",
                            Balance = 0.0,
                            ImageFile = "/img/avatar.png"
                        },
                        new
                        {
                            Id = "W265D8578-62A2-8915-9631-5C2D1E2A5F1E",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2051e34f-04c2-492c-91c1-05737d122242",
                            Email = "gerry@lee.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "GERRY@LEE.CA",
                            NormalizedUserName = "GERRY@LEE.CA",
                            PasswordHash = "AQAAAAEAACcQAAAAEBnZQ7GCgu49uYB1lztTkYMfNxgn421cOkQG5BDR1GVZFBJWBYS/smmLTY8Afim+FQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "19f2e78b-5270-4feb-83e0-9b263a017cf6",
                            TwoFactorEnabled = false,
                            UserName = "gerry@lee.ca",
                            Balance = 0.0,
                            ImageFile = "/img/avatar.png"
                        },
                        new
                        {
                            Id = "V265D8578-62A2-8915-9631-5C2D1E2A5F1F",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ef4dae09-d2a0-4282-ad50-bd1494128805",
                            Email = "victoria@lee.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "VICTORIA@LEE.CA",
                            NormalizedUserName = "VICTORIA@LEE.CA",
                            PasswordHash = "AQAAAAEAACcQAAAAEAUA6KMhTSTWP/dowMDMj07iscVCC6aSjPYK87xOrWyBMbWGnHUWkYSIIU83bHtvVw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "85210b0b-e89a-4459-9a6f-9973daf053c5",
                            TwoFactorEnabled = false,
                            UserName = "victoria@lee.ca",
                            Balance = 0.0,
                            ImageFile = "/img/avatar.png"
                        });
                });

            modelBuilder.Entity("EagleFlight.Models.Flight", b =>
                {
                    b.HasOne("EagleFlight.Models.Plane", "FlightPlane")
                        .WithMany("Flights")
                        .HasForeignKey("FlightPlaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlightPlane");
                });

            modelBuilder.Entity("EagleFlight.Models.Ticket", b =>
                {
                    b.HasOne("EagleFlight.Models.Flight", "BookedFlight")
                        .WithMany("Tickets")
                        .HasForeignKey("BookedFlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EagleFlight.Models.EagleFlightUser", "Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookedFlight");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EagleFlight.Models.Flight", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("EagleFlight.Models.Plane", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("EagleFlight.Models.EagleFlightUser", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
