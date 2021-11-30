using System;

namespace QueroBilhete.Service.ViewModels
{
    public class TipoRegimeEmpresaViewModel : Entidade
    {
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        public override void Validate()
        {
            LimpaAlerta();

            if (string.IsNullOrEmpty(Descricao))
                AdicionaAlerta("A Descrição é Obrigatória");
        }
    }
}
