using MyWay2021.Shared.Models.Colaboradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyWay2021.Shared.Models.Tabelas
{
    [Table("Equipas")]
    public class Equipa : IBaseEntity
    {
        [Key]
        public Guid EquipaId { get; set; }

        string _equipaNome;
        [Required, MaxLength(5), Display(Name = "Equipa:")]
        public string EquipaNome
        {
            get => _equipaNome;
            set => _equipaNome = value.ToUpper();
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

        public ICollection<Colaborador> Colaboradores { get; set; }
    }
}
