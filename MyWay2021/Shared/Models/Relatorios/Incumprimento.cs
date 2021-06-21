using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Relatorios
{
    [Table("Incumprimentos")]
    public class Incumprimento
    {
        [Key]
        public Guid ID { get; set; }
        [ForeignKey("RelatorioDiario")]
        public Guid RelatorioID { get; set; }
        [Display(Name = "Imputados:")]
        public int Imputados { get; set; }
        [Display(Name = "Respondidos:")]
        public int Respondidos { get; set; }
        [Display(Name = "Aceites:")]
        public int Aceites { get; set; }
        [Display(Name = "Aceites < 15 min:")]
        public int AceitesMenos15 { get; set; }
        [Display(Name = "Aceites > 15 min:")]
        public int AceitesMais15 { get; set; }

        public virtual RelatorioDiario Relatorio { get; set; }
    }
}
