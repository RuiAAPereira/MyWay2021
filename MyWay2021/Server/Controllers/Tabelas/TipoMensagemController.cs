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
    public class TipoMensagemController : ControllerBase
    {
        private readonly AppDBContext _db;
        public TipoMensagemController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tipoMensagem = await _db.TiposMensagem.ToListAsync();
            return Ok(tipoMensagem);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var tipoMensagem = await _db.TiposMensagem.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(tipoMensagem);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TipoMensagem tipoMensagem)
        {
            _db.Add(tipoMensagem);
            await _db.SaveChangesAsync();
            return Ok(tipoMensagem.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(TipoMensagem tipoMensagem)
        {
            _db.Entry(tipoMensagem).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var tipoMensagem = new TipoMensagem { ID = id };
            _db.Remove(tipoMensagem);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
