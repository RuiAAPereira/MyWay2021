using System;

namespace MyWay2021.Shared.Models.Formacoes
{
    public class ListagemAccoesFormacao
    {
        public Guid AccaoFormacaoID { get; set; }
        public string Colaborador { get; set; }
        public string Curso { get; set; }
        public DateTime DataAccao { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
