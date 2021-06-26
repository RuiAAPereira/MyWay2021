using MyWay2021.Shared.Models.Tabelas;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Colaboradores
{
    [Table("Colaborador")]
    public class Colaborador : IBaseEntity
    {
        [Key]
        public Guid ColaboradorID { get; set; }

        [Display(Name = "Unidade de handling:", ShortName = "UH:")]
        [ForeignKey("Uh")]
        public Guid UhID { get; set; }
        public Uh Uh { get; set; }

        [Display(Name = "Número portway:", ShortName = "Num.:")]
        public int? NumPw { get; set; }

        string _nome;
        [Required, MaxLength(150), Display(Name = "Nome:")]
        public string Nome
        {
            get => _nome;
            set => _nome = value.ToUpper();
        }

        [Display(Name = "Ativo?:")]
        public bool Ativo { get; set; } = true;

        [DataType(DataType.Date), Display(Name = "Data de Admissão:")]
        public DateTime? DataAdmissao { get; set; }
        [DataType(DataType.Date), Display(Name = "Fim de contrato:")]
        public DateTime? DataFim { get; set; }

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