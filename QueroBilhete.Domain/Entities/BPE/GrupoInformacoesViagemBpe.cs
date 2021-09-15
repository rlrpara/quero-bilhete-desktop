using QueroBilhete.Domain.Entities.BPE.Enum;
using System;

namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "infViagem")]
    public class GrupoInformacoesViagemBpe
    {
        [OpcoesBase(TagFilha = "cPercurso", Tamanho = 20)]
        public string CodigoPercursoViagem { get; set; }

        [OpcoesBase(TagFilha = "xPercurso", Tamanho = 100)]
        public string DescricaoPercursoViagem { get; set; }

        [OpcoesBase(TagFilha = "tpViagem", Tamanho = 1)]
        public TipoViagem TipoViagem { get; set; }

        [OpcoesBase(TagFilha = "tpServ", Tamanho = 1)]
        public TipoServico TipoServico { get; set; }

        [OpcoesBase(TagFilha = "tpAcomodacao", Tamanho = 1)]
        public TipoAcomodacao TipoAcomodacao { get; set; }

        [OpcoesBase(TagFilha = "tpTrecho", Tamanho = 1)]
        public TipoTrecho TipoTrecho { get; set; }

        [OpcoesBase(TagFilha = "dhViagem", Tamanho = 21)]
        public DateTime DataHoraReferenciaViagem { get; set; }

        [OpcoesBase(TagFilha = "dhConexao", Tamanho = 21)]
        public DateTime? DataHoraConexao { get; set; }

        [OpcoesBase(TagFilha = "prefixo", Tamanho = 20)]
        public string Prefixo { get; set; }

        [OpcoesBase(TagFilha = "poltrona", Tamanho = 3)]
        public string NumeroPoltronaAcentoCabine { get; set; }

        [OpcoesBase(TagFilha = "plataforma", Tamanho = 10)]
        public string PlataformaCarroBarcoDeEmbarque { get; set; }
    }
}
