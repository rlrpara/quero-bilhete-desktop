namespace QueroBilhete.Domain.Entities.BPE.Enum
{
    public enum TipoOperacaoComprador
    {
        OperacaoPresencialNaoEmbarcado = 1,
        OperacaoNaoPresencialPelaInternet = 2,
        OperacaoNaoPresencialTeleatendimento = 3,
        OperacaoComEntregaADomicilio = 4,
        OperacaoPresencialEmbarcado = 5,
        OperacaoNaoPresencialOutros = 9
    }
}
