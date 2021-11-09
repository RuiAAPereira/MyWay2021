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
    public class DepartamentoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public DepartamentoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var departamentos = await _db.Departamentos.ToListAsync();
            return Ok(departamentos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var departamento = await _db.Departamentos.FirstOrDefaultAsync(a => a.DepartamentoId == id);
            return Ok(departamento);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Departamento departamento)
        {
            _db.Add(departamento);
            await _db.SaveChangesAsync();
            return Ok(departamento.DepartamentoId);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Departamento departamento)
        {
            _db.Entry(departamento).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var departamento = new Departamento { DepartamentoId = id };
            _db.Remove(departamento);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
