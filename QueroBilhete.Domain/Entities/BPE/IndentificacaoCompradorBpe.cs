namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "comp")]
    class IndentificacaoCompradorBpe
    {
        [OpcoesBase(TagFilha = "xNome", Tamanho = 60)]
        public string RazaoSocialNomeComprador { get; set; }

        [OpcoesBase(TagFilha = "CNPJ", Tamanho = 14, ZeroEsquerda = true)]
        public string CNPJ { get; set; }

        [OpcoesBase(TagFilha = "CPF", Tamanho = 11, ZeroEsquerda = true)]
        public string CPF { get; set; }

        [OpcoesBase(TagFilha = "idEstrangeiro", Tamanho = 1)]
        public string IdentificadorCompradorEstrangeiro { get; set; }

        [OpcoesBase(TagFilha = "IE", Tamanho = 14)]
        public string InscricaoEstadual { get; set; }
    }
}
