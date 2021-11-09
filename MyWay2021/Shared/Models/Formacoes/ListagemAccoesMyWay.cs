using System;

namespace MyWay2021.Shared.Models.Formacoes
{
    public class ListagemAccoesMyWay
    {
        public Guid FormandoID { get; set; }
        public bool Ativo { get; set; }
        public int NumPw { get; set; }
        public string Formando { get; set; }
        public DateTime? SecurityInit { get; set; }
        public DateTime? SecurityEnd { get; set; }
        public DateTime? DGRInit { get; set; }
        public DateTime? DGREnd { get; set; }
        public DateTime? BPMRInit { get; set; }
        public DateTime? BPMREnd { get; set; }
        public DateTime? SCInit { get; set; }
        public DateTime? SCEnd { get; set; }
        public DateTime? ENBInit { get; set; }
        public DateTime? ENBEnd { get; set; }
        public DateTime? SSTInit { get; set; }
        public DateTime? SSTEnd { get; set; }
        public DateTime? SMSInit { get; set; }
        public DateTime? SMSEnd { get; set; }
    }
}
