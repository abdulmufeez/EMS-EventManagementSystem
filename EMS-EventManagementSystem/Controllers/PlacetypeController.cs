using EMS_EventManagementSystem.Data;
using EMS_EventManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_EventManagementSystem.Controllers
{
    public class PlacetypeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PlacetypeController(ApplicationDbContext context)
        {
            this._context = context;
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

        public IActionResult CreatePlacetype()
        {
            return View("PlaceTypeForm", new Placetype());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Placetype placeType)
        {
            if (!ModelState.IsValid) { return View("PlaceTypeForm", new Placetype()); }
            else
            {
                placeType.CreatedAt = DateTime.Now;
                _context.Add(placeType);
                
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
