using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Workshop;

namespace API_Workshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly VideoGameContext _context;

        public VideoGamesController(VideoGameContext context)
        {
            _context = context;
        }

        // GET: api/VideoGames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VideoGame>>> GetVideoGames()
        {
          if (_context.VideoGames == null)
          {
              return NotFound();
          }
            return await _context.VideoGames.ToListAsync();
        }

        // GET: api/VideoGames/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGame(int id)
        {
          if (_context.VideoGames == null)
          {
              return NotFound();
          }
            var videoGame = await _context.VideoGames.FindAsync(id);

            if (videoGame == null)
            {
                return NotFound();
            }

            return videoGame;
        }

        // PUT: api/VideoGames/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVideoGame(int id, VideoGame videoGame)
        {
            if (id != videoGame.Id)
            {
                return BadRequest();
            }

            _context.Entry(videoGame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideoGameExists(id))
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

        // POST: api/VideoGames
        [HttpPost]
        public async Task<ActionResult<VideoGame>> PostVideoGame(VideoGame videoGame)
        {
          if (_context.VideoGames == null)
          {
              return Problem("Entity set 'VideoGameContext.VideoGames'  is null.");
          }
            _context.VideoGames.Add(videoGame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVideoGame", new { id = videoGame.Id }, videoGame);
        }

        // DELETE: api/VideoGames/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideoGame(int id)
        {
            if (_context.VideoGames == null)
            {
                return NotFound();
            }
            var videoGame = await _context.VideoGames.FindAsync(id);
            if (videoGame == null)
            {
                return NotFound();
            }

            _context.VideoGames.Remove(videoGame);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VideoGameExists(int id)
        {
            return (_context.VideoGames?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
