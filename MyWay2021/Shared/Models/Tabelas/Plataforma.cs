using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Plataformas")]
    public class Plataforma : IBaseEntity
    {
        [Key]
        public Guid PlataformaId { get; set; }

        [Required]
        [Display(Name = "Plataforma")]
        public string PlataformaN { get; set; }

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

        public ICollection<Stand> Stands { get; set; }
    }
}
