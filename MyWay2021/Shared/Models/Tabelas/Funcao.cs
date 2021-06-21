using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Funcoes")]
    public class Funcao : IBaseEntity
    {
        [Key]
        public Guid ID { get; set; }

        private string _funcao;
        [Required(ErrorMessage = "O campo função é obrigatório"), Display(Name = "Função:")]
        [StringLength(25, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string Nome
        {
            get => _funcao;
            set => _funcao = value?.ToUpper(CultureInfo.InvariantCulture);
        }

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
