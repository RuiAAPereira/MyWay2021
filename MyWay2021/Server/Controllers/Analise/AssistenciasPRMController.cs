using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Server.Models.Identity;
using MyWay2021.Shared.Models.Analise;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyWay2021.Server.Controllers.Tabelas
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistenciasPRMController : ControllerBase
    {
        private readonly AppDBContext _db;
        private UserManager<AppUser> _userManager;
        public AssistenciasPRMController(AppDBContext context, UserManager<AppUser> userManager)
        {
            _db = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            ClaimsPrincipal currentUser = User;
            var userId = _userManager.GetUserId(User);
            var userUhs = await _db.UsersUhs.Where(u => u.UserId == new Guid(userId)).Select(i => i.UhID).ToListAsync();
            var uhs = await _db.Uhs.Where(u => userUhs.Contains(u.ID)).Select(n => n.IATA).ToListAsync();

            var assistencias = await _db.AssistenciasPRMS.Where(u => uhs.Contains(u.Aeroporto)).ToListAsync();
            return Ok(assistencias);
        }

        [HttpGet]
        [Route("GetHoje")]
        public async Task<IActionResult> GetHoje()
        {
            ClaimsPrincipal currentUser = User;
            var userId = _userManager.GetUserId(User);
            var userUhs = await _db.UsersUhs.Where(u => u.UserId == new Guid(userId)).Select(i => i.UhID).ToListAsync();
            var uhs = await _db.Uhs.Where(u => userUhs.Contains(u.ID)).Select(n => n.IATA).ToListAsync();

            var assistencias = await _db.AssistenciasPRMS.Where(u => uhs.Contains(u.Aeroporto) && u.Data.Day == DateTime.UtcNow.Day).ToListAsync();
            return Ok(assistencias);
        }

        [HttpGet]
        [Route("GetDia")]
        public async Task<IActionResult> GetDia(DateTime dia)
        {
            ClaimsPrincipal currentUser = User;
            var userId = _userManager.GetUserId(User);
            var userUhs = await _db.UsersUhs.Where(u => u.UserId == new Guid(userId)).Select(i => i.UhID).ToListAsync();
            var uhs = await _db.Uhs.Where(u => userUhs.Contains(u.ID)).Select(n => n.IATA).ToListAsync();

            var assistencias = await _db.AssistenciasPRMS.Where(u => uhs.Contains(u.Aeroporto) && u.Data.Day == dia.Day).ToListAsync();
            return Ok(assistencias);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var assistencia = await _db.AssistenciasPRMS.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(assistencia);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AssistenciasPRM assistencia)
        {
            _db.Add(assistencia);
            await _db.SaveChangesAsync();
            return Ok(assistencia);
        }

        [HttpPut]
        public async Task<IActionResult> Put(AssistenciasPRM assistencia)
        {
            _db.Entry(assistencia).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return Ok(assistencia);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var assistencia = new AssistenciasPRM { ID = id };
            _db.Remove(assistencia);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
