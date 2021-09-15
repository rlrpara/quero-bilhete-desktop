namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "enderEmit")]
    public class EnderecoEmitente
    {
        [OpcoesBase(TagFilha = "xLgr", Tamanho = 60)]
        public string Logradouro { get; set; }

        [OpcoesBase(TagFilha = "nro", Tamanho = 60)]
        public string Numero { get; set; }

        [OpcoesBase(TagFilha = "xCpl", Tamanho = 60)]
        public string Complemento { get; set; }

        [OpcoesBase(TagFilha = "xBairro", Tamanho = 60)]
        public string Bairro { get; set; }

        [OpcoesBase(TagFilha = "cMun", Tamanho = 7)]
        public string CodigoMunicipio { get; set; }

        [OpcoesBase(TagFilha = "xMun", Tamanho = 60)]
        public string NomeMunicipio { get; set; }

        [OpcoesBase(TagFilha = "CEP", Tamanho = 8)]
        public string CEP { get; set; }

        [OpcoesBase(TagFilha = "UF", Tamanho = 2)]
        public string UF { get; set; }

        [OpcoesBase(TagFilha = "fone", Tamanho = 12)]
        public string Telefone { get; set; }

        [OpcoesBase(TagFilha = "email", Tamanho = 60)]
        public string EMail { get; set; }

        [OpcoesBase(TagFilha = "TAR", Tamanho = 20)]
        public string TermoAutorizacaoServicoRegular { get; set; }
    }
}
