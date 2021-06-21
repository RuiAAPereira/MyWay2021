using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Uhs")]
    public class Uh : IBaseEntity
    {
        [Key]
        public Guid ID { get; set; }

        private string _nome;
        [Required(ErrorMessage = "O campo uh é obrigatório"), Display(Name = "UH:")]
        [StringLength(25, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string Nome
        {
            get => _nome;
            set => _nome = value?.ToUpper(CultureInfo.InvariantCulture);
        }

        private string _iata;
        [Required(ErrorMessage = "O campo IATA é obrigatório"), Display(Name = "IATA:")]
        [StringLength(3, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string IATA
        {
            get => _iata;
            set => _iata = value?.ToUpper(CultureInfo.InvariantCulture);
        }

        private string _aeroporto;
        [Display(Name = "Código:")]
        [StringLength(25, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string CodAeroporto
        {
            get => _aeroporto;
            set => _aeroporto = value?.ToUpper(CultureInfo.InvariantCulture);
        }

        [Display(Name = "Aeroporto:")]
        [StringLength(50, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string NomeAeroporto { get; set; }

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
