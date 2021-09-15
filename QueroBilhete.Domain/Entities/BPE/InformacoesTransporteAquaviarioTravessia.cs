using QueroBilhete.Domain.Entities.BPE.Enum;

namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "infTravessia")]
    public class InformacoesTransporteAquaviarioTravessia
    {
        [OpcoesBase(TagFilha = "tpVeiculo", Tamanho = 2, ZeroEsquerda = true)]
        public TipoVeiculoTransportado TipoVeiculoTransportado { get; set; }

        [OpcoesBase(TagFilha = "sitVeiculo", Tamanho = 2)]
        public TipoSituacaoVeiculoTransportado SituacaoVeiculoTransportado { get; set; }
    }
}
