using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "TRAJETO")]
    public class Trajeto : Entity
    {
        [Column("ID_EMBARCACAO", Order = 2)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChaveEstrangeira = "EMBARCACAO", UsarNaGrid = false)]
        public int CodigoEmbarcacao { get; set; }

        [Column("ORIGEM", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true)]
        public string Origem { get; set; }

        [Column("DESTINO", Order = 4)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true)]
        public string Destino { get; set; }
    }
}
