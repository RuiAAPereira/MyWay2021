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
    public class ColaboradorController : ControllerBase
    {
        private readonly AppDBContext _db;
        public ColaboradorController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var colaborador = await _db.Colaboradores
                .Include(u => u.Uh)
                .Include(d => d.Departamento)
                .ToListAsync();
            return Ok(colaborador);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var colaborador = await _db.Colaboradores
                .FirstOrDefaultAsync(a => a.ColaboradorID == id);
            return Ok(colaborador);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Colaborador colaborador)
        {
            _db.Add(colaborador);
            await _db.SaveChangesAsync();
            return Ok(colaborador.ColaboradorID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Colaborador colaborador)
        {
            _db.Entry(colaborador).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var colaborador = new Colaborador { ColaboradorID = id };
            _db.Remove(colaborador);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
