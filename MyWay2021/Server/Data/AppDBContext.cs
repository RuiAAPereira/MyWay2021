using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyWay2021.Server.Models.Identity;
using MyWay2021.Shared.Models;
using MyWay2021.Shared.Models.Analise;
using MyWay2021.Shared.Models.Atrasos;
using MyWay2021.Shared.Models.Colaboradores;
using MyWay2021.Shared.Models.Formacoes;
using MyWay2021.Shared.Models.Relatorios;
using MyWay2021.Shared.Models.Tabelas;
using System;
using System.Collections;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace MyWay2021.Server.Data
{
    public class AppDBContext : IdentityDbContext<AppUser, AppRole, string, IdentityUserClaim<string>,
     AppUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AppDBContext(DbContextOptions<AppDBContext> options,
            IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        #region set DbSet Analise
        public DbSet<AssistenciasPRM> AssistenciasPRMS { get; set; }
        public DbSet<DadosAeroporto> DadosAeroportos { get; set; }
        public DbSet<Escala> Escalas { get; set; }
        public DbSet<HistoricoAssistencia> HistoricoAssistencias { get; set; }
        #endregion
        #region Set DbSet Atrasos
        //public DbSet<Atraso> Atrasos { get; set; }
        //public DbSet<AtrasoCodigo> AtrasoCodigos { get; set; }
        //public DbSet<AtrasoMotivo> AtrasoMotivos { get; set; }
        //public DbSet<Codigo> Codigos { get; set; }
        //public DbSet<Motivo> Motivos { get; set; }
        //public DbSet<Supervisor> Supervisores { get; set; }
        #endregion
        #region Set DbSet Colaboradores
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<AccaoFormacao> AccoesFormacao { get; set; }
        #endregion
        #region Set DbSet Identity
        public DbSet<UserUh> UsersUhs { get; set; }
        #endregion
        #region set DbSet Relatorios
        //public DbSet<RelatorioDiario> RelatoriosDiarios { get; set; }
        //public DbSet<Incumprimento> Incumprimentos { get; set; }
        //public DbSet<Equipamento> Equipamentos { get; set; }
        //public DbSet<Sla> Slas { get; set; }
        //public DbSet<StaffOnDuty> Staff { get; set; }
        //public DbSet<TrabalhoSuplementar> HorasExtra { get; set; }
        #endregion
        #region set DbSet Tabelas
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<Pier> Piers { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<Porta> Portas { get; set; }
        public DbSet<Stand> Stands { get; set; }
        public DbSet<TipoAssistencia> TiposAssistencia { get; set; }
        public DbSet<TipoMensagem> TiposMensagem { get; set; }
        public DbSet<TipoVoo> TipoVoos { get; set; }
        public DbSet<Uh> Uhs { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<UserUh>()
                .HasKey(e => new { e.UserId, e.UhID });
            builder.Entity<IdentityUserToken<string>>()
                .HasKey(e => new { e.UserId });
            builder.Entity<IdentityUserLogin<string>>()
                .HasKey(e => new { e.UserId });
            builder.Entity<AppUserRole>()
                .HasKey(e => new { e.UserId, e.RoleId });
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int SaveChanges()
        {
            OnBeforeSaving();
            return base.SaveChanges();
        }

        private void OnBeforeSaving()
        {
            IEnumerable entries = ChangeTracker.Entries();
            foreach (EntityEntry entry in entries)
            {
                if (entry.Entity is IBaseEntity baseEntity)
                {
                    DateTime now = DateTime.UtcNow;
                    string user;
                    try
                    {
                        user = _httpContextAccessor.HttpContext.User.Identity.Name;
                    }
                    catch (NullReferenceException)
                    {
                        user = "SISTEMA";
                    }

                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            baseEntity.LastUpdatedAt = now;
                            baseEntity.LastUpdatedBy = user;
                            break;

                        case EntityState.Added:
                            baseEntity.CreatedAt = now;
                            baseEntity.CreatedBy = user;
                            baseEntity.LastUpdatedAt = null;
                            baseEntity.LastUpdatedBy = null;
                            break;
                    }
                }
            }
        }
    }
}
