using EMS_EventManagementSystem.Data;
using EMS_EventManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_EventManagementSystem.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacetypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PlacetypeController(ApplicationDbContext context)
        {
            this._context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Placetype>>> GetPlacetypes()
        {
            return Ok(await _context.Placetypes.ToListAsync());
        }
    }
}
