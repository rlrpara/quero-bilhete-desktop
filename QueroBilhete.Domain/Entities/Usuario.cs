using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "USUARIO")]
    public class Usuario : Entity
    {
        [Column("UID", Order = 2)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, TamanhoColunaGrid = 120)]
        public string Uid { get; set; }

        [Column("NOME", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, TamanhoColunaGrid = 500)]
        public string Nome { get; set; }

        [Column("EMAIL", Order = 4)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Email { get; set; }

        [Column("SENHA", Order = 5)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Senha { get; set; }

        [Column("ID_NIVEL_ACESSO", Order = 6)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false, ChaveEstrangeira = "NIVEL_ACESSO")]
        public int CodigoNivelAcesso { get; set; }

        [Column("CEP", Order = 7)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Cep { get; set; }

        [Column("ESTADO", Order = 8)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, TamanhoColunaGrid = 50)]
        public string Estado { get; set; }

        [Column("CIDADE", Order = 9)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, TamanhoColunaGrid = 100)]
        public string Cidade { get; set; }

        [Column("BAIRRO", Order = 10)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Bairro { get; set; }

        [Column("RUA", Order = 11)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, TamanhoColunaGrid = 150)]
        public string Rua { get; set; }

        [Column("NUMERO", Order = 12)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int? Numero { get; set; }
    }
}
