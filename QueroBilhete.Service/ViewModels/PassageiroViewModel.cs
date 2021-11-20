using QueroBilhete.Infra.Utilities.ExtensionMethods;
using System;

namespace QueroBilhete.Service.ViewModels
{
    public class PassageiroViewModel : Entidade
    {
        private string _nome;
        private string _rg;
        private string _cpf;
        private string _telefone;
        private string _celular;
        private string _cep;
        private string _estado;
        private string _cidade;
        private string _bairro;
        private string _rua;

        public int? Codigo { get; set; }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value.RemoveAcentos(); }
        }
        public string RG
        {
            get { return _rg; }
            set { _rg = value.ApenasNumeros(); }
        }
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value.ApenasNumeros(); }
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
        public string Email { get; set; }
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
            set { _rua = value; }
        }
        public int? Numero { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        public override void Validate()
        {
            LimpaAlerta();

            if (string.IsNullOrEmpty(Nome))
                AdicionaAlerta("O Nome é Obrigatório");

            if (string.IsNullOrEmpty(CPF) || CPF.Trim().Length != 11)
                AdicionaAlerta("O CPF é Obrigatório");
        }
    }
}
