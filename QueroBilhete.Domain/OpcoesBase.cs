using System;

namespace QueroBilhete.Domain
{
    public class OpcoesBase : Attribute
    {
        public string TagPai { get; set; }
        public string TagFilha { get; set; }
        public int Tamanho { get; set; }
        public bool ZeroEsquerda { get; set; } = false;
    }
}
