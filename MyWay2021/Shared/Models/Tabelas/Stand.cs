using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Stands")]
    public class Stand : IBaseEntity
    {
        [Key]
        public Guid StandId { get; set; }

        [Required]
        [Range(Int32.MaxValue, 999)]
        [Display(Name = "Stand")]
        public int StandN { get; set; }
        public bool Remoto { get; set; }

        [Display(Name = "Plataforma:")]
        public Guid PlataformaId { get; set; }
        public Plataforma Plataforma { get; set; }

        [Display(Name = "Pier")]
        public Guid PierID { get; set; }
        public Pier Pier { get; set; }

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
