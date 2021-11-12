using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Server.Models.Identity;
using MyWay2021.Shared.Models.Analise;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyWay2021.Server.Controllers.Analise
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisrupcoesController : ControllerBase
    {
        private readonly AppDBContext _db;
        private readonly UserManager<AppUser> _userManager;
        public DisrupcoesController(AppDBContext context, UserManager<AppUser> userManager)
        {
            _db = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetData(Guid uhID, string timeinicio, string timefim)
        {
            var cultureInfo = new CultureInfo("pt-PT");
            DateTime datainicio = DateTime.Parse(timeinicio, cultureInfo);
            DateTime datafim = DateTime.Parse(timefim, cultureInfo);
            List<Guid> uhs = new List<Guid>();

            if (uhID == Guid.Empty)
            {
                uhs = await Task.Run(() => GetUhsListAsync());
            }
            else
            {
                uhs.Add(uhID);
            }

            List<DadosAeroporto> disrupcoes = _db.DadosAeroportos.Where(d => uhs.Contains(d.UhID) &&
                (d.ActualTimeUTC <= d.ScheduleTimeUTC.AddMinutes(-15) || d.ActualTimeUTC >= d.ScheduleTimeUTC.AddMinutes(15))
                && d.ScheduleTimeUTC.Date >= datainicio.Date && d.ScheduleTimeUTC.Date <= datafim.Date
                ).ToList();

            List<string> mangas = _db.Stands.Where(s => s.Remoto == false).Select(s => s.StandN.ToString()).ToList();

            List<string> totalVoos = _db.DadosAeroportos.Where(d => uhs.Contains(d.UhID) &&
                d.ScheduleTimeUTC.Date >= datainicio.Date && d.ScheduleTimeUTC.Date <= datafim.Date).Select(v => v.Voo).ToList();

            int totalVoosAssistencias = _db.HistoricoAssistencias.Where(d => uhs.Contains(d.UhID) &&
                d.Data.Date >= datainicio.Date && d.Data.Date <= datafim.Date && totalVoos.Contains(d.Voo)
                ).GroupBy(d => new { d.Data.Date, d.Voo }).Count();

            //var results = _customerTable.GroupBy(c => new { c.Date, c.CUSTOMER_TYPE_ID }).Select(g => new { g.Key.Date, g.Key.CUSTOMER_TYPE_ID, MyCount = g.Count() });

            int totalDisrupcoes = _db.DadosAeroportos.Where(d => uhs.Contains(d.UhID) &&
                (d.ActualTimeUTC <= d.ScheduleTimeUTC.AddMinutes(-15) || d.ActualTimeUTC >= d.ScheduleTimeUTC.AddMinutes(15))
                && d.ScheduleTimeUTC.Date >= datainicio.Date && d.ScheduleTimeUTC.Date <= datafim.Date
                ).Distinct().Count();

            List<DadosAeroporto> voosDisrupcoes = _db.DadosAeroportos.Where(d => uhs.Contains(d.UhID) &&
                (d.ActualTimeUTC <= d.ScheduleTimeUTC.AddMinutes(-15) || d.ActualTimeUTC >= d.ScheduleTimeUTC.AddMinutes(15))
                && d.ScheduleTimeUTC.Date >= datainicio.Date && d.ScheduleTimeUTC.Date <= datafim.Date
                && _db.HistoricoAssistencias.Where(x => uhs.Contains(x.UhID) &&
                    x.Data.Date >= datainicio && x.Data.Date <= datafim
                    ).Select(v => v.Voo).Distinct().Contains(d.Voo)
                ).ToList();

            List<DadosAeroporto> voosDisrupcoesManga = voosDisrupcoes.Where(c => mangas.Contains(c.Stand)).ToList();
            int voosDisrupcoesRemoto = voosDisrupcoes.Except(voosDisrupcoesManga).Count();

            int PMRDisrupcoes = _db.HistoricoAssistencias.Where(d => uhs.Contains(d.UhID) &&
                d.Data.Date >= datainicio.Date && d.Data.Date <= datafim.Date
                && disrupcoes.Select(v => v.Voo).Distinct().Contains(d.Voo)
                ).Count();

            int totalPMR = _db.HistoricoAssistencias.Where(d => uhs.Contains(d.UhID) &&
                d.Data.Date >= datainicio.Date && d.Data.Date <= datafim.Date
                ).Count();

            //int pvca = totalAssistencias / totalVoos.Count * 100;
            //string percentagemVoosComAssistencias =  " % do total de voos";

            List<Disrupcoes> dados = new()
            {
                new Disrupcoes { Nome = "Total de assistências", Total = totalPMR, Percentagem = string.Empty, Color = "#00c0ef", Icon = "fa fa-wheelchair", BgColor = "bg-green" },
                new Disrupcoes { Nome = "Total de voos", Total = totalVoos.Count, Percentagem = string.Empty, Color = "#00c0ef", Icon = "fa fa-plane", BgColor = "bg-aqua" },
                new Disrupcoes { Nome = "Voos com assistências", Total = totalVoosAssistencias, Percentagem = CalculaPercentagem(totalVoosAssistencias, totalVoos.Count) + "% do total de voos", Color = "#00a65a", Icon = "fa fa-wheelchair", BgColor = "bg-green" },
                new Disrupcoes { Nome = "Total de disrupções", Total = totalDisrupcoes, Percentagem = CalculaPercentagem(totalDisrupcoes, totalVoos.Count) + "% do total de voos", Color = "#d33724", Icon = "fa fa-angle-left", BgColor = "bg-red" },
                new Disrupcoes { Nome = "Voos com assistências e disrupções", Total = voosDisrupcoes.Count, Percentagem = CalculaPercentagem(voosDisrupcoes.Count, totalDisrupcoes) + "% do total de voos com disrupção e dos quais " + voosDisrupcoesRemoto + " em stand remoto", Color = "#db8b0b", Icon = "fa fa-heartbeat", BgColor = "bg-yellow" },
                new Disrupcoes { Nome = "PMR afetados", Total = PMRDisrupcoes, Percentagem = CalculaPercentagem(PMRDisrupcoes, totalPMR) + "% do total de assistências", Color = "#ff851b", Icon = "fa fa-users", BgColor = "bg-orange" }
            };

            return Ok(dados);
        }

        private async Task<List<Guid>> GetUhsListAsync()
        {
            ClaimsPrincipal currentUser = User;
            var userId = _userManager.GetUserId(User);
            var userUhs = await _db.UsersUhs.Where(u => u.UserId == new Guid(userId)).Select(i => i.UhID).ToListAsync();
            var uhs = await _db.Uhs.Where(u => userUhs.Contains(u.ID)).Select(n => n.ID).ToListAsync();

            return uhs;
        }

        private static string CalculaPercentagem(int parcial, int total)
        {
            decimal percentagem = ((decimal)parcial / total) * 100;
            string x = Math.Round(percentagem, 2).ToString();
            return x;
        }
    }
}
