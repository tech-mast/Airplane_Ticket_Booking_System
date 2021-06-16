using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using EagleFlight.Models;
using EagleFlight.Data;
using EagleFlight.Services;
namespace EagleFlight.Pages
{
    public class BoardingJSONModel : PageModel
    {
        private readonly ITicketService _ticketService;
        private readonly ILogger<BoardingJSONModel> _logger;

        public BoardingJSONModel(ILogger<BoardingJSONModel> logger, ITicketService ticketService)
        {
            _logger = logger;
            _ticketService = ticketService;
        }
        public JsonResult OnGet(int tid)
        {
            _logger.LogInformation($"JSON with ticket ID: {tid}");
            return new JsonResult(_ticketService.Boarding(tid));
        }
    }
}
