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
    public class HistoricoAssistenciasController : ControllerBase
    {
        private readonly AppDBContext _db;
        private UserManager<AppUser> _userManager;
        public HistoricoAssistenciasController(AppDBContext context, UserManager<AppUser> userManager)
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
            var uhs = await _db.Uhs.Where(u => userUhs.Contains(u.ID)).Select(n => n.ID).ToListAsync();

            var historico = await _db.HistoricoAssistencias.Where(u => uhs.Contains(u.UhID)).ToListAsync();
            return Ok(historico);
        }

        [HttpGet]
        [Route("GetHoje")]
        public async Task<IActionResult> GetHoje()
        {
            ClaimsPrincipal currentUser = User;
            var userId = _userManager.GetUserId(User);
            var userUhs = await _db.UsersUhs.Where(u => u.UserId == new Guid(userId)).Select(i => i.UhID).ToListAsync();
            var uhs = await _db.Uhs.Where(u => userUhs.Contains(u.ID)).Select(n => n.ID).ToListAsync();

            var historico = await _db.HistoricoAssistencias.Where(u => uhs.Contains(u.UhID) && u.Data.Day == DateTime.UtcNow.Day).ToListAsync();
            return Ok(historico);
        }

        [HttpGet]
        [Route("GetDia")]
        public async Task<IActionResult> GetDia(DateTime dia)
        {
            ClaimsPrincipal currentUser = User;
            var userId = _userManager.GetUserId(User);
            var userUhs = await _db.UsersUhs.Where(u => u.UserId == new Guid(userId)).Select(i => i.UhID).ToListAsync();
            var uhs = await _db.Uhs.Where(u => userUhs.Contains(u.ID)).Select(n => n.ID).ToListAsync();

            var historico = await _db.HistoricoAssistencias.Where(u => uhs.Contains(u.UhID) && u.Data.Day == dia.Day).ToListAsync();
            return Ok(historico);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var historico = await _db.HistoricoAssistencias.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(historico);
        }

        [HttpPost]
        public async Task<IActionResult> Post(HistoricoAssistencia historico)
        {
            _db.Add(historico);
            await _db.SaveChangesAsync();
            return Ok(historico);
        }

        [HttpPut]
        public async Task<IActionResult> Put(HistoricoAssistencia historico)
        {
            _db.Entry(historico).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return Ok(historico);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var historico = new HistoricoAssistencia { ID = id };
            _db.Remove(historico);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
