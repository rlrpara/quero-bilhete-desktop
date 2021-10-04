using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "USUARIO")]
    public class Login : Entity
    {
        [Column("EMAIL")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Email { get; set; }

        [Column("SENHA")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Senha { get; set; }
    }
}
