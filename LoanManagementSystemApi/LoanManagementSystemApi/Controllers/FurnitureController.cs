using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoanManagementSystemApi.Data;
using LoanManagementSystemApi.Models;

namespace LoanManagementSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FurnitureController : ControllerBase
    {
        private readonly LoanManagementSystemContext _context;

        public FurnitureController(LoanManagementSystemContext context)
        {
            _context = context;
        }

        // GET: api/Furniture
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Furniture>>> GetFurnitures()
        {
            return await _context.Furnitures.ToListAsync();
        }

      
      
      
        // POST: api/Furniture
        
        [HttpPost]
        public async Task<ActionResult<Furniture>> PostFurniture(Furniture furniture)
        {
            _context.Furnitures.Add(furniture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFurniture", new { id = furniture.Id }, furniture);
        }

      
    }
}
