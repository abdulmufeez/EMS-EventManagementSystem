using EMS_EventManagementSystem.Data;
using EMS_EventManagementSystem.Models;
using EMS_EventManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_EventManagementSystem.Controllers
{
    public class PlaceController : Controller
    {
        private readonly ApplicationDbContext context;

        public PlaceController(ApplicationDbContext context)
        {
            this.context = context;
        }
        protected override void Dispose(bool disposing)
        {
            this.context.Dispose();
            base.Dispose(disposing);
        }

        public async Task<IActionResult> Index(int id)
        {
            var placeInDb = new PlaceCardListViewModel()
            {
                Places = await context.Places
                .Where(m => m.PlacetypeId == id)
                .ToListAsync(),

                Placetype = await context.Placetypes.SingleOrDefaultAsync(m => m.Id == id)
            };            
            return View("PlaceCardList", placeInDb);
        }

        public async Task<IActionResult> CreatePlace()
        {
            var placeform = new PlaceFormViewModel() 
            {
                Place = new Place(),
                Placetype = await context.Placetypes.ToListAsync()                
            };
            return View("PlaceForm", placeform);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Place place)
        {
            if (!ModelState.IsValid)
            {
                var placeform = new PlaceFormViewModel()
                {
                    Place = new Place(),
                    Placetype = await context.Placetypes.ToListAsync()
                    
                };
                return View("PlaceForm", placeform);
            }
            else
            {
                place.CreatedAt = DateTime.Now.Date;
                await context.AddAsync(place);
            }
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
