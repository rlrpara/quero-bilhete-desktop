using QueroBilhete.Infra.Utilities.ExtensionMethods;
using System;

namespace QueroBilhete.Service.ViewModels
{
    public class EmpresaViewModel : Entidade
    {
        #region [Propriedades Privadas]
        private string _razaoSocial;
        private string _cnpj;
        private string _inscricaoEstadual;
        private string _inscricaoMunicipal;
        private string _telefone;
        private string _celular;
        private string _email;
        private string _site;
        private string _logo;
        private string _cep;
        private string _estado;
        private string _cidade;
        private string _bairro;
        private string _rua;
        private int? _numero;
        #endregion


        public int? Codigo { get; set; }
        public string UId { get; set; }
        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value.RemoveAcentos(); }
        }
        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value.ApenasNumeros(); }
        }
        public string InscricaoEstadual
    {
            get { return _inscricaoEstadual; }
            set { _inscricaoEstadual = value.ApenasNumeros(); }
        }
        public string InscricaoMunicipal
        {
            get { return _inscricaoMunicipal; }
            set { _inscricaoMunicipal = value.ApenasNumeros(); }
        }
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value.ApenasNumeros(); }
        }
        public string Celular
        {
            get { return _celular; }
            set { _celular = value.ApenasNumeros(); }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value == null ? value : value.ToLower(); }
        }
        public string Site
        {
            get { return _site; }
            set { _site = value == null ? value : value.ToLower(); }
        }
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
        public string Cep
        {
            get { return _cep; }
            set { _cep = value.ApenasNumeros(); }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value.RemoveAcentos(); }
        }
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value.RemoveAcentos(); }
        }
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value.RemoveAcentos(); }
        }
        public string Rua
        {
            get { return _rua; }
            set { _rua = value.RemoveAcentos(); }
        }
        public int? Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public int CodigoRegimeEmpresa { get; set; } = 0;
        public bool Ativo { get; set; } = true;

        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        public override void Validate()
        {
            LimpaAlerta();

            if (string.IsNullOrEmpty(RazaoSocial))
                AdicionaAlerta("A RAZÃO SOCIAL é obrigatória");

            if (string.IsNullOrEmpty(Cnpj))
                AdicionaAlerta("O CNPJ é obrigatório");

            if (CodigoRegimeEmpresa == 0)
                AdicionaAlerta("Informe o Regime da Empresa");
        }
    }
}
