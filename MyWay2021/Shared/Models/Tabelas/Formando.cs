using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Formandos")]
    public class Formando : IBaseEntity
    {
        [Key]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "O campo número é obrigatório"), Display(Name = "Número:")]
        public int Numero { get; set; }

        private string _nome;
        [Required(ErrorMessage = "O campo Nome é obrigatório"), Display(Name = "Nome:")]
        [StringLength(150, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string Nome
        {
            get => _nome;
            set => _nome = value?.ToUpper(CultureInfo.InvariantCulture);
        }

        [ForeignKey("Funcao")]
        public Guid FuncaoID { get; set; }
        public Funcao Funcao { get; set; }

        [ForeignKey("Uh")]
        public Guid UhID { get; set; }
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
