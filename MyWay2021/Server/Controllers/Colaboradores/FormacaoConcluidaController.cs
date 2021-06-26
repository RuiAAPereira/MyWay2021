using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Shared.Models.Colaboradores;
using System;
using System.Threading.Tasks;

namespace MyWay2021.Server.Controllers.Colaboradores
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormacaoConcluidaController : ControllerBase
    {
        private readonly AppDBContext _db;
        public FormacaoConcluidaController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var formacoes = await _db.FormacoesConcluidas.ToListAsync();
            return Ok(formacoes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var formacoes = await _db.FormacoesConcluidas.FirstOrDefaultAsync(a => a.FCID == id);
            return Ok(formacoes);
        }

        [HttpPost]
        public async Task<IActionResult> Post(FormacaoConcluida formacoes)
        {
            _db.Add(formacoes);
            await _db.SaveChangesAsync();
            return Ok(formacoes.FCID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(FormacaoConcluida formacoes)
        {
            _db.Entry(formacoes).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var formacoes = new FormacaoConcluida { FCID = id };
            _db.Remove(formacoes);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
