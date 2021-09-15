using QueroBilhete.Domain.Entities.BPE.Enum;

namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "emit")]
    public class IdentificacaoEmitenteBpe
    {
        [OpcoesBase(TagFilha = "CNPJ", Tamanho = 14, ZeroEsquerda = true)]
        public string CNPJ { get; set; }

        [OpcoesBase(TagFilha = "IE", Tamanho = 14)]
        public string InscricaoEstadual { get; set; }

        [OpcoesBase(TagFilha = "IEST", Tamanho = 14)]
        public string IESubstitutoTributario { get; set; }

        [OpcoesBase(TagFilha = "xNome", Tamanho = 60)]
        public string RazaoSocialEmitente { get; set; }

        [OpcoesBase(TagFilha = "xFant", Tamanho = 60)]
        public string NomeFantasiaEmitente { get; set; }

        [OpcoesBase(TagFilha = "IM", Tamanho = 15)]
        public string InscricaoMunicipal { get; set; }

        [OpcoesBase(TagFilha = "CNAE", Tamanho = 7)]
        public string CNAEFiscal { get; set; }

        [OpcoesBase(TagFilha = "CRT", Tamanho = 7)]
        public TipoRegimeTributario CodigoRegimeTributario { get; set; }
    }
}
