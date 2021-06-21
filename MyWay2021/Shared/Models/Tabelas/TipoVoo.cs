using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace MyWay2021.Shared.Models.Tabelas
{
    public class TipoVoo : IBaseEntity
    {
        [Key]
        public Guid ID { get; set; }

        private string _tipo;
        [Required(ErrorMessage = "O campo tipo é obrigatório"), Display(Name = "Tipo:")]
        [StringLength(5, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string Tipo
        {
            get => _tipo;
            set => _tipo = value?.ToUpper(CultureInfo.InvariantCulture);
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
