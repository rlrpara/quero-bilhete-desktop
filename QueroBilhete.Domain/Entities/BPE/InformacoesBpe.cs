namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "infBPe")]
    public class InformacoesBpe
    {
        [OpcoesBase(TagFilha = "versao", Tamanho = 1)]
        public string Versao { get; set; }
        [OpcoesBase(TagFilha = "id", Tamanho = 1)]
        public string IdentificadorTagAssinada { get; set; }
    }
}
