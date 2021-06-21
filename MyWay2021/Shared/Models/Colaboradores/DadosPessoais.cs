using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Colaboradores
{
    [Table("DadosPessoais")]
    public partial class DadosPessoais : IBaseEntity
    {
        public DadosPessoais()
        {
            Emails = new HashSet<Email>();
            Telefones = new HashSet<Telefone>();
        }

        public Guid DadosPessoaisId { get; set; }
        public Guid ColaboradorId { get; set; }
        public string ColaboradorIdentificacao { get; set; }
        public DateTime? ColaboradorIdentificacaoValidade { get; set; }
        public string DadosPessoaisMorada { get; set; }

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
        public ICollection<Email> Emails { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
    }
}
