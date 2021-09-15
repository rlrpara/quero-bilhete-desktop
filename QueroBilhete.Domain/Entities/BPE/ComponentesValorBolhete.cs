using QueroBilhete.Domain.Entities.BPE.Enum;

namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "Comp")]
    public class ComponentesValorBolhete
    {
        [OpcoesBase(TagFilha = "tpComp", Tamanho = 2, ZeroEsquerda = true)]
        public TipoComponente TipoComponente { get; set; }

        [OpcoesBase(TagFilha = "vComp", Tamanho = 15)]
        public decimal ValorComponente { get; set; }
    }
}
