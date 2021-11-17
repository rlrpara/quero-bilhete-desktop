using System;

namespace QueroBilhete.Domain.Entities
{
    public class OpcoesBase : Attribute
    {
        public bool ChavePrimaria { get; set; }
        public bool UsarNoBancoDeDados { get; set; }
        public bool UsarParaBuscar { get; set; }
        public bool UsarNaGrid { get; set; } = true;
        public int TamanhoColunaGrid { get; set; } = 80;
        public string ChaveEstrangeira { get; set; }
    }
}
