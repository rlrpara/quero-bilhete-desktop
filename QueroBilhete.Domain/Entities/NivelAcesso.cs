using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table("NIVEL_ACESSO")]
    public class NivelAcesso : Entity
    {
        [Column("TITULO", Order = 2)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, TamanhoColunaGrid = 150)]
        public string Titulo { get; set; }

        [Column("DESCRICAO", Order = 3)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, TamanhoColunaGrid = 300)]
        public string Descricao { get; set; }

    }
}
