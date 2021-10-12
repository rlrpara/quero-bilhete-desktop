using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class UsuarioService : BaseService, IUsuarioService
    {

        #region Construtor
        public UsuarioService(IBaseRepository repositorio)
            : base(repositorio)
        {
        }
        #endregion

        #region Métodos Privados
        private List<UsuarioViewModel> UsuarioModel(IEnumerable<Usuario> usuarios)
        {
            var usuarioModel = new List<UsuarioViewModel>();

            foreach (var item in usuarios)
            {
                usuarioModel.Add(new UsuarioViewModel
                {
                    Codigo = item.Codigo,
                    Uid = item.Uid,
                    Nome = item.Nome,
                    Email = item.Email,
                    Senha = item.Senha,
                    Cep = item.Cep,
                    Estado = item.Estado,
                    Cidade = item.Cidade,
                    Bairro = item.Bairro,
                    Rua = item.Rua,
                    Numero = item.Numero,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    DataAtualizacao = item.DataAtualizacao
                });
            }

            return usuarioModel;
        }
        #endregion

        #region Métodos Públicos
        public List<UsuarioViewModel> ObterTodos(string nome)
        {
            var usuario = _baseRepository.BuscarTodosPorQueryGerador<Usuario>($"NOME LIKE '%{nome}%'");
            return UsuarioModel(usuario);
        }
        #endregion
    }
}
