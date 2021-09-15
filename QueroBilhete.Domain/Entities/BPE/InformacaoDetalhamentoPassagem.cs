using System;

namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "infPassagem")]
    public class InformacaoDetalhamentoPassagem
    {
        [OpcoesBase(TagFilha = "infPassagem", Tamanho = 7)]
        public string CodigoLocalidadeOrigem { get; set; }

        [OpcoesBase(TagFilha = "xLocOrig", Tamanho = 60)]
        public string DescricaoLocalidadeOrigem { get; set; }

        [OpcoesBase(TagFilha = "cLocDest", Tamanho = 7)]
        public string CodigoLocalidadeDestino { get; set; }

        [OpcoesBase(TagFilha = "xLocDest", Tamanho = 60)]
        public string DescricaoLocalidadeDestino { get; set; }

        [OpcoesBase(TagFilha = "dhEmb", Tamanho = 21)]
        public DateTime? DataHoraEmbarque { get; set; }

        [OpcoesBase(TagFilha = "dhValidade", Tamanho = 21)]
        public DateTime? DataHoraValidadeBilhete { get; set; }
    }
}
