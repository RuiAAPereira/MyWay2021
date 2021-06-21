using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Salas")]
    public class Sala : IBaseEntity
    {
        [Key]
        public Guid SalaID { get; set; }

        string _salaNome;
        [Required, MaxLength(50), Display(Name = "Sala:", ShortName = "S:")]
        public string SalaNome
        {
            get => _salaNome;
            set => _salaNome = value.ToUpper();
        }

        [Required, Display(Name = "Capacidade:")]
        public int Capacidade { get; set; }

        //link com a tabela UH (unidades de handling)
        public int UhID { get; set; }
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
