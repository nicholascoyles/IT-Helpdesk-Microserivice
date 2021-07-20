using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FaqAPI.Database;
using FaqAPI.Models;
using System.Threading;

namespace FaqAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaqsController : ControllerBase
    {
        private readonly FaqDbContext _context;

        public FaqsController(FaqDbContext context)
        {
            _context = context;
        }

        // GET: api/Faqs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Faq>>> GetFaqs()
        {
            try
            {
                return await _context.Faqs.ToListAsync();
            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }



        // GET: api/Faqs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Faq>> GetFaq(Guid id)
        {
            try
            {
                var faq = await _context.Faqs.FindAsync(id);

            if (faq == null)
            {
                    return NotFound($"FAQ with Id = {id} not found");
            }

                return faq;

        }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
    }
}

        // PUT: api/Faqs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaq(Guid id, Faq faq)
        {
            try
            {
                if (id != faq.FaqId)
            {
                    return BadRequest("FAQ not found");
                }

                _context.Entry(faq).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaqExists(id))
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

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

        // POST: api/Faqs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<Faq>> PostFaq(Faq faq)
        {
            try
            {
                _context.Faqs.Add(faq);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaq", new { id = faq.FaqId }, faq);
            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }

        }

        // DELETE: api/Faqs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaq(Guid id)
        {
            try
            {

                var faq = await _context.Faqs.FindAsync(id);
            if (faq == null)
            {
                    return NotFound($"FAQ with Id = {id} not found");
             }

                _context.Faqs.Remove(faq);
            await _context.SaveChangesAsync();

            return NoContent();
            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

        private bool FaqExists(Guid id)
        {
            return _context.Faqs.Any(e => e.FaqId == id);
        }
    }
}
