using QueroBilhete.Infra.Utilities.ExtensionMethods;

namespace QueroBilhete.Service.ViewModels
{
    public class ConsultaCnpjViewModel
    {
        private string _cep;


        public string abertura { get; set; }
        public string situacao { get; set; }
        public string nome { get; set; }
        public string fantasia { get; set; }
        public string porte { get; set; }
        public string natureza_juridica { get; set; }
        public ConsultaAtividadePrincipalViewModel atividade_principal { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string municipio { get; set; }
        public string bairro { get; set; }
        public string uf { get; set; }
        public string cep
    {
            get { return _cep; }
            set { _cep = value == null ? value : value.ApenasNumeros(); }
        }
        public string data_situacao { get; set; }
        public string efr { get; set; }
        public string cnpj { get; set; }
        public string ultima_atualizacao { get; set; }
        public string status { get; set; }

    }
}
