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
    public class TipoVooController : ControllerBase
    {
        private readonly AppDBContext _db;
        public TipoVooController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tipoVoos = await _db.TipoVoos.ToListAsync();
            return Ok(tipoVoos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var tipoVoos = await _db.TipoVoos.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(tipoVoos);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TipoVoo tipoVoos)
        {
            _db.Add(tipoVoos);
            await _db.SaveChangesAsync();
            return Ok(tipoVoos.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(TipoVoo tipoVoos)
        {
            _db.Entry(tipoVoos).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var tipoVoos = new TipoVoo { ID = id };
            _db.Remove(tipoVoos);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
