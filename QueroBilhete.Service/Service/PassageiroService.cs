using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class PassageiroService : BaseService, IPassageiroService
    {
        #region Construtor
        public PassageiroService(IBaseRepository repositorio)
            : base(repositorio)
        {
        }
        #endregion

        #region Métodos Privados
        private List<PassageiroViewModel> ObterPassageiros(IEnumerable<Passageiro> Passageiros)
        {
            var PassageiroModel = new List<PassageiroViewModel>();

            foreach (var item in Passageiros)
            {
                PassageiroModel.Add(new PassageiroViewModel
                {
                    Codigo = item.Codigo,
                    Nome = item.Nome,
                    RG = item.RG,
                    CPF = item.CPF,
                    Telefone = item.Telefone,
                    Celular = item.Celular,
                    Email = item.Email,
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

            return PassageiroModel;
        }

        private PassageiroViewModel ObterPassageiro(Passageiro Passageiro) => new PassageiroViewModel()
        {
            Codigo = Passageiro.Codigo,
            Nome = Passageiro.Nome,
            RG = Passageiro.RG,
            CPF = Passageiro.CPF,
            Telefone = Passageiro.Telefone,
            Celular = Passageiro.Celular,
            Email = Passageiro.Email,
            Cep = Passageiro.Cep,
            Estado = Passageiro.Estado,
            Cidade = Passageiro.Cidade,
            Bairro = Passageiro.Bairro,
            Rua = Passageiro.Rua,
            Numero = Passageiro.Numero,
            Ativo = Passageiro.Ativo,
            DataCadastro = Passageiro.DataCadastro,
            DataAtualizacao = Passageiro.DataAtualizacao
        };

        private Passageiro ObterPassageiroConvertido(PassageiroViewModel Passageiro) => new Passageiro()
        {
            Codigo = Passageiro.Codigo,
            Nome = Passageiro.Nome,
            RG = Passageiro.RG,
            CPF = Passageiro.CPF,
            Telefone = Passageiro.Telefone,
            Celular = Passageiro.Celular,
            Email = Passageiro.Email,
            Cep = Passageiro.Cep,
            Estado = Passageiro.Estado,
            Cidade = Passageiro.Cidade,
            Bairro = Passageiro.Bairro,
            Rua = Passageiro.Rua,
            Numero = Passageiro.Numero,
            Ativo = Passageiro.Ativo,
            DataCadastro = Passageiro.DataCadastro,
            DataAtualizacao = Passageiro.DataAtualizacao
        };

        #endregion

        #region Métodos Públicos
        public List<PassageiroViewModel> ObterTodos(string nome)
        {
            return ObterPassageiros(_baseRepository.BuscarTodosPorQueryGerador<Passageiro>($"NOME LIKE '%{nome}%'"));
        }

        public PassageiroViewModel CarregaPassageiro(int codigoSelecionado)
        {
            var PassageiroEncontrado = _baseRepository.BuscarPorQueryGerador<Passageiro>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado}");
            return PassageiroEncontrado != null ? ObterPassageiro(_baseRepository.BuscarPorQueryGerador<Passageiro>($"ID = {codigoSelecionado}")) : new PassageiroViewModel();
        }

        public bool AdicionarPassageiro(PassageiroViewModel Passageiro)
        {
            var PassageiroConvertido = ObterPassageiroConvertido(Passageiro);
            return _baseRepository.Adicionar(PassageiroConvertido) > 0;
        }

        public bool AtualizarPassageiro(PassageiroViewModel Passageiro)
        {
            if (_baseRepository.BuscarPorQueryGerador<Passageiro>(Passageiro.Codigo == 0 ? "" : $"ID = {Passageiro.Codigo}") == null)
                throw new ArgumentException("Usuário não Encontrado");

            var PassageiroConvertido = ObterPassageiroConvertido(Passageiro);

            return _baseRepository.Atualizar(Convert.ToInt32(PassageiroConvertido.Codigo), PassageiroConvertido) > 0;
        }

        public bool RemoverPassageiro(int codigo)
        {
            var Passageiro = _baseRepository.BuscarPorQueryGerador<Passageiro>(codigo == 0 ? "" : $"ID = {codigo}");

            if (Passageiro == null)
                throw new ArgumentException("Usuário não Encontrado");

            Passageiro.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(Passageiro.Codigo), Passageiro) > 0;
        }

        #endregion
    }
}
