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
    public class FormandoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public FormandoController(AppDBContext context)
        {
            this._db = context;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var formando = await _db.Formandos.ToListAsync();
        //    return Ok(formando);
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(Guid id)
        //{
        //    var formando = await _db.Formandos.FirstOrDefaultAsync(a => a.ID == id);
        //    return Ok(formando);
        //}

        [HttpPost]
        public async Task<IActionResult> Post(Formando formando)
        {
            _db.Add(formando);
            await _db.SaveChangesAsync();
            return Ok(formando.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Formando formando)
        {
            _db.Entry(formando).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var formando = new Formando { ID = id };
            _db.Remove(formando);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
