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
    public class CursoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public CursoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var curso = await _db.Cursos.ToListAsync();
            return Ok(curso);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var curso = await _db.Cursos.FirstOrDefaultAsync(a => a.CursoID == id);
            return Ok(curso);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Curso curso)
        {
            _db.Add(curso);
            await _db.SaveChangesAsync();
            return Ok(curso.CursoID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Curso curso)
        {
            _db.Entry(curso).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var curso = new Curso { CursoID = id };
            _db.Remove(curso);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
