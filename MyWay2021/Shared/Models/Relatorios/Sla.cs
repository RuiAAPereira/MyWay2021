using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Relatorios
{
    [Table("Slas")]
    public class Sla
    {
        [Key]
        public Guid ID { get; set; }
        [ForeignKey("RelatorioDiario")]
        public Guid RelatorioID { get; set; }

        //PARTIDAS COM PRÉ-NOTIFICAÇÃO (>=36H)
        [Display(Name = "<=10 min (80%)")]
        public int PartidaCpnMenos10 { get; set; }
        [Display(Name = ">10 e <=20 min (90%)")]
        public int PartidaCpnMais10Menos20 { get; set; }
        [Display(Name = ">20 e <=30 min (100%)")]
        public int PartidaCpnMais20Menos30 { get; set; }
        [Display(Name = ">30 min (0%)")]
        public int PartidaCpnMais30 { get; set; }
        //CHEGADAS COM PRÉ-NOTIFICAÇÃO (>=36H)
        [Display(Name = "<=5 min (80%)")]
        public int ChegadaCpnMenos5 { get; set; }
        [Display(Name = "> 5 e <=10 min(90 %)")]
        public int ChegadaCpnMais5Menos10 { get; set; }
        [Display(Name = ">10 e <=20 min (100%)")]
        public int ChegadaCpnMais10Menos20 { get; set; }
        [Display(Name = ">20 min (0%)")]
        public int ChegadaCpnMais20 { get; set; }
        //PARTIDAS SEM PRÉ-NOTIFICAÇÃO (<36H)
        [Display(Name = "<=25 min (80%)")]
        public int PartidaSpnMenos25 { get; set; }
        [Display(Name = ">25 e <=35 min (90%)")]
        public int PartidaSpnMais25Menos35 { get; set; }
        [Display(Name = ">35 e <=45 min (100%)")]
        public int PartidaSpnMais35Menos45 { get; set; }
        [Display(Name = ">45 min (0%)")]
        public int PartidaSpnMais45 { get; set; }
        //CHEGADAS COM PRÉ-NOTIFICAÇÃO (>= 90 min e <36H)
        [Display(Name = "<=15 min (80%)")]
        public int ChegadaSpnMenos15 { get; set; }
        [Display(Name = ">15 e <=20 min (90%)")]
        public int ChegadaSpnMais15Menos20 { get; set; }
        [Display(Name = ">20 e <=30 min (100%)")]
        public int ChegadaSpnMais20Menos30 { get; set; }
        [Display(Name = ">30 min (0%)")]
        public int ChegadaSpnMais30 { get; set; }
        //SEM PRÉ-NOTIFICAÇÃO (<90 min)
        [Display(Name = "<=25 min (80%)")]
        public int Menos90MinMenos25 { get; set; }
        [Display(Name = ">25 e <=35 min (90%)")]
        public int Menos90MinMais25Menos35 { get; set; }
        [Display(Name = ">35 e <=45 min (100%)")]
        public int Menos90MinMais35Menos45 { get; set; }
        [Display(Name = ">45 min (0%)")]
        public int Menos90MinMais45 { get; set; }

        public virtual RelatorioDiario Relatorio { get; set; }
    }
}
