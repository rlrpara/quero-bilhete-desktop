using System;

namespace QueroBilhete.Service.ViewModels
{
    public class UsuarioViewModel
    {
        public int? Codigo { get; set; }
        public string Uid { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int CodigoNivelAcesso { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int? Numero { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        public bool Valido()
        {
            throw new NotImplementedException();
        }
    }
}
