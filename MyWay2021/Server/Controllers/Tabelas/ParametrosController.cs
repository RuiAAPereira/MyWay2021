using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Shared.Models.Tabelas;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWay2021.Server.Controllers.Tabelas
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametrosController : ControllerBase
    {
        private readonly AppDBContext _db;
        public ParametrosController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var parametros = await _db.Parametros.ToListAsync();
            return Ok(parametros);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var parametro = await _db.Parametros.FirstOrDefaultAsync(a => a.ParamID == id);
            return Ok(parametro);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Parametro parametro)
        {
            _db.Add(parametro);
            await _db.SaveChangesAsync();
            return Ok(parametro.ParamID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Parametro parametro)
        {
            _db.Entry(parametro).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var parametro = new Parametro { ParamID = id };
            _db.Remove(parametro);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
