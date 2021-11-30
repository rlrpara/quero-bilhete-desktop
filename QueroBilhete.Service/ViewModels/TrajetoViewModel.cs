using System;

namespace QueroBilhete.Service.ViewModels
{
    public class TrajetoViewModel : Entidade
    {
        public int? Codigo { get; set; }
        public int CodigoEmbarcacao { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        public override void Validate()
        {
            LimpaAlerta();

            if (string.IsNullOrEmpty(Origem))
                AdicionaAlerta("A Origem é Obrigatória");

            if (string.IsNullOrEmpty(Destino))
                AdicionaAlerta("O Destino é Obrigatório");

            if (CodigoEmbarcacao == 0)
                AdicionaAlerta("O Código da Embarcação é Obrigatório");
        }
    }
}
