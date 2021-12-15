using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "CAIXA")]
    public class Caixa : Entity
    {
        [Column("DATA_ABERTURA", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true)]
        public DateTime DataAbertura { get; set; }

        [Column("USUARIO_ABERTURA_ID", Order = 4)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true, ChaveEstrangeira = "USUARIO")]
        public int CodigoUsuarioAbertura { get; set; }

        [Column("VALOR_ABERTURA", Order = 5)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true)]
        public decimal ValorAbertura { get; set; }

        [Column("DATA_ENCERRAMENTO", Order = 6)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true)]
        public DateTime DataEncerramento { get; set; }

        [Column("USUARIO_ENCERRAMENTO_ID", Order = 7)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true, ChaveEstrangeira = "USUARIO")]
        public int CodigoUsuariEncerramento { get; set; }
    }
}
