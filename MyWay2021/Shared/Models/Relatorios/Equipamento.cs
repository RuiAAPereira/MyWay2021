using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Relatorios
{
    [Table("Equipamentos")]
    public class Equipamento
    {
        [Key]
        public Guid ID { get; set; }
        [ForeignKey("RelatorioDiario")]
        public Guid RelatorioID { get; set; }

        [Display(Name = "VTA:")]
        public int Vta { get; set; }
        [Display(Name = "Ambulift:")]
        public int Ambulift { get; set; }
        [Display(Name = "VE:")]
        public int VeiculoEletrico { get; set; }
        [Display(Name = "VTA operacional:")]
        public int VtaOp { get; set; }
        [Display(Name = "Ambulift operacional:")]
        public int AmbuliftOp { get; set; }
        [Display(Name = "VE operacional:")]
        public int VeiculoEletricoOp { get; set; }

        public virtual RelatorioDiario Relatorio { get; set; }
    }
}
