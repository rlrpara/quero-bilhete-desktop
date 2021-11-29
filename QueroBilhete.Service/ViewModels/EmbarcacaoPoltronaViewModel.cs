using System;

namespace QueroBilhete.Service.ViewModels
{
    public class EmbarcacaoPoltronaViewModel : Entidade
    {
        public int? Codigo { get; set; }
        public int CodigoEmbarcacao { get; set; }
        public string Letra { get; set; }
        public int? Inicio { get; set; }
        public int? Fim { get; set; }
        public int? EixoX { get; set; }
        public int? EixoY { get; set; }
        public int? TotalColuna { get; set; }
        public int? Alinhamento { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        public override void Validate()
        {
            LimpaAlerta();

            if (CodigoEmbarcacao == 0)
                AdicionaAlerta("Código da Empresa é Obrgatório.");
        }
    }
}
