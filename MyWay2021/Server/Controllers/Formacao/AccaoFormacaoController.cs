using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Shared.Models.Colaboradores;
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
                .Where(d => d.DataAccao > DateTime.UtcNow.AddYears(-4) && d.Colaborador.Ativo == true)
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

        [HttpGet]
        [Route("GetListagemMyWay")]
        public async Task<IActionResult> GetListagemMyWay()
        {
            //List<string> cursosSecurity = new()
            //{
            //    "SEGURANCA AEROPORTUARIA NIVEL 13"
            //};
            //var idsCursosSecurity = GetCursosIDsAsync(cursosSecurity);

            //List<string> cursosDGR = new()
            //{
            //    "DANGEROUS GOODS REGULATIONS (CAT9)",
            //    "DANGEROUS GOODS REGULATIONS (CAT9) 2016",
            //    "DANGEROUS GOODS REGULATIONS (CAT9) 2017",
            //    "DANGEROUS GOODS REGULATIONS (CAT9) 2018 INDIVIDUAL",
            //    "DANGEROUS GOODS REGULATIONS (CAT9) 2018 TURMA",
            //    "DANGEROUS GOODS REGULATIONS (CAT9) INDIVIDUAL",
            //    "DANGEROUS GOODS REGULATIONS 9 - ELEARNING",
            //    "DANGEROUS GOODS REGULATIONS 9 - ELEARNING INDIVIDUAL",
            //    "DANGEROUS GOODS REGULATIONS 9 2017-18",
            //    "DANGEROUS GOODS REGULATIONS CAT 9"
            //};
            //var idsCursosDGR = GetCursosIDsAsync(cursosDGR);

            //List<string> cursosBPMR = new()
            //{
            //    "BASICO DE PMR INICIAL",
            //    "BASICO DE PMR REFRESH",
            //    "CURSO BASICO DE PMR - REFRESCAMENTO",
            //    "CURSO BASICO DE PMR REFRESH",
            //    "CURSO BASICO PMR – REFRESH - ELEARNING"
            //};
            //var idsCursosBPMR = GetCursosIDsAsync(cursosBPMR);

            //List<string> cursosSC = new()
            //{
            //    "RAMP SAFETY PLACA",
            //    "RAMP SAFETY PLACA 2016",
            //    "RAMP SAFETY PLACA 2017",
            //    "RAMP SAFETY PLACA 2018 INDIVIDUAL",
            //    "RAMP SAFETY PLACA 2018 TURMA",
            //    "RAMP SAFETY PLACA 2019",
            //    "RAMP SAFETY PLACA REFRESH - ELEARNING INDIVIDUAL",
            //    "REGRAS DE SEGURANCA NA PLACA 02 HORAS REFRESH MYWAY- ELEARNING INDIVIDUAL",
            //    "REGRAS DE SEGURANCA NA PLACA 02 HORAS REFRESH MYWAY- ELEARNING TURMA",
            //    "REGRAS DE SEGURANCA NA PLACA 02H PAX REFRESH - ELEARNING TURMA",
            //    "REGRAS DE SEGURANCA NA PLACA 04 HORAS PAX REFRESH",
            //    "REGRAS DE SEGURANCA NA PLACA 04 HORAS REFRESH PLACA OPS CARGA - ELEARNING",
            //    "REGRAS DE SEGURANCA NA PLACA 08 HORAS REFRESH PLACA OPS CARGA",
            //    "REGRAS DE SEGURANCA NA PLACA 08HORAS PAX",
            //    "REGRAS DE SEGURANCA NA PLACA 16 HORAS PLACA OPS CARGA",
            //    "REGRAS DE SEGURANCA NA PLACA 21 HORAS",
            //    "REGRAS DE SEGURANCA NA PLACA JAN2018",
            //    "REGRAS DE SEGURANCA NA PLACA MYWAY JAN2018",
            //    "REGRAS DE SEGURANCA NA PLACA PAX JAN2018",
            //    "FACTORES HUMANOS (NAO USAR)",
            //    "HUMAN FACTOR",
            //    "SAFETY & COMPLIENCE - MYWAY - (E-LEARNING INDIVIDUAL)",
            //    "SAFETY & COMPLIENCE I - (E - LEARNING INDIVIDUAL)",
            //    "SAFETY & COMPLIENCE II - (E - LEARNING INDIVIDUAL)",
            //    "SAFETY & COMPLIENCE PAX - (E - LEARNING INDIVIDUAL)"
            //};
            //var idsCursosSC = GetCursosIDsAsync(cursosSC);

            //List<string> cursosENB = new()
            //{
            //    "INICIAL DE ASSISTENTES DE PASSAGEIROS COM DEFICIENCIA OU COM MOBILIDADE REDUZIDA - ESCOLA NACIONAL DE BOMBEIROS",
            //    "REFRESH DE ASSISTENTES DE PASSAGEIROS COM DEFICIENCIA OU COM MOBILIDADE REDUZIDA - ESCOLA NACIONAL DE BOMBEIROS"
            //};
            //var idsCursosENB = GetCursosIDsAsync(cursosENB);

            //List<string> cursosSST = new()
            //{
            //    "SEGURANCA E SAUDE NO TRABALHO",
            //    "SEGURANCA E SAUDE NO TRABALHO - ELEARNING",
            //    "SEGURANCA HIGIENE E SAUDE NO TRABALHO"
            //};
            //var idsCursosSST = GetCursosIDsAsync(cursosSST);

            //List<string> cursosSMS = new()
            //{
            //    "SAFETY MANAGEMENT SYSTEM - SENSIBILIZACAO  (ELEARNING)",
            //    "SAFETY MANAGEMENT SYSTEM (SMS)"
            //};
            //var idsCursosSMS = GetCursosIDsAsync(cursosSMS);

            var listagem = new List<ListagemAccoesMyWay>();
            List<Colaborador> colaboradores = await _db.Colaboradores
                .Where(d => d.Departamento.DepartamentoNome == "MYWAY" && d.Ativo == true)
                .ToListAsync();

            foreach (var colaborador in colaboradores)
            {
                //var sec = GetInitEnd(colaborador.ColaboradorID, idsCursosSecurity);
                //var dgr = GetInitEnd(colaborador.ColaboradorID, idsCursosDGR);
                //var bpmr = GetInitEnd(colaborador.ColaboradorID, idsCursosBPMR);
                //var sc = GetInitEnd(colaborador.ColaboradorID, idsCursosSC);
                //var enb = GetInitEnd(colaborador.ColaboradorID, idsCursosENB);
                //var sst = GetInitEnd(colaborador.ColaboradorID, idsCursosSST);
                //var sms = GetInitEnd(colaborador.ColaboradorID, idsCursosSMS);

                var listItem = new ListagemAccoesMyWay
                {
                    FormandoID = colaborador.ColaboradorID,
                    Ativo = colaborador.Ativo,
                    NumPw = (int)colaborador.NumPw,
                    Formando = colaborador.Nome,
                    //SecurityInit = sec.Init,
                    //SecurityEnd = sec.End,
                    //DGRInit = dgr.Init,
                    //DGREnd = dgr.End,
                    //BPMRInit = bpmr.Init,
                    //BPMREnd = bpmr.End,
                    //SCInit = sc.Init,
                    //SCEnd = sc.End,
                    //ENBInit = enb.Init,
                    //ENBEnd = enb.End,
                    //SSTInit = sst.Init,
                    //SSTEnd = sst.End,
                    //SMSInit = sms.Init,
                    //SMSEnd = sms.End
                };
                listagem.Add(listItem);
            }

            List<ListagemAccoesMyWay> SortedList = listagem.OrderBy(o => o.Formando).ToList();

            return Ok(SortedList);
        }

        public List<Guid> GetCursosIDsAsync(List<string> cursos)
        {
            List<Guid> cursosIDs = _db.Cursos
                .Where(c => cursos.Contains(c.Designacao))
                .Select(i => i.CursoID)
                .ToList();

            return cursosIDs;
        }

        public int ValidadeCurso(Guid id)
        {
            return _db.Cursos
            .Where(c => c.CursoID == id)
            .Select(i => i.Validade).FirstOrDefault();
        }

        public InitEnd GetInitEnd(Guid colaboradorID, List<Guid> idsCursos)
        {
            AccaoFormacao accao = _db.AccoesFormacao
                //.Where(c =>  c.ColaboradorID == colaboradorID)
                //.OrderByDescending(d => d.DataAccao)
                .FirstOrDefault();

            if (accao != null)
            {
                int validade = ValidadeCurso(accao.CursoID);

                var initEnd = new InitEnd
                {
                    Init = accao.DataAccao,
                    End = accao.DataAccao.AddYears(validade)
                };
                return initEnd;
            }
            else
            {
                var initEnd = new InitEnd
                {
                    Init = null,
                    End = null
                };
                return initEnd;
            }
        }
    }

    public class InitEnd
    {
        public DateTime? Init { get; set; }
        public DateTime? End { get; set; }
    }
}
