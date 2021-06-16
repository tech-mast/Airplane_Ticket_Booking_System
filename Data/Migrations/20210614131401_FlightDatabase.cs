using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EagleFlight.Data.Migrations
{
    public partial class FlightDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Balance = table.Column<double>(type: "REAL", nullable: true),
                    ImageFile = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IDName = table.Column<string>(type: "TEXT", nullable: true),
                    IDNum = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ImageFile = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    MaxPassenger = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FlightPlaneId = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ArriveTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Origin = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Destination = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    FlightType = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketPrice = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_Planes_FlightPlaneId",
                        column: x => x.FlightPlaneId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookedFlightId = table.Column<int>(type: "INTEGER", nullable: false),
                    PassengerId = table.Column<string>(type: "TEXT", nullable: false),
                    TicketClass = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Seat = table.Column<string>(type: "TEXT", nullable: true),
                    IsCancelled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Flights_BookedFlightId",
                        column: x => x.BookedFlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2301D882-221A-1E56-B509-0113DCC063E1", "009ce1a2-b3af-47e6-ac63-6403c27069fc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01B168FE-810B-8E9F-9010-233BA0B380E9", "1b949a22-9304-4ec7-bec1-71a9b1ee8b3e", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "IDName", "IDNum", "ImageFile", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "B22698B8-62A2-8915-9631-1C2D1E2AC5F7", 0, 0.0, "79e80ea4-9952-4177-a5f4-46b8867a8d47", "EagleFlightUser", "master@admin.com", true, null, null, "/img/avatar.png", false, null, "MASTER@ADMIN.COM", "MASTER@ADMIN.COM", "AQAAAAEAACcQAAAAEOQiJu4gMsEWxeIRbbUV7C4G+eE6loi8nGvHXIi8ljB2qtFbqdMUb42mChDPdHpFMg==", null, false, "ea4de89c-d23a-4425-9c23-74c8209f9a20", false, "master@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "IDName", "IDNum", "ImageFile", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "A265D8578-62A2-8915-9631-5C2D1E2A5F1A", 0, 200.0, "f38b13b3-774e-4490-857b-eb48958c8156", "EagleFlightUser", "kate@lee.ca", true, "Kate Lee", "POH876590123A", "/uploads/kate.jpg", false, null, "KATE@LEE.CA", "KATE@LEE.CA", "AQAAAAEAACcQAAAAEM80KOeg5f5J7kGwvs0RPomb/0RiUTcnxyhcc1JAqk9fS4es9+gEjdwpLJO7OBrBXQ==", "4386952657", false, "777df6bd-bd1d-41a6-846d-69df700dd280", false, "kate@lee.ca" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "IDName", "IDNum", "ImageFile", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B", 0, 50.0, "3f280a8a-f96c-459a-902f-7e83072458e7", "EagleFlightUser", "mike@lee.ca", true, "Mike Lee", "OU879653802K", "/img/avatar.png", false, null, "MIKE@LEE.CA", "MIKE@LEE.CA", "AQAAAAEAACcQAAAAEC6mjLAMrz020R+lUayUGksSKGv6pz5M+ZhIzFc9Mb93IXLVC/aFhi+TGwlXmw34LQ==", "5147258965", false, "2f3fa245-023a-4a0c-97ed-d6a1612cf96e", false, "mike@lee.ca" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "IDName", "IDNum", "ImageFile", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "Y265D8578-62A2-8915-9631-5C2D1E2A5F1C", 0, 0.0, "0252d5f3-3c1c-4368-9f52-c686f4e2f789", "EagleFlightUser", "philip@ng.ca", true, "Philip Ng", "KT5268523025H", "/img/avatar.png", false, null, "PHILIP@NG.CA", "PHILIP@NG.CA", "AQAAAAEAACcQAAAAEAfYdlBooh04C1PrjxIkK57+syfvXFU68jwmgCgaZx5M9I+01s0/9C24UXg4YmYP8Q==", "5145625369", false, "da02e940-ad95-426c-bd2f-4bb023a47fba", false, "philip@ng.ca" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "IDName", "IDNum", "ImageFile", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "X265D8578-62A2-8915-9631-5C2D1E2A5F1D", 0, 0.0, "344d4966-f9f7-4be3-a6f1-6cb7bea4e81d", "EagleFlightUser", "cathy@lee.ca", true, null, null, "/img/avatar.png", false, null, "CATHY@LEE.CA", "CATHY@LEE.CA", "AQAAAAEAACcQAAAAENLC8LRtU8IbhXKcRrxSg1cGyL1p4OGQVHcQcqa4BBQmjdh8YYWErpHetw8/8A8Tgw==", null, false, "07b8154c-151f-4247-962a-f96b75340937", false, "cathy@lee.ca" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "IDName", "IDNum", "ImageFile", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "W265D8578-62A2-8915-9631-5C2D1E2A5F1E", 0, 0.0, "2051e34f-04c2-492c-91c1-05737d122242", "EagleFlightUser", "gerry@lee.ca", true, null, null, "/img/avatar.png", false, null, "GERRY@LEE.CA", "GERRY@LEE.CA", "AQAAAAEAACcQAAAAEBnZQ7GCgu49uYB1lztTkYMfNxgn421cOkQG5BDR1GVZFBJWBYS/smmLTY8Afim+FQ==", null, false, "19f2e78b-5270-4feb-83e0-9b263a017cf6", false, "gerry@lee.ca" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "IDName", "IDNum", "ImageFile", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "V265D8578-62A2-8915-9631-5C2D1E2A5F1F", 0, 0.0, "ef4dae09-d2a0-4282-ad50-bd1494128805", "EagleFlightUser", "victoria@lee.ca", true, null, null, "/img/avatar.png", false, null, "VICTORIA@LEE.CA", "VICTORIA@LEE.CA", "AQAAAAEAACcQAAAAEAUA6KMhTSTWP/dowMDMj07iscVCC6aSjPYK87xOrWyBMbWGnHUWkYSIIU83bHtvVw==", null, false, "85210b0b-e89a-4459-9a6f-9973daf053c5", false, "victoria@lee.ca" });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Description", "ImageFile", "MaxPassenger" },
                values: new object[] { 11, "AC747, Enjoy exclusive services and amenities on board, as well as a seamless airport experience with dedicated counters and boarding lanes, lounge access, expedited security clearance and immigration, priority baggage handling and more.", "/img/AC747.jpg", 220 });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Description", "ImageFile", "MaxPassenger" },
                values: new object[] { 12, "BC550, Signature Class is not offered on flights between Toronto and Montréal or Ottawa, or between Montréal and Halifax.", "/img/BC550.jpg", 330 });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Description", "ImageFile", "MaxPassenger" },
                values: new object[] { 13, "TC370, Premium Economy delivers superior comfort in a dedicated cabin, with ample room to stretch out and get comfortable. Indulge in premium cuisine, and enjoy access to priority airport services for an optimal travel experience.", "/img/TC370.jpg", 158 });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Description", "ImageFile", "MaxPassenger" },
                values: new object[] { 14, "JC680, Optimize your airport experience with access to dedicated check-in counters, priority baggage handling and exclusive boarding lanes.", "/img/JC680.jpg", 210 });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Description", "ImageFile", "MaxPassenger" },
                values: new object[] { 15, "HT909, offers you a wide variety of tasty meals and snacks for purchase, all carefully selected for quality and freshness. Enjoy hearty and nutritious breakfast options, delicious hot and cold meals on flights departing before 10 pm, and fresh Lavazza coffee, tea and juice, always on the house!.", "/img/HT909.jpg", 275 });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Description", "ImageFile", "MaxPassenger" },
                values: new object[] { 16, "WV308, With hundreds of hours of top-rated entertainment on your own personal touch-screen entertainment system*, you may wish your flight were longer. Enjoy all the best films, music, TV programming and audio books at your fingertips – gate-to-gate.", "/img/WV308.jpg", 330 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "01B168FE-810B-8E9F-9010-233BA0B380E9", "V265D8578-62A2-8915-9631-5C2D1E2A5F1F" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "01B168FE-810B-8E9F-9010-233BA0B380E9", "X265D8578-62A2-8915-9631-5C2D1E2A5F1D" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "01B168FE-810B-8E9F-9010-233BA0B380E9", "Y265D8578-62A2-8915-9631-5C2D1E2A5F1C" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "01B168FE-810B-8E9F-9010-233BA0B380E9", "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "01B168FE-810B-8E9F-9010-233BA0B380E9", "A265D8578-62A2-8915-9631-5C2D1E2A5F1A" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2301D882-221A-1E56-B509-0113DCC063E1", "B22698B8-62A2-8915-9631-1C2D1E2AC5F7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "01B168FE-810B-8E9F-9010-233BA0B380E9", "W265D8578-62A2-8915-9631-5C2D1E2A5F1E" });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 15, new DateTime(2021, 8, 9, 20, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 9, 10, 4, 12, 0, DateTimeKind.Unspecified), "YZY", 16, 1, "YUL", 785.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 10, new DateTime(2021, 8, 11, 22, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 11, 19, 4, 12, 0, DateTimeKind.Unspecified), "YUL", 16, 1, "YZY", 1274.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 6, new DateTime(2021, 8, 9, 19, 40, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 9, 16, 54, 12, 0, DateTimeKind.Unspecified), "SUU", 16, 1, "TTY", 660.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 11, new DateTime(2021, 8, 11, 19, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 11, 16, 4, 12, 0, DateTimeKind.Unspecified), "YZY", 15, 1, "YUL", 1011.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 9, new DateTime(2021, 8, 11, 13, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 11, 9, 26, 12, 0, DateTimeKind.Unspecified), "SUU", 15, 1, "TTY", 752.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 12, new DateTime(2021, 8, 11, 22, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 10, 21, 4, 12, 0, DateTimeKind.Unspecified), "YZY", 14, 1, "YUL", 899.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 8, new DateTime(2021, 8, 11, 12, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 11, 0, 4, 12, 0, DateTimeKind.Unspecified), "SUU", 14, 1, "TTY", 1137.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 4, new DateTime(2021, 8, 8, 22, 24, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 8, 18, 54, 12, 0, DateTimeKind.Unspecified), "YUL", 14, 0, "YZY", 770.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 13, new DateTime(2021, 8, 10, 10, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 10, 9, 4, 12, 0, DateTimeKind.Unspecified), "YZY", 13, 1, "YUL", 666.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 7, new DateTime(2021, 8, 9, 12, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 9, 9, 54, 12, 0, DateTimeKind.Unspecified), "SUU", 13, 1, "TTY", 851.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 3, new DateTime(2021, 8, 8, 9, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 8, 5, 54, 12, 0, DateTimeKind.Unspecified), "YUL", 13, 0, "YZY", 1024.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 14, new DateTime(2021, 8, 11, 22, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 11, 15, 4, 12, 0, DateTimeKind.Unspecified), "YZY", 12, 1, "YUL", 1054.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 2, new DateTime(2021, 8, 10, 17, 0, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 10, 15, 54, 12, 0, DateTimeKind.Unspecified), "VWY", 12, 1, "BBT", 770.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 5, new DateTime(2021, 8, 10, 12, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 9, 5, 54, 12, 0, DateTimeKind.Unspecified), "YUL", 15, 0, "YZY", 880.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArriveTime", "DepartureTime", "Destination", "FlightPlaneId", "FlightType", "Origin", "TicketPrice" },
                values: new object[] { 1, new DateTime(2021, 8, 10, 12, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 10, 9, 54, 12, 0, DateTimeKind.Unspecified), "VWY", 11, 1, "BBT", 550.0 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookedFlightId", "IsCancelled", "PassengerId", "Price", "Seat", "TicketClass" },
                values: new object[] { 21081001, 1, false, "A265D8578-62A2-8915-9631-5C2D1E2A5F1A", 550.0, null, 3 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookedFlightId", "IsCancelled", "PassengerId", "Price", "Seat", "TicketClass" },
                values: new object[] { 21081007, 1, false, "Y265D8578-62A2-8915-9631-5C2D1E2A5F1C", 550.0, null, 3 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookedFlightId", "IsCancelled", "PassengerId", "Price", "Seat", "TicketClass" },
                values: new object[] { 21081004, 2, false, "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B", 330.0, null, 3 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookedFlightId", "IsCancelled", "PassengerId", "Price", "Seat", "TicketClass" },
                values: new object[] { 21081002, 3, false, "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B", 440.0, null, 1 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookedFlightId", "IsCancelled", "PassengerId", "Price", "Seat", "TicketClass" },
                values: new object[] { 21081005, 4, false, "A265D8578-62A2-8915-9631-5C2D1E2A5F1A", 550.0, null, 3 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookedFlightId", "IsCancelled", "PassengerId", "Price", "Seat", "TicketClass" },
                values: new object[] { 21081003, 5, false, "A265D8578-62A2-8915-9631-5C2D1E2A5F1A", 880.0, null, 1 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BookedFlightId", "IsCancelled", "PassengerId", "Price", "Seat", "TicketClass" },
                values: new object[] { 21081006, 5, false, "Z265D8578-62A2-8915-9631-5C2D1E2A5F1B", 1760.0, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_FlightPlaneId",
                table: "Flights",
                column: "FlightPlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BookedFlightId",
                table: "Tickets",
                column: "BookedFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PassengerId",
                table: "Tickets",
                column: "PassengerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
