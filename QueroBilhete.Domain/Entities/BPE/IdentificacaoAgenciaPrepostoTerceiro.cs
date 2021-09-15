namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "xNome")]
    public class IdentificacaoAgenciaPrepostoTerceiro
    {
        [OpcoesBase(TagFilha = "xNome", Tamanho = 60)]
        public string RazaoSocialNomeAgencia { get; set; }

        [OpcoesBase(TagFilha = "CNPJ", Tamanho = 14)]
        public string CNPJ { get; set; }
    }
}
