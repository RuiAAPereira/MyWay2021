using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Shared.Models.Formacoes;
using MyWay2021.Shared.Models.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWay2021.Server.Controllers.Colaboradores
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccaoFormacaoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public AccaoFormacaoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var accaoFormacao = await _db.AccoesFormacao.ToListAsync();
            return Ok(accaoFormacao);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var accaoFormacao = await _db.AccoesFormacao.FirstOrDefaultAsync(a => a.AccaoFormacaoID == id);
            return Ok(accaoFormacao);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AccaoFormacao accaoFormacao)
        {
            _db.Add(accaoFormacao);
            await _db.SaveChangesAsync();
            return Ok(accaoFormacao.AccaoFormacaoID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(AccaoFormacao accaoFormacao)
        {
            _db.Entry(accaoFormacao).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var accaoFormacao = new AccaoFormacao { AccaoFormacaoID = id };
            _db.Remove(accaoFormacao);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet]
        [Route("GetListagem")]
        public async Task<IActionResult> GetListagem()
        {
            var listagem = new List<ListagemAccoesFormacao>();
            var accaoFormacao = await _db.AccoesFormacao
                .Include(c => c.Colaborador)
                .Include(c => c.Curso)
                .Where(d=>d.DataAccao > DateTime.UtcNow.AddYears(-3) && d.Colaborador.Ativo == true)
                .ToListAsync();

            foreach (var item in accaoFormacao)
            {
                var listItem = new ListagemAccoesFormacao
                {
                    AccaoFormacaoID = item.AccaoFormacaoID,
                    Colaborador = item.Colaborador.Nome,
                    Curso = item.Curso.Designacao,
                    DataAccao = item.DataAccao,
                    DataValidade = item.DataAccao.AddYears(item.Curso.Validade)
                };
                listagem.Add(listItem);
            }

            List<ListagemAccoesFormacao> SortedList = listagem.OrderBy(o => o.DataValidade).ToList();

            return Ok(SortedList);
        }
    }
}
