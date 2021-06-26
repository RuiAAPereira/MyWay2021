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
        private UserManager<AppUser> _userManager;
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
                (d.ActualTimeUTC <= d.ScheduleTimeUTC.AddMinutes(-30) || d.ActualTimeUTC >= d.ScheduleTimeUTC.AddMinutes(30))
                && d.ScheduleTimeUTC.Day >= datainicio.Day && d.ScheduleTimeUTC.Day <= datafim.Day
                ).ToList();

            List<string> totalVoos = _db.DadosAeroportos.Where(d => uhs.Contains(d.UhID) &&
                d.ScheduleTimeUTC.Day >= datainicio.Day && d.ScheduleTimeUTC.Day <= datafim.Day).Select(v=>v.Voo).ToList();

            int totalAssistencias = _db.HistoricoAssistencias.Where(d => uhs.Contains(d.UhID) &&
                d.Data.Day >= datainicio.Day && d.Data.Day <= datafim.Day && totalVoos.Contains(d.Voo)
                ).Select(v => v.Voo).Distinct().Count();

            int totalDisrupcoes = _db.DadosAeroportos.Where(d => uhs.Contains(d.UhID) &&
                (d.ActualTimeUTC <= d.ScheduleTimeUTC.AddMinutes(-30) || d.ActualTimeUTC >= d.ScheduleTimeUTC.AddMinutes(30))
                && d.ScheduleTimeUTC.Day >= datainicio.Day && d.ScheduleTimeUTC.Day <= datafim.Day
                ).Distinct().Count();

            int voosDisrupcoes = _db.DadosAeroportos.Where(d => uhs.Contains(d.UhID) &&
                (d.ActualTimeUTC <= d.ScheduleTimeUTC.AddMinutes(-30) || d.ActualTimeUTC >= d.ScheduleTimeUTC.AddMinutes(30))
                && d.ScheduleTimeUTC.Day >= datainicio.Day && d.ScheduleTimeUTC.Day <= datafim.Day
                && _db.HistoricoAssistencias.Where(x => uhs.Contains(x.UhID) &&
                    x.Data.Day >= datainicio.Day && x.Data.Day <= datafim.Day
                    ).Select(v => v.Voo).Distinct().Contains(d.Voo)
                ).Count();

            int PMRDisrupcoes = _db.HistoricoAssistencias.Where(d => uhs.Contains(d.UhID) &&
                d.Data.Day >= datainicio.Day && d.Data.Day <= datafim.Day
                && disrupcoes.Select(v => v.Voo).Distinct().Contains(d.Voo)
                ).Count();

            List<Disrupcoes> dados = new()
            {
                new Disrupcoes { Nome = "Total de voos", Total = totalVoos.Count, Color = "#00c0ef", Icon = "fa fa-plane", BgColor = "bg-aqua" },
                new Disrupcoes { Nome = "Voos com assistências", Total = totalAssistencias, Color = "#00a65a", Icon = "fa fa-wheelchair", BgColor = "bg-green" },
                new Disrupcoes { Nome = "Total de disrupções", Total = totalDisrupcoes, Color = "#d33724", Icon = "fa fa-angle-left", BgColor = "bg-red" },
                new Disrupcoes { Nome = "Voos com assistências e disrupções", Total = voosDisrupcoes, Color = "#db8b0b", Icon = "fa fa-heartbeat", BgColor = "bg-yellow" },
                new Disrupcoes { Nome = "PMR afetados", Total = PMRDisrupcoes, Color = "#ff851b", Icon = "fa fa-users", BgColor = "bg-orange" }
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
    }
}
