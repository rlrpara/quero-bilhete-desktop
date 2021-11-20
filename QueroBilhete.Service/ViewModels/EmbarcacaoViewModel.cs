using System;

namespace QueroBilhete.Service.ViewModels
{
    public class EmbarcacaoViewModel : Entidade
    {
        public int? Codigo { get; set; }
        public int CodigoEmpresa { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        public override void Validate()
        {
            LimpaAlerta();

            if (string.IsNullOrEmpty(Nome))
                AdicionaAlerta("O NOME é obrigatório");

            if (CodigoEmpresa == 0)
                AdicionaAlerta("O Código da Empresa é obrigatório");
        }
    }
}
