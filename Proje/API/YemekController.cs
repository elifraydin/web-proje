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
    namespace WebYemek.API
    {
        [Route("api/[controller]")]
        [ApiController]
        public class YemekController : Controller
        {
            private readonly ApplicationDbContext _context;
            public YemekController(ApplicationDbContext context)
            {
                _context = context;
            }
            //api/yemek
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Yemek>>> GetYemek()
            {
                return await _context.Yemek.ToListAsync();
            }
            // GET: api/Yemek/1
            [HttpGet("{id}")]
            public async Task<ActionResult<Yemek>> GetYemek(int id)
            {
                var Yemek = await _context.Yemek.FindAsync(id);

                if (Yemek == null)
                {
                    return NotFound();
                }

                return Yemek;
            }
            // PUT: api/Yemek/1
            [HttpPut("{id}")]
            public async Task<IActionResult> PutYemek(int id, Yemek Yemek)
            {
                if (id != Yemek.Id)
                {
                    return BadRequest();
                }

                _context.Entry(Yemek).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YemekExists(id))
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
            // POST: api/Yemek
            [HttpPost]
            public async Task<ActionResult<Yemek>> PostYemek(Yemek Yemek)
            {
                _context.Yemek.Add(Yemek);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetYemek", new { id = Yemek.Id }, Yemek);
            }
            // DELETE: api/Yemek/1
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteYemek(int id)
            {
                var Yemek = await _context.Yemek.FindAsync(id);
                if (Yemek == null)
                {
                    return NotFound();
                }

                _context.Yemek.Remove(Yemek);
                await _context.SaveChangesAsync();

                return NoContent();
            }


            public IActionResult Index()
            {
                return View();
            }
            private bool YemekExists(int id)
            {
                return _context.Yemek.Any(e => e.Id == id);
            }
        }
    }

}
