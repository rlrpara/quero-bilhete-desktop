using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "AMBIENTE_SERVIDOR")]
    public class Ambiente : Entity
    {
        [Column("NOME", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true)]
        public string Descricao { get; set; }
    }
}
