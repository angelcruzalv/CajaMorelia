using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Back.Data;
using Back.Models;

namespace Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TBL_CMV_CLIENTE_CUENTAController : ControllerBase
    {
        private readonly BackContext _context;

        public TBL_CMV_CLIENTE_CUENTAController(BackContext context)
        {
            _context = context;
        }

        // GET: api/TBL_CMV_CLIENTE_CUENTA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBL_CMV_CLIENTE_CUENTA>>> GetTBL_CMV_CLIENTE_CUENTA()
        {
            return await _context.TBL_CMV_CLIENTE_CUENTA.ToListAsync();
        }

        // GET: api/TBL_CMV_CLIENTE_CUENTA/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TBL_CMV_CLIENTE_CUENTA>> GetTBL_CMV_CLIENTE_CUENTA(int id)
        {
            var tBL_CMV_CLIENTE_CUENTA = await _context.TBL_CMV_CLIENTE_CUENTA.FindAsync(id);

            if (tBL_CMV_CLIENTE_CUENTA == null)
            {
                return NotFound();
            }

            return tBL_CMV_CLIENTE_CUENTA;
        }

        // PUT: api/TBL_CMV_CLIENTE_CUENTA/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTBL_CMV_CLIENTE_CUENTA(int id, TBL_CMV_CLIENTE_CUENTA tBL_CMV_CLIENTE_CUENTA)
        {
            if (id != tBL_CMV_CLIENTE_CUENTA.id_cliente_cuenta)
            {
                return BadRequest();
            }

            _context.Entry(tBL_CMV_CLIENTE_CUENTA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TBL_CMV_CLIENTE_CUENTAExists(id))
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

        // POST: api/TBL_CMV_CLIENTE_CUENTA
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TBL_CMV_CLIENTE_CUENTA>> PostTBL_CMV_CLIENTE_CUENTA(TBL_CMV_CLIENTE_CUENTA tBL_CMV_CLIENTE_CUENTA)
        {
            _context.TBL_CMV_CLIENTE_CUENTA.Add(tBL_CMV_CLIENTE_CUENTA);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTBL_CMV_CLIENTE_CUENTA", new { id = tBL_CMV_CLIENTE_CUENTA.id_cliente_cuenta }, tBL_CMV_CLIENTE_CUENTA);
        }

        // DELETE: api/TBL_CMV_CLIENTE_CUENTA/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTBL_CMV_CLIENTE_CUENTA(int id)
        {
            var tBL_CMV_CLIENTE_CUENTA = await _context.TBL_CMV_CLIENTE_CUENTA.FindAsync(id);
            if (tBL_CMV_CLIENTE_CUENTA == null)
            {
                return NotFound();
            }

            _context.TBL_CMV_CLIENTE_CUENTA.Remove(tBL_CMV_CLIENTE_CUENTA);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TBL_CMV_CLIENTE_CUENTAExists(int id)
        {
            return _context.TBL_CMV_CLIENTE_CUENTA.Any(e => e.id_cliente_cuenta == id);
        }
    }
}
