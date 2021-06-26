using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Colaboradores
{
    [Table("FormacaoConcluida")]
    public class FormacaoConcluida : IBaseEntity
    {
        [Key]
        public Guid FCID { get; set; }
        public Guid ColaboradorID { get; set; }
        public Guid CursoID { get; set; }
        public DateTime DataAcao { get; set; }
        public DateTime DataFimAcao { get; set; }
        public DateTime DataValidade { get; set; }
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
