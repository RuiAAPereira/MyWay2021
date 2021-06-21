using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Atrasos
{
    [Table("Codigos")]
    public class Codigo
    {
        [Key]
        public Guid CodigoId { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Código Atraso", ShortName = "Cód.")]
        public string CodigoAtraso { get; set; }

    }
}
