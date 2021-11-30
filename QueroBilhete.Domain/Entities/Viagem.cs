using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "VIAGEM")]
    public class Viagem : Entity
    {
        [Column("ID_TRAJETO", Order = 2)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChaveEstrangeira = "TRAJETO")]
        public int CodigoTrajeto { get; set; }

        [Column("DATA", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime Data { get; set; }

        [Column("HORA", Order = 4)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime Hora { get; set; }

        [Column("TIPO_VIAGEM_ID", Order = 5)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChaveEstrangeira = "TIPO_VIAGEM")]
        public int TipoViagem { get; set; }
    }
}
