using AutoMapper;
using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
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
        private List<UsuarioViewModel> ObterUsuarios(IEnumerable<Usuario> usuarios)
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

        private UsuarioViewModel ObterUsuario(Usuario usuario) => new UsuarioViewModel()
        {
            Codigo = usuario.Codigo,
            Uid = usuario.Uid,
            Nome = usuario.Nome,
            Email = usuario.Email,
            Senha = usuario.Senha,
            CodigoNivelAcesso = usuario.CodigoNivelAcesso,
            Cep = usuario.Cep,
            Estado = usuario.Estado,
            Cidade = usuario.Cidade,
            Bairro = usuario.Bairro,
            Rua = usuario.Rua,
            Numero = usuario.Numero,
            Ativo = usuario.Ativo,
            DataCadastro = usuario.DataCadastro,
            DataAtualizacao = usuario.DataAtualizacao
        };

        private Usuario ObterUsuarioConvertido(UsuarioViewModel usuario) => new Usuario()
        {
            Codigo = usuario.Codigo,
            Uid = usuario.Uid,
            Nome = usuario.Nome,
            Email = usuario.Email,
            Senha = usuario.Senha,
            CodigoNivelAcesso = usuario.CodigoNivelAcesso,
            Cep = usuario.Cep,
            Estado = usuario.Estado,
            Cidade = usuario.Cidade,
            Bairro = usuario.Bairro,
            Rua = usuario.Rua,
            Numero = usuario.Numero,
            Ativo = usuario.Ativo,
            DataCadastro = usuario.DataCadastro,
            DataAtualizacao = usuario.DataAtualizacao
        };

        #endregion

        #region Métodos Públicos
        public List<UsuarioViewModel> ObterTodos(string nome)
        {
            return ObterUsuarios(_baseRepository.BuscarTodosPorQueryGerador<Usuario>($"NOME LIKE '%{nome}%'"));
        }

        public UsuarioViewModel CarregaUsuario(int codigoSelecionado)
        {
            var usuarioEncontrado = _baseRepository.BuscarPorQueryGerador<Usuario>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado}");
            return usuarioEncontrado != null ? ObterUsuario(_baseRepository.BuscarPorQueryGerador<Usuario>($"ID = {codigoSelecionado}")) : new UsuarioViewModel();
        }

        public bool AdicionarUsuario(UsuarioViewModel usuario)
        {
            var usuarioConvertido = ObterUsuarioConvertido(usuario);
            return _baseRepository.Adicionar(usuarioConvertido) > 0;
        }

        public bool AtualizarUsuario(UsuarioViewModel usuario)
        {
            if (_baseRepository.BuscarPorQueryGerador<Usuario>(usuario.Codigo == 0 ? "" : $"ID = {usuario.Codigo}") == null)
                throw new ArgumentException("Usuário não Encontrado");

            var usuarioConvertido = ObterUsuarioConvertido(usuario);

            return _baseRepository.Atualizar(Convert.ToInt32(usuarioConvertido.Codigo), usuarioConvertido) > 0;
        }

        public bool RemoverUsuario(int codigo)
        {
            var usuario = _baseRepository.BuscarPorQueryGerador<Usuario>(codigo == 0 ? "" : $"ID = {codigo}");

            if (usuario == null)
                throw new ArgumentException("Usuário não Encontrado");

            usuario.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(usuario.Codigo), usuario) > 0;
        }

        #endregion
    }
}
;