using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.PROTESTO.Models;
using Microsoft.EntityFrameworkCore;

namespace API.PROTESTO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtestoController : ControllerBase
    {
        private readonly ProtestoContext _context;

        public ProtestoController(ProtestoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Protesto>>> GetProtestos()
        {
            return await _context.Protestos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Protesto>> GetProtesto(int id)
        {
            var protesto = await _context.Protestos.FindAsync(id);

            if (protesto == null)
            {
                return NotFound();
            }

            return protesto;
        }

        [HttpPost]
        public async Task<ActionResult<Protesto>> PostProtesto(Protesto protesto)
        {
            _context.Protestos.Add(protesto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProtesto), new { id = protesto.ProtestoID }, protesto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProtesto(int id, Protesto protesto)
        {
            if (id != protesto.ProtestoID)
            {
                return BadRequest();
            }

            _context.Entry(protesto).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<Protesto>> DeleteProtesto(int id)
        {
            var protesto = await _context.Protestos.FindAsync(id);

            if (protesto == null)
            {
                return NotFound();
            }

            _context.Protestos.Remove(protesto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
