using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Piers")]
    public class Pier : IBaseEntity
    {
        [Key]
        public Guid PierID { get; set; }

        [Required]
        [Display(Name = "Pier")]
        public string PierNome { get; set; }

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
        public ICollection<Porta> Portas { get; set; }
    }
}
