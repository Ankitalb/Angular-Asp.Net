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
    public class LoginsController : ControllerBase
    {
        private readonly MT_PL1924Context _context;

        public LoginsController(MT_PL1924Context context)
        {
            _context = context;
        }

        // GET: api/Logins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Login>>> GetLogin()
        {
            return await _context.Login.ToListAsync();
        }

        // GET: api/Logins/5
        [HttpGet("{l}")]
        public async Task<ActionResult<LoginView>> GetLogin(string l)
        {
            var login =  _context.Login.FirstOrDefault(e=>e.Username==l);

            if (login == null)
            {
                return NotFound();
            }
            var loginView = new LoginView();
            loginView.Username = login.Username;
            loginView.UserType = login.UserType;
            loginView.Password = login.Password; 
            return loginView;
        }

        // PUT: api/Logins/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogin(decimal id, Login login)
        {
            if (id != login.LId)
            {
                return BadRequest();
            }

            _context.Entry(login).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginExists(id))
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

        // POST: api/Logins
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Login>> PostLogin(LoginView vlogin)
        {
            var login = new Login();
            login.Username = vlogin.Username;
            login.UserType = vlogin.UserType;
            login.Password = vlogin.Password;
            _context.Login.Add(login);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLogin", new { id = login.LId }, login);
        }

        // DELETE: api/Logins/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Login>> DeleteLogin(decimal id)
        {
            var login = await _context.Login.FindAsync(id);
            if (login == null)
            {
                return NotFound();
            }

            _context.Login.Remove(login);
            await _context.SaveChangesAsync();

            return login;
        }

        private bool LoginExists(decimal id)
        {
            return _context.Login.Any(e => e.LId == id);
        }
    }
}
