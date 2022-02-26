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
    public class CAT_CMV_TIPO_CUENTAController : ControllerBase
    {
        private readonly BackContext _context;

        public CAT_CMV_TIPO_CUENTAController(BackContext context)
        {
            _context = context;
        }

        // GET: api/CAT_CMV_TIPO_CUENTA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CAT_CMV_TIPO_CUENTA>>> GetCAT_CMV_TIPO_CUENTA()
        {
            return await _context.CAT_CMV_TIPO_CUENTA.ToListAsync();
        }

        // GET: api/CAT_CMV_TIPO_CUENTA/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CAT_CMV_TIPO_CUENTA>> GetCAT_CMV_TIPO_CUENTA(int id)
        {
            var cAT_CMV_TIPO_CUENTA = await _context.CAT_CMV_TIPO_CUENTA.FindAsync(id);

            if (cAT_CMV_TIPO_CUENTA == null)
            {
                return NotFound();
            }

            return cAT_CMV_TIPO_CUENTA;
        }

        // PUT: api/CAT_CMV_TIPO_CUENTA/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCAT_CMV_TIPO_CUENTA(int id, CAT_CMV_TIPO_CUENTA cAT_CMV_TIPO_CUENTA)
        {
            if (id != cAT_CMV_TIPO_CUENTA.id_cuenta)
            {
                return BadRequest();
            }

            _context.Entry(cAT_CMV_TIPO_CUENTA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CAT_CMV_TIPO_CUENTAExists(id))
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

        // POST: api/CAT_CMV_TIPO_CUENTA
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CAT_CMV_TIPO_CUENTA>> PostCAT_CMV_TIPO_CUENTA(CAT_CMV_TIPO_CUENTA cAT_CMV_TIPO_CUENTA)
        {
            _context.CAT_CMV_TIPO_CUENTA.Add(cAT_CMV_TIPO_CUENTA);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCAT_CMV_TIPO_CUENTA", new { id = cAT_CMV_TIPO_CUENTA.id_cuenta }, cAT_CMV_TIPO_CUENTA);
        }

        // DELETE: api/CAT_CMV_TIPO_CUENTA/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCAT_CMV_TIPO_CUENTA(int id)
        {
            var cAT_CMV_TIPO_CUENTA = await _context.CAT_CMV_TIPO_CUENTA.FindAsync(id);
            if (cAT_CMV_TIPO_CUENTA == null)
            {
                return NotFound();
            }

            _context.CAT_CMV_TIPO_CUENTA.Remove(cAT_CMV_TIPO_CUENTA);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CAT_CMV_TIPO_CUENTAExists(int id)
        {
            return _context.CAT_CMV_TIPO_CUENTA.Any(e => e.id_cuenta == id);
        }
    }
}
