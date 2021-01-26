using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MachineTestWebAPI.Models;

using MachineTestWebAPI.ViewModels;

namespace MachineTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitTablesController : ControllerBase
    {
        private readonly MT_PL1924Context _context;

        public VisitTablesController(MT_PL1924Context context)
        {
            _context = context;
        }

        // GET: api/VisitTables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewVisitTable>>> GetVisitTable()
        {
            List<VisitTable> data = await _context.VisitTable.ToListAsync();
            List<ViewVisitTable> mapDataList = new List<ViewVisitTable>();
            if (data == null)
            {
                return NotFound();
            }
            foreach (var item in data)
            {
                ViewVisitTable mapData = new ViewVisitTable(item);
                mapDataList.Add(mapData);
            }
            return mapDataList;
        }

        // GET: api/VisitTables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewVisitTable>> GetVisitTable(decimal id)
        {
            var data = await _context.VisitTable.FindAsync(id);

            if (data == null)
            {
                return NotFound();
            }

            ViewVisitTable mapData = new ViewVisitTable(data);

            return mapData;
        }

        // PUT: api/VisitTables/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisitTable(decimal id, ViewVisitTable visitTable)
        {
            if (id != visitTable.VisitId)
            {
                return BadRequest();
            }

            var visitFromDb = await _context.VisitTable.FirstOrDefaultAsync(r => r.VisitId == visitTable.VisitId);
            if (visitFromDb == null)
                return NotFound("No data Found");

            visitFromDb.CustName = visitTable.CustName;
            visitFromDb.Description = visitTable.Description;
            visitFromDb.InterestProduct = visitTable.InterestProduct;
            visitFromDb.IsDisabled = visitTable.IsDisabled;
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitTableExists(id))
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

        // POST: api/VisitTables
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VisitTable>> PostVisitTable(ViewVisitTable visitTable)
        {


            VisitTable v = new VisitTable();
            v.CustName = visitTable.CustName;
            v.ContactNo = visitTable.ContactNo;
            v.ContactPerson = visitTable.ContactPerson;
            v.Description = visitTable.Description;
            v.EmpId = visitTable.EmpId;
            v.VisitDatetime = DateTime.Now;
            v.InterestProduct = visitTable.InterestProduct;
            v.IsDeleted = false;
            v.IsDisabled = false;
            _context.VisitTable.Add(v);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVisitTable", new { id = visitTable.VisitId }, visitTable);
        }

        // DELETE: api/VisitTables/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VisitTable>> DeleteVisitTable(decimal id)
        {
            var visitTable = await _context.VisitTable.FindAsync(id);
            if (visitTable == null)
            {
                return NotFound();
            }

            _context.VisitTable.Remove(visitTable);
            await _context.SaveChangesAsync();

            return visitTable;
        }

        private bool VisitTableExists(decimal id)
        {
            return _context.VisitTable.Any(e => e.VisitId == id);
        }
    }
}
