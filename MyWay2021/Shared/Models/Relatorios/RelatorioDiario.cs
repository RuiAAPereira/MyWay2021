using MyWay2021.Shared.Models.Tabelas;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Relatorios
{
    [Table("RelatoriosDiarios")]
    public class RelatorioDiario : IBaseEntity
    {
        [Key]
        public Guid ID { get; set; }

        [Display(Name = "Data:")]
        public DateTime Dia { get; set; }
        [Required(ErrorMessage = "O campo UH é obrigatório"), Display(Name = "UH:")]
        public Guid UhID { get; set; }
        public Uh Uh { get; set; }

        [Display(Name = "Partidas:")]
        public int NumPartidas { get; set; }
        [Display(Name = "Chegadas:")]
        public int NumChegadas { get; set; }

        #region BaseEntity
        [Display(Name = "Registo criado em:", ShortName = "Criado em:")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "Registo criado por:", ShortName = "Criado por:")]
        public string CreatedBy { get; set; }
        [Display(Name = "Registo atualizado em:", ShortName = "Atualizado em:")]
        public DateTime? LastUpdatedAt { get; set; }
        [Display(Name = "Registo atualizado por:", ShortName = "Atualizado por:")]
        public string LastUpdatedBy { get; set; }
        #endregion
    }
}
