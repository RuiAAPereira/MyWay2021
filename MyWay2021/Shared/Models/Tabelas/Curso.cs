using MyWay2021.Shared.Models.Tabelas;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Tabelas
{
    public class Curso : IBaseEntity
    {
        [Key]
        public Guid CursoID { get; set; }

        [Display(Name = "Designação:", ShortName = "Curso:")]
        public string Designacao { get; set; }

        [Display(Name = "Validade:", ShortName = "Val.:")]
        public int Validade { get; set; }

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
