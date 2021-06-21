using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Shared.Models.Tabelas;
using System;
using System.Threading.Tasks;

namespace MyWay2021.Server.Controllers.Tabelas
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortasController : Controller
    {
        private readonly AppDBContext _db;
        public PortasController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var porta = await _db.Portas.ToListAsync();
            return Ok(porta);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var porta = await _db.Portas.FirstOrDefaultAsync(a => a.PortaID == id);
            return Ok(porta);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Porta porta)
        {
            _db.Add(porta);
            await _db.SaveChangesAsync();
            return Ok(porta.PortaID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Porta porta)
        {
            _db.Entry(porta).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var porta = new Porta { PortaID = id };
            _db.Remove(porta);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}