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
    public class TipoAssistenciaController : ControllerBase
    {
        private readonly AppDBContext _db;
        public TipoAssistenciaController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tipoAssistencia = await _db.TiposAssistencia.ToListAsync();
            return Ok(tipoAssistencia);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var tipoAssistencia = await _db.TiposAssistencia.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(tipoAssistencia);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TipoAssistencia tipoAssistencia)
        {
            _db.Add(tipoAssistencia);
            await _db.SaveChangesAsync();
            return Ok(tipoAssistencia.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(TipoAssistencia tipoAssistencia)
        {
            _db.Entry(tipoAssistencia).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var tipoAssistencia = new TipoAssistencia { ID = id };
            _db.Remove(tipoAssistencia);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
