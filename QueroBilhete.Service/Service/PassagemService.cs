using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class PassagemService : BaseService, IPassagemService
    {
        public PassagemService(IBaseRepository repositorio) : base(repositorio)
        {
        }

        #region Métodos Privados
        private List<PassagemViewModel> ObterPassagems(IEnumerable<Passagem> passagens)
        {
            var passagemModel = new List<PassagemViewModel>();

            foreach (var item in passagens)
            {
                passagemModel.Add(new PassagemViewModel
                {
                    Codigo = item.Codigo,
                    CodigoTipoPassagem = item.CodigoTipoPassagem,
                    CodigoPassageiro = item.CodigoPassageiro,
                    CodigoViagem = item.CodigoViagem,
                    DataAgendamento = item.DataAgendamento,
                    DataEmbarque = item.DataEmbarque,
                    DataRemarcacao = item.DataRemarcacao,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    DataAtualizacao = DateTime.Now
                });
            }

            return passagemModel;
        }

        private PassagemViewModel ObterPassagem(Passagem passagem) => new PassagemViewModel()
        {
            Codigo = passagem.Codigo,
            CodigoTipoPassagem = passagem.CodigoTipoPassagem,
            CodigoPassageiro = passagem.CodigoPassageiro,
            CodigoViagem = passagem.CodigoViagem,
            DataAgendamento = passagem.DataAgendamento,
            DataEmbarque = passagem.DataEmbarque,
            DataRemarcacao = passagem.DataRemarcacao,
            DataCadastro = passagem.DataCadastro,
            Ativo = passagem.Ativo,
            DataAtualizacao = DateTime.Now
        };

        private Passagem ObterPassagemConvertido(PassagemViewModel passagem) => new Passagem()
        {
            Codigo = passagem.Codigo,
            CodigoTipoPassagem = passagem.CodigoTipoPassagem,
            CodigoPassageiro = passagem.CodigoPassageiro,
            CodigoViagem = passagem.CodigoViagem,
            DataAgendamento = passagem.DataAgendamento,
            DataEmbarque = passagem.DataEmbarque,
            DataRemarcacao = passagem.DataRemarcacao,
            Ativo = passagem.Ativo,
            DataCadastro = passagem.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        #endregion

        #region Métodos Públicos
        public List<PassagemViewModel> ObterTodos(string nome)
        {
            return ObterPassagems(_baseRepository.BuscarTodosPorQueryGerador<Passagem>($"NOME LIKE '%{nome}%'"));
        }

        public PassagemViewModel CarregaPassagem(int codigoSelecionado)
        {
            var passagemEncontrado = _baseRepository.BuscarPorQueryGerador<Passagem>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado}");
            return passagemEncontrado != null ? ObterPassagem(_baseRepository.BuscarPorQueryGerador<Passagem>($"ID = {codigoSelecionado}")) : new PassagemViewModel();
        }

        public bool AdicionarPassagem(PassagemViewModel passagem)
        {
            var passagemConvertido = ObterPassagemConvertido(passagem);
            return _baseRepository.Adicionar(passagemConvertido) > 0;
        }

        public bool AtualizarPassagem(PassagemViewModel passagem)
        {
            if (_baseRepository.BuscarPorQueryGerador<Passagem>(passagem.Codigo == 0 ? "" : $"ID = {passagem.Codigo}") == null)
                throw new ArgumentException("Passagem não Encontrada");

            var passagemConvertido = ObterPassagemConvertido(passagem);

            return _baseRepository.Atualizar(Convert.ToInt32(passagemConvertido.Codigo), passagemConvertido) > 0;
        }

        public bool RemoverPassagem(int codigo)
        {
            var passagem = _baseRepository.BuscarPorQueryGerador<Passagem>(codigo == 0 ? "" : $"ID = {codigo}");

            if (passagem == null)
                throw new ArgumentException("Passagem não Encontrada");

            passagem.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(passagem.Codigo), passagem) > 0;
        }

        #endregion
    }
}
