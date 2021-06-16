using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EagleFlight.Data;
using EagleFlight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EagleFlight.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly EagleFlightDbContext _dbContext;



        public bool isOnSearch { get; set; }
        public bool foundMatch { get; set; }

        public IndexModel(EagleFlightDbContext DbContext, ILogger<IndexModel> Logger)
        {
            _dbContext = DbContext;
            _logger = Logger;
            oList = _dbContext.Flights.Select(r => r.Origin).Distinct().ToList();
            oList.Sort();
            dList = _dbContext.Flights.Select(r => r.Destination).Distinct().ToList();
            dList.Sort();
            this.DepartureDate = DateTime.Today;
            this.departureDateOneWay = DateTime.Today;
            this.UpComingFlighList = _dbContext.Flights.OrderBy(o => o.DepartureTime).Where(r => DateTime.Compare(r.DepartureTime, DateTime.Now) >= 0 && DateTime.Compare(r.DepartureTime, DateTime.Now) < 10).ToList();
        }

        public List<string> oList { get; set; }
        public List<string> dList { get; set; }


        [BindProperty] 
        public String TripType { get; set; }
        [BindProperty, Required]
        public String Origin { get; set; }

        [BindProperty, Required]
        public String Destination { get; set; }

        [BindProperty, Required, Display(Name = "DepartureDate")]
        public DateTime DepartureDate { get; set; }

        [BindProperty, Required, Display(Name = "ReturnDate")]
        public DateTime ReturnDate { get; set; }

        [BindProperty]
        public DateTime departureDateOneWay { get; set; }

        [BindProperty]
        public int SelectFlightId { get; set; }
        public List<Flight> UpComingFlighList;

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            if (DateTime.Compare(ReturnDate, DepartureDate) < 0)
            {
                ModelState.AddModelError(string.Empty, "Return date must same as or later than departure data");
            }



            if (!ModelState.IsValid)
            {
                return Page(); // PageResult();
            }
            // otherwise do some processing

            if(TripType== "1"){
            return new RedirectToPageResult("/SearchResult", new { DepartureDate = departureDateOneWay, ArriveTime = ReturnDate, OriginLocation = Origin, ArriveLocation = Destination , TripType=TripType});               
            }
            

         
            return new RedirectToPageResult("/SearchResult", new { DepartureDate = DepartureDate, ArriveTime = ReturnDate, OriginLocation = Origin, ArriveLocation = Destination , TripType=TripType});


        }

	  public IActionResult OnPostDirectBook(int sessioncount)
        {

            if (DateTime.Compare(ReturnDate, DepartureDate) < 0)
            {
                ModelState.AddModelError(string.Empty, "Return date must same as or later than departure data");
            }
         
            return new RedirectToPageResult("/SearchResult", new { DepartureDate = DepartureDate, ArriveTime = ReturnDate, OriginLocation = Origin, ArriveLocation = Destination , TripType=TripType});

        }


    }
}
