using QueroBilhete.Domain.Entities.BPE.Enum;

namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "infValorBPe")]
    public class InformacoesValoresBilhetePassagem
    {
        [OpcoesBase(TagFilha = "vBP", Tamanho = 15)]
        public decimal ValorBilhete { get; set; }

        [OpcoesBase(TagFilha = "vDesconto", Tamanho = 15)]
        public decimal ValorDesconto { get; set; }

        [OpcoesBase(TagFilha = "vPgto", Tamanho = 15)]
        public decimal ValorPago { get; set; }

        [OpcoesBase(TagFilha = "vTroco", Tamanho = 15)]
        public decimal ValorTroco { get; set; }

        [OpcoesBase(TagFilha = "tpDesconto", Tamanho = 2)]
        public TipoDescontoBpe TipoDescontoBpe { get; set; }

        [OpcoesBase(TagFilha = "xDesconto", Tamanho = 100)]
        public string DescricaoTipoDesconto { get; set; }

        [OpcoesBase(TagFilha = "cDesconto", Tamanho = 20)]
        public string CodigoDescontoConcedido { get; set; }
    }
}
