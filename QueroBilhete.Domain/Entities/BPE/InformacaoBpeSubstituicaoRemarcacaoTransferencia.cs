using QueroBilhete.Domain.Entities.BPE.Enum;

namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "")]
    public class InformacaoBpeSubstituicaoRemarcacaoTransferencia
    {
        [OpcoesBase(TagFilha = "chBPe", Tamanho = 44)]
        public string ChaveBpeSubstituido { get; set; }

        [OpcoesBase(TagFilha = "tpSub", Tamanho = 1)]
        public TipoSubstituicao TipoSubstituicao { get; set; }
    }
}
