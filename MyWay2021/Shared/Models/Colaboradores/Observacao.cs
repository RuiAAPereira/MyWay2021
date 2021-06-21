using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Colaboradores
{
    [Table("Observacoes")]
    public partial class Observacao : IBaseEntity
    {
        public Guid ObservacaoId { get; set; }
        public Guid ColaboradorId { get; set; }
        public string ObservacaoTitulo { get; set; }
        public string Texto { get; set; }

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

        public Colaborador Colaborador { get; set; }
    }
}
