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

namespace MyWay2021.Server.Controllers.Analise
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosAeroportoController : ControllerBase
    {
        private readonly AppDBContext _db;
        private UserManager<AppUser> _userManager;
        public DadosAeroportoController(AppDBContext context, UserManager<AppUser> userManager)
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

            var dados = await _db.DadosAeroportos.Where(u => uhs.Contains(u.UhID)).ToListAsync();
            return Ok(dados);
        }

        [HttpGet]
        [Route("GetDia")]
        public async Task<IActionResult> GetDia(DateTime dia)
        {
            ClaimsPrincipal currentUser = User;
            var userId = _userManager.GetUserId(User);
            var userUhs = await _db.UsersUhs.Where(u => u.UserId == new Guid(userId)).Select(i => i.UhID).ToListAsync();
            var uhs = await _db.Uhs.Where(u => userUhs.Contains(u.ID)).Select(n => n.ID).ToListAsync();

            var dados = await _db.DadosAeroportos.Where(u => uhs.Contains(u.UhID) && u.ScheduleTimeUTC.Day == dia.Day).ToListAsync();
            return Ok(dados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dados = await _db.DadosAeroportos.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Post(DadosAeroporto dados)
        {
            _db.Add(dados);
            await _db.SaveChangesAsync();
            return Ok(dados);
        }

        [HttpPut]
        public async Task<IActionResult> Put(DadosAeroporto dados)
        {
            _db.Entry(dados).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return Ok(dados);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var dados = new DadosAeroporto { ID = id };
            _db.Remove(dados);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
