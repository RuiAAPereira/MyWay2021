using MyWay2021.Shared.Models.Colaboradores;
using MyWay2021.Shared.Models.Tabelas;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Formacoes
{
    [Table("AccaoFormacao")]
    public class AccaoFormacao : IBaseEntity
    {
        [Key]
        public Guid AccaoFormacaoID { get; set; }

        [Display(Name = "Colaborador:")]
        public Guid ColaboradorID { get; set; }
        public Colaborador Colaborador { get; set; }

        [Display(Name = "Curso:")]
        public Guid CursoID { get; set; }
        public Curso Curso { get; set; }

        [DataType(DataType.Date), Display(Name = "Data da Acção:")]
        public DateTime DataAccao { get; set; }

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
