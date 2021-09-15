using QueroBilhete.Domain.Entities.BPE.Enum;
using System;

namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "ide")]
    public class IdentificacaoBpe
    {
        [OpcoesBase(TagFilha = "cUF", Tamanho = 2)]
        public string CodigoUfEmitente { get; set; }

        [OpcoesBase(TagFilha = "tpAmb", Tamanho = 1)]
        public int TipoAmbiente { get; set; }

        [OpcoesBase(TagFilha = "mod", Tamanho = 2)]
        public string ModeloBilhetePassagem { get; set; }

        [OpcoesBase(TagFilha = "serie", Tamanho = 3)]
        public string SerieDocumentoFiscal { get; set; }

        [OpcoesBase(TagFilha = "nBP", Tamanho = 9)]
        public string NumeroBilhetePassagem { get; set; }

        [OpcoesBase(TagFilha = "cBP", Tamanho = 8)]
        public string CodigoChaveAcesso { get; set; }

        [OpcoesBase(TagFilha = "cDV", Tamanho = 1)]
        public int CodigoChaveAcessoDV { get; set; }

        [OpcoesBase(TagFilha = "modal", Tamanho = 1)]
        public TipoModalidadeTransporte ModalidadeTransporte { get; set; }

        [OpcoesBase(TagFilha = "dhEmi", Tamanho = 1)]
        public DateTime DataHoraEmissao { get; set; }

        [OpcoesBase(TagFilha = "tpEmis", Tamanho = 1)]
        public TipoFormaEmissaoBilhete FormaEmissao { get; set; }

        [OpcoesBase(TagFilha = "verProc", Tamanho = 20)]
        public string VersaoProcessoEmissao { get; set; }

        [OpcoesBase(TagFilha = "tpBPe", Tamanho = 1)]
        public TipoBpe TipoBpe { get; set; }

        [OpcoesBase(TagFilha = "indPres", Tamanho = 1)]
        public TipoOperacaoComprador IndicadorPresencaComprador { get; set; }

        [OpcoesBase(TagFilha = "UFIni", Tamanho = 2)]
        public string UFInicioViagem { get; set; }

        [OpcoesBase(TagFilha = "cMunIni", Tamanho = 7)]
        public string CodigoMunicipioInicioViagem { get; set; }

        [OpcoesBase(TagFilha = "UFFim", Tamanho = 2)]
        public string UFFimViagem { get; set; }

        [OpcoesBase(TagFilha = "cMunFim", Tamanho = 7)]
        public string CodigoMunicipioFimViagem { get; set; }

        [OpcoesBase(TagFilha = "dhCont", Tamanho = 21)]
        public DateTime? DataHoraEntradaContigencia { get; set; }

        [OpcoesBase(TagFilha = "xJust", Tamanho = 256)]
        public string JustificativaContigencia { get; set; }
    }
}
