using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;
using Proje.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.API
{
    namespace WebMalzeme.API
    {
       [Route("api/[controller]")]
        [ApiController]
        public class MalzemeController : Controller
        {
            private readonly ApplicationDbContext _context;
            public MalzemeController(ApplicationDbContext context)
            {
                _context = context;
            }
            //api/Malzeme
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Malzeme>>> GetMalzeme()
            {
                return await _context.Malzeme.ToListAsync();
            }
            // GET: api/Malzeme/1
            [HttpGet("{id}")]
            public async Task<ActionResult<Malzeme>> GetMalzeme(int id)
            {
                var Malzeme = await _context.Malzeme.FindAsync(id);

                if (Malzeme == null)
                {
                    return NotFound();
                }

                return Malzeme;
            }
            // PUT: api/Malzeme/1
            [HttpPut("{id}")]
            public async Task<IActionResult> PutMalzeme(int id, Malzeme Malzeme)
            {
                if (id != Malzeme.MalzemeId)
                {
                    return BadRequest();
                }

                _context.Entry(Malzeme).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MalzemeExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }
            // POST: api/Malzeme
            [HttpPost]
            public async Task<ActionResult<Malzeme>> PostMalzeme(Malzeme Malzeme)
            {
                _context.Malzeme.Add(Malzeme);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMalzeme", new { id = Malzeme.MalzemeId }, Malzeme);
            }
            // DELETE: api/Malzeme/1
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteMalzeme(int id)
            {
                var Malzeme = await _context.Malzeme.FindAsync(id);
                if (Malzeme == null)
                {
                    return NotFound();
                }

                _context.Malzeme.Remove(Malzeme);
                await _context.SaveChangesAsync();

                return NoContent();
            }


            public IActionResult Index()
            {
                return View();
            }
            private bool MalzemeExists(int id)
            {
                return _context.Malzeme.Any(e => e.MalzemeId == id);
            }
        }
    }

}
