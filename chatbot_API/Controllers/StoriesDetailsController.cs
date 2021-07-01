using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using chatbot_API.Models;

namespace chatbot_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoriesDetailsController : ControllerBase
    {
        private readonly StoriesDetailContext _context;

        public StoriesDetailsController(StoriesDetailContext context)
        {
            _context = context;
        }

        // GET: api/StoriesDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoriesDetail>>> GetStoriesDetails()
        {
            return await _context.StoriesDetails.ToListAsync();
        }

        // GET: api/StoriesDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoriesDetail>> GetStoriesDetail(int id)
        {
            var storiesDetail = await _context.StoriesDetails.FindAsync(id);

            if (storiesDetail == null)
            {
                return NotFound();
            }

            return storiesDetail;
        }

        // PUT: api/StoriesDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoriesDetail(int id, StoriesDetail storiesDetail)
        {
            if (id != storiesDetail.Stories_Id)
            {
                return BadRequest();
            }

            _context.Entry(storiesDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoriesDetailExists(id))
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

        // POST: api/StoriesDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoriesDetail>> PostStoriesDetail(StoriesDetail storiesDetail)
        {
            _context.StoriesDetails.Add(storiesDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStoriesDetail", new { id = storiesDetail.Stories_Id }, storiesDetail);
        }

        // DELETE: api/StoriesDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoriesDetail(int id)
        {
            var storiesDetail = await _context.StoriesDetails.FindAsync(id);
            if (storiesDetail == null)
            {
                return NotFound();
            }

            _context.StoriesDetails.Remove(storiesDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoriesDetailExists(int id)
        {
            return _context.StoriesDetails.Any(e => e.Stories_Id == id);
        }
    }
}
