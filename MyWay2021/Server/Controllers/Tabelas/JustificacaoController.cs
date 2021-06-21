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
    public class JustificacaoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public JustificacaoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var justificacao = await _db.Justificacoes.ToListAsync();
            return Ok(justificacao);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var justificacao = await _db.Justificacoes.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(justificacao);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Justificacao justificacao)
        {
            _db.Add(justificacao);
            await _db.SaveChangesAsync();
            return Ok(justificacao.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Justificacao justificacao)
        {
            _db.Entry(justificacao).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var justificacao = new Justificacao { ID = id };
            _db.Remove(justificacao);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
