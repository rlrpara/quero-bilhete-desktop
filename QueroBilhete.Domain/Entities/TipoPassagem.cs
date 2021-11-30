using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "TIPO_PASSAGEM")]
    public class TipoPassagem : Entity
    {
        [Column("DESCRICAO", Order = 2)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = true)]
        public string Descricao { get; set; }
    }
}
