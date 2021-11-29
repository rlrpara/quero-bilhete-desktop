using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "POLTRONA")]
    public class EmbarcacaoPoltrona : Entity
    {
        [Column("ID_EMBARCACAO", Order = 2)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChaveEstrangeira = "EMBARCACAO", UsarNaGrid = false)]
        public int CodigoEmbarcacao { get; set; }

        [Column("LETRA", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Letra { get; set; }

        [Column("INICIO", Order = 4)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int? Inicio { get; set; }

        [Column("FIM", Order = 5)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int? Fim { get; set; }

        [Column("EIXOX", Order = 6)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int? EixoX { get; set; }

        [Column("EIXOY", Order = 7)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int? EixoY { get; set; }

        [Column("TOTAL_COLUNA", Order = 8)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int? TotalColuna { get; set; }

        [Column("DIRECAO", Order = 9)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int? Alinhamento { get; set; }
    }
}
