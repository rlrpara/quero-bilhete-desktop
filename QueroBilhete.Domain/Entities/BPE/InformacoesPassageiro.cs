using QueroBilhete.Domain.Entities.BPE.Enum;
using System;

namespace QueroBilhete.Domain.Entities.BPE
{
    [OpcoesBase(TagPai = "infPassageiro")]
    public class InformacoesPassageiro
    {
        [OpcoesBase(TagFilha = "xNome", Tamanho = 60)]
        public string NomePassageiro { get; set; }

        [OpcoesBase(TagFilha = "CPF", Tamanho = 11)]
        public string CPF { get; set; }

        [OpcoesBase(TagFilha = "tpDoc", Tamanho = 1)]
        public TipoDocumentoIndentificacao TipoDocumento { get; set; }

        [OpcoesBase(TagFilha = "nDoc", Tamanho = 20)]
        public string NumeroDocumentoPassageiro { get; set; }

        [OpcoesBase(TagFilha = "xDoc", Tamanho = 100)]
        public string DescricaoTipoDocOutros { get; set; }

        [OpcoesBase(TagFilha = "dNasc", Tamanho = 10)]
        public DateTime? DataNascimento { get; set; }

        [OpcoesBase(TagFilha = "fone", Tamanho = 12)]
        public string Telefone { get; set; }

        [OpcoesBase(TagFilha = "email", Tamanho = 60)]
        public string EMail { get; set; }
    }
}
