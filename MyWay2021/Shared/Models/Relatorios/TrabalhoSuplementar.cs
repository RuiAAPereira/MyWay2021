using MyWay2021.Shared.Models.Tabelas;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Relatorios
{
    [Table("HorasExtra")]
    public class TrabalhoSuplementar
    {
        [Key]
        public Guid ID { get; set; }
        [ForeignKey("RelatorioDiario")]
        public Guid RelatorioID { get; set; }
        [Display(Name = "STAFF:")]
        public Guid FuncaoID { get; set; }
        public Funcao Funcao { get; set; }
        [Display(Name = "PNT:")]
        public int Pnt { get; set; }
        [Display(Name = "1ª hora:")]
        public double PrimeiraHora { get; set; }
        [Display(Name = "2ª ou mais horas:")]
        public double SegundaHora { get; set; }
        [Display(Name = "DC:")]
        public double DC { get; set; }
        [Display(Name = "DS:")]
        public double DS { get; set; }
        [Display(Name = "Justificação:")]
        public string Justificacao { get; set; }
        public virtual RelatorioDiario Relatorio { get; set; }
    }
}
