using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Formadores")]
    public class Formador : IBaseEntity
    {
        [Key]
        public Guid FormadorID { get; set; }

        string _formadorNome;
        [Required, MaxLength(50), Display(Name = "Formador:", ShortName = "For:")]
        public string FormadorNome
        {
            get => _formadorNome;
            set => _formadorNome = value.ToUpper();
        }
        //link com tabela Uh (unidades de handling)
        [Display(Name = "Unidade de handling:", ShortName = "UH:")]
        public int UhId { get; set; }
        public Uh Uh { get; set; }

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
