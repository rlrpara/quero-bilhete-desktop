using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "PASSAGEM")]
    public class Passagem : Entity
    {
        [Column("ID_TIPO_PASSAGEM", Order = 2)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChaveEstrangeira = "TIPO_PASSAGEM")]
        public int CodigoTipoPassagem { get; set; }

        [Column("ID_VIAGEM", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChaveEstrangeira = "VIAGEM")]
        public int CodigoViagem { get; set; }

        [Column("ID_PASSAGEIRO", Order = 4)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChaveEstrangeira = "PASSAGEIRO")]
        public int CodigoPassageiro { get; set; }

        [Column("DATA_AGENDAMENTO", Order = 5)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime? DataAgendamento { get; set; }

        [Column("DATA_REMARCACAO", Order = 6)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime? DataRemarcacao { get; set; }

        [Column("DATA_EMBARQUE", Order = 7)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime? DataEmbarque { get; set; }

        [Column("STATUS", Order = 8)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int StatusViagem { get; set; }
    }
}
