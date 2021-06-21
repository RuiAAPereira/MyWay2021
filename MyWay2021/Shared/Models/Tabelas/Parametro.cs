using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Parametros")]
    public class Parametro : IBaseEntity
    {
        [Key]
        public Guid ParamID { get; set; }
        [Required, Display(Name = "Nome:")]
        public string ParamNome { get; set; }
        [Required, Display(Name = "Descrição:")]
        public string ParamDesc { get; set; }
        [Required]
        [Display(Name = "Parametro:")]
        public int ParamValue { get; set; }

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
