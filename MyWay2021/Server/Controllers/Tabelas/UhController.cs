using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Server.Models.Identity;
using MyWay2021.Shared.Models.Tabelas;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyWay2021.Server.Controllers.Tabelas
{
    [Route("api/[controller]")]
    [ApiController]
    public class UhController : ControllerBase
    {
        private readonly AppDBContext _db;
        private UserManager<AppUser> _userManager;
        public UhController(AppDBContext context, UserManager<AppUser> userManager)
        {
            this._db = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var uhs = await _db.Uhs.ToListAsync();
            return Ok(uhs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var uh = await _db.Uhs.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(uh);
        }

        [HttpGet]
        [Route("GetUhOwned")]
        public async Task<IActionResult> GetUhOwned()
        {
            ClaimsPrincipal currentUser = User;
            var userId = _userManager.GetUserId(User);
            var userUhs = await _db.UsersUhs.Where(u => u.UserId == new Guid(userId)).Select(i => i.UhID).ToListAsync();
            var uhs = await _db.Uhs.Where(u => userUhs.Contains(u.ID)).ToListAsync();
            return Ok(uhs);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Uh uh)
        {
            _db.Add(uh);
            await _db.SaveChangesAsync();
            return Ok(uh.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Uh uh)
        {
            _db.Entry(uh).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var uh = new Uh { ID = id };
            _db.Remove(uh);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
