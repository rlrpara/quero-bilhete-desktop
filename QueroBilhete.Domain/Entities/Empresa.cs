using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "EMPRESA")]
    public class Empresa : Entity
    {
        [Column("UID", Order = 2)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string UId { get; set; }

        [Column("RAZAO_SOCIAL", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, TamanhoColunaGrid = 250)]
        public string RazaoSocial { get; set; }

        [Column("CNPJ", Order = 4)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Cnpj { get; set; }

        [Column("IE", Order = 5)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string InscricaoEstadual { get; set; }

        [Column("IM", Order = 6)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string InscricaoMunicipal { get; set; }

        [Column("TELEFONE", Order = 7)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Telefone { get; set; }

        [Column("CELULAR", Order = 8)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Celular { get; set; }

        [Column("EMAIL", Order = 9)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Email { get; set; }

        [Column("SITE", Order = 10)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Site { get; set; }

        [Column("LOGO", Order = 11)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Logo { get; set; }

        [Column("CEP", Order = 12)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Cep { get; set; }

        [Column("ESTADO", Order = 13)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Estado { get; set; }

        [Column("CIDADE", Order = 14)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Cidade { get; set; }

        [Column("BAIRRO", Order = 15)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Bairro { get; set; }

        [Column("RUA", Order = 16)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Rua { get; set; }

        [Column("NUMERO", Order = 17)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public int? Numero { get; set; }

        [Column("TIPO_REGIME_ID", Order = 18)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false, ChaveEstrangeira = "TIPO_REGIME_EMPRESA")]
        public int CodigoRegimeEmpresa { get; set; }
    }
}
