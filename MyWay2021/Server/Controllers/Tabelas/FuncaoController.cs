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
    public class FuncaoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public FuncaoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var funcao = await _db.Funcoes.ToListAsync();
            return Ok(funcao);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var funcao = await _db.Funcoes.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(funcao);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Funcao funcao)
        {
            _db.Add(funcao);
            await _db.SaveChangesAsync();
            return Ok(funcao.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Funcao funcao)
        {
            _db.Entry(funcao).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var funcao = new Funcao { ID = id };
            _db.Remove(funcao);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
