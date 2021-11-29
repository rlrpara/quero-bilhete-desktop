using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "ALINHAMENTO")]
    public class Alinhamento : Entity
    {
        [Column("NOME", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true)]
        public string Direcao { get; set; }
    }
}
