using MyWay2021.Shared.Models.Tabelas;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Relatorios
{
    [Table("Staff")]
    public class StaffOnDuty
    {
        [Key]
        public Guid ID { get; set; }
        [ForeignKey("RelatorioDiario")]
        public Guid RelatorioID { get; set; }
        [Display(Name = "STAFF:")]
        public Guid FuncaoID { get; set;}
        public Funcao Funcao { get; set; }
        [Display(Name = "PNT:")]
        public int Pnt { get; set; }
        [Display(Name = "Escalados:")]
        public int Escalado { get; set; }
        [Display(Name = "Manhã:")]
        public int Manha { get; set; }
        [Display(Name = "Tarde:")]
        public int Tarde { get; set; }
        [Display(Name = "Noite:")]
        public int Noite { get; set; }
        [Display(Name = "Limitações:")]
        public string Limitacoes { get; set; }

        public virtual RelatorioDiario Relatorio { get; set; }
    }
}
