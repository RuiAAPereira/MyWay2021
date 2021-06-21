using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Atrasos
{
    [Table("Motivos")]
    public class Motivo
    {
        [Key]
        public Guid MotivoId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Motivo do atraso", ShortName = "Motivo")]
        public string MotivoAtraso { get; set; }

    }
}