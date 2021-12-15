using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class EmbarcacaoService : BaseService, IEmbarcacaoService
    {
        public EmbarcacaoService(IBaseRepository repositorio)
            : base(repositorio)
        {
        }

        #region Métodos Privados
        private List<EmbarcacaoViewModel> ObterEmbarcacoes(IEnumerable<Embarcacao> Embarcacaos)
        {
            var EmbarcacaoModel = new List<EmbarcacaoViewModel>();

            foreach (var item in Embarcacaos)
            {
                EmbarcacaoModel.Add(new EmbarcacaoViewModel
                {
                    Codigo = item.Codigo,
                    CodigoEmpresa = item.CodigoEmpresa,
                    Nome = item.Nome,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    DataAtualizacao = DateTime.Now
                });
            }

            return EmbarcacaoModel;
        }

        private EmbarcacaoViewModel ObterEmbarcacao(Embarcacao Embarcacao) => new EmbarcacaoViewModel()
        {
            Codigo = Embarcacao.Codigo,
            CodigoEmpresa = Embarcacao.CodigoEmpresa,
            Nome = Embarcacao.Nome,
            Ativo = Embarcacao. Ativo,
            DataCadastro = Embarcacao.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        private Embarcacao ObterEmbarcacaoConvertido(EmbarcacaoViewModel Embarcacao) => new Embarcacao()
        {
            Codigo = Embarcacao.Codigo,
            CodigoEmpresa = Embarcacao.CodigoEmpresa,
            Nome = Embarcacao.Nome,
            Ativo = Embarcacao.Ativo,
            DataCadastro = Embarcacao.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        #endregion

        #region Métodos Públicos
        public List<EmbarcacaoViewModel> ObterTodos(string sqlWhere)
        {
            return ObterEmbarcacoes(_baseRepository.BuscarTodosPorQueryGerador<Embarcacao>(sqlWhere));
        }

        public EmbarcacaoViewModel CarregaEmbarcacao(int codigoSelecionado)
        {
            var EmbarcacaoEncontrada = _baseRepository.BuscarPorQueryGerador<Embarcacao>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado} AND ATIVO = 1");
            return EmbarcacaoEncontrada != null ? ObterEmbarcacao(_baseRepository.BuscarPorQueryGerador<Embarcacao>($"ID = {codigoSelecionado}")) : new EmbarcacaoViewModel();
        }

        public bool AdicionarEmbarcacao(EmbarcacaoViewModel embarcacao)
        {
            var EmbarcacaoConvertido = ObterEmbarcacaoConvertido(embarcacao);
            return _baseRepository.Adicionar(EmbarcacaoConvertido) > 0;
        }

        public bool AtualizarEmbarcacao(EmbarcacaoViewModel Embarcacao)
        {
            if (_baseRepository.BuscarPorQueryGerador<Embarcacao>(Embarcacao.Codigo == 0 ? "" : $"ID = {Embarcacao.Codigo}") == null)
                throw new ArgumentException("Usuário não Encontrado");

            var EmbarcacaoConvertido = ObterEmbarcacaoConvertido(Embarcacao);

            return _baseRepository.Atualizar(Convert.ToInt32(EmbarcacaoConvertido.Codigo), EmbarcacaoConvertido) > 0;
        }

        public bool RemoverEmbarcacao(int codigo)
        {
            var Embarcacao = _baseRepository.BuscarPorQueryGerador<Embarcacao>(codigo == 0 ? "" : $"ID = {codigo}");

            if (Embarcacao == null)
                throw new ArgumentException("Usuário não Encontrado");

            Embarcacao.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(Embarcacao.Codigo), Embarcacao) > 0;
        }

        #endregion
    }
}
