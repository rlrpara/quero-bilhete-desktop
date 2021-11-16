using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    public class Entity
    {
        [Key]
        [Column("ID", Order = 0)]
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int? Codigo { get; set; }

        [Column("ATIVO", Order = 97)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public bool Ativo { get; set; }

        [Column("DATA_CADASTRO", Order = 98)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Column("DATA_ATUALIZACAO", Order = 99)]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;
    }
}
