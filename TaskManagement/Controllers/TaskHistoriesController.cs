using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data;
using TaskManagement.entity;

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskHistoriesController : ControllerBase
    {
        private readonly TaskManagementContext _context;

        public TaskHistoriesController(TaskManagementContext context)
        {
            _context = context;
        }

        // GET: api/TaskHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskHistory>>> GetTaskHistory()
        {
            return await _context.TaskHistory.ToListAsync();
        }

        // GET: api/TaskHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskHistory>> GetTaskHistory(int id)
        {
            var taskHistory = await _context.TaskHistory.FindAsync(id);

            if (taskHistory == null)
            {
                return NotFound();
            }

            return taskHistory;
        }

        // PUT: api/TaskHistories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskHistory(int id, TaskHistory taskHistory)
        {
            if (id != taskHistory.Id)
            {
                return BadRequest();
            }

            _context.Entry(taskHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskHistoryExists(id))
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

        // POST: api/TaskHistories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaskHistory>> PostTaskHistory(TaskHistory taskHistory)
        {
            _context.TaskHistory.Add(taskHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskHistory", new { id = taskHistory.Id }, taskHistory);
        }

        // DELETE: api/TaskHistories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskHistory(int id)
        {
            var taskHistory = await _context.TaskHistory.FindAsync(id);
            if (taskHistory == null)
            {
                return NotFound();
            }

            _context.TaskHistory.Remove(taskHistory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskHistoryExists(int id)
        {
            return _context.TaskHistory.Any(e => e.Id == id);
        }
    }
}
