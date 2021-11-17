using QueroBilhete.Infra.Utilities.ExtensionMethods;
using System;

namespace QueroBilhete.Service.ViewModels
{
    public class UsuarioViewModel : Entidade
    {
        private string _nome;
        private string _email;
        private string _cep;
        private string _estado;
        private string _cidade;
        private string _bairro;
        private string _rua;


        public int? Codigo { get; set; }
        public string Uid { get; set; }
        public string  Nome
        {
            get { return _nome; }
            set { _nome = value.RemoveAcentos(); }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value.ToLower(); }
        }
        public string Senha { get; set; }
        public int CodigoNivelAcesso { get; set; }
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
            set { _bairro = value.RemoveAcentos() ; }
        }

        public string Rua
        {
            get { return _rua; }
            set { _rua = value.RemoveAcentos() ; }
        }

        public int? Numero { get; set; }

        public bool Ativo { get; set; } = true;

        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        public override void Validate()
        {
            LimpaAlerta();

            if (string.IsNullOrEmpty(Nome))
                AdicionaAlerta("O NOME é obrigatório");

            if (string.IsNullOrEmpty(Email))
                AdicionaAlerta("O E-MAIL é obrigatório");

            if (string.IsNullOrEmpty(Senha))
                AdicionaAlerta("A SENHA é obrigatório");

            if (CodigoNivelAcesso == 0)
                AdicionaAlerta("O NÍVEL DE ACESSO é obrigatório");

            if (Cep == null || Cep.Length > 9)
                AdicionaAlerta("O CEP tem limite máximo de 9 caracteres");

            if (Estado == null || Estado.Length > 9)
                AdicionaAlerta("O Estado tem limite máximo de 2 caracteres");
        }
    }
}
