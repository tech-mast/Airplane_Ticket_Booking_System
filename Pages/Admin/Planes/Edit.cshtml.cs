using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EagleFlight.Data;
using EagleFlight.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace EagleFlight.Pages.Admin.Planes
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {
        private readonly EagleFlight.Data.EagleFlightDbContext _context;
        private readonly ILogger<IndexModel> logger;

        private IHostingEnvironment _environment;
        private readonly IWebHostEnvironment _env;
        public EditModel(EagleFlight.Data.EagleFlightDbContext context,IHostingEnvironment environment,ILogger<IndexModel> logger,IWebHostEnvironment env)
        {
            _context = context;
            _environment = environment;
            this.logger = logger;
            _env = env;
        }

        public Plane Plane;

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public int MaxPassenger { get; set; }

        [BindProperty(SupportsGet =true)]
        public int id  { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plane = await _context.Planes.FirstOrDefaultAsync(m => m.Id == id);

            if (Plane == null)
            {
                return NotFound();
            }
           
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
        Plane = await _context.Planes.FirstOrDefaultAsync(m => m.Id == id);

        string imagePath = null;
        if (Upload != null) {
          string fileExtension = Path.GetExtension(Upload.FileName).ToLower();
          string[] allowedExtensions = { ".jpg", ".jpeg", ".gif", ".png" };
          if (!allowedExtensions.Contains(fileExtension)) {
            // Display error and the form again
            ModelState.AddModelError(string.Empty, "Only image files (jpg, jpeg, gif, png) are allowed");
            return Page();
          }
          // FIXME: sanitize the original name or assign random
          var invalids = System.IO.Path.GetInvalidFileNameChars();
          var newFileName = String.Join("_", Upload.FileName.Split(invalids, StringSplitOptions.RemoveEmptyEntries) ).TrimEnd('.');
          var destPath = Path.Combine(_environment.ContentRootPath, "wwwroot", "img", Upload.FileName);
          // FIXME: handle IO errors when copying the file
          try {
            using (var fileStream = new FileStream(destPath, FileMode.Create))
            {
                Upload.CopyTo(fileStream);
            }
          } catch (Exception ex) when (ex is IOException || ex is SystemException) {
            // TODO: Log this as an error
            ModelState.AddModelError(string.Empty, "Internal error saving the uploaded file");
            return Page();
          }
        //   imagePath = Path.Combine("img", newFileName);
          imagePath =$"/img/{newFileName}";

        } else{
            // ModelState.AddModelError(string.Empty, "Your bit price must be higher than the last bit price");
            // return Page();
            imagePath= $"{Plane.ImageFile}"; 

        }

            // Plane = await _context.Planes.FirstOrDefaultAsync(m => m.Id == id);

            Plane.Description = Description;
            Plane.MaxPassenger = MaxPassenger;
            Plane.ImageFile = imagePath;
            // _context.Planes.Update(Plane);
            // _context.Attach(Plane).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightExists(Plane.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FlightExists(int id)
        {
            return _context.Planes.Any(e => e.Id == id);
        }
        

    }
}
