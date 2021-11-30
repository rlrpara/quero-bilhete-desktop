using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class TipoViagemService : BaseService, ITipoViagemService
    {
        public TipoViagemService(IBaseRepository repositorio) : base(repositorio)
        {
        }

        #region Métodos Privados
        private List<TipoViagemViewModel> ObterTipoViagems(IEnumerable<TipoViagem> TipoViagems)
        {
            var TipoViagemModel = new List<TipoViagemViewModel>();

            foreach (var item in TipoViagems)
            {
                TipoViagemModel.Add(new TipoViagemViewModel
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    DataAtualizacao = DateTime.Now
                });
            }

            return TipoViagemModel;
        }

        private TipoViagemViewModel ObterTipoViagem(TipoViagem TipoViagem) => new TipoViagemViewModel()
        {
            Codigo = TipoViagem.Codigo,
            Descricao = TipoViagem.Descricao,
            DataCadastro = TipoViagem.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        private TipoViagem ObterTipoViagemConvertido(TipoViagemViewModel tipoViagem) => new TipoViagem()
        {
            Codigo = tipoViagem.Codigo,
            Descricao = tipoViagem.Descricao,
            Ativo = tipoViagem.Ativo,
            DataCadastro = tipoViagem.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        #endregion

        #region Métodos Públicos
        public List<TipoViagemViewModel> ObterTodos(string nome)
        {
            return ObterTipoViagems(_baseRepository.BuscarTodosPorQueryGerador<TipoViagem>($"NOME LIKE '%{nome}%'"));
        }

        public TipoViagemViewModel CarregaTipoViagem(int codigoSelecionado)
        {
            var TipoViagemEncontrado = _baseRepository.BuscarPorQueryGerador<TipoViagem>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado}");
            return TipoViagemEncontrado != null ? ObterTipoViagem(_baseRepository.BuscarPorQueryGerador<TipoViagem>($"ID = {codigoSelecionado}")) : new TipoViagemViewModel();
        }

        public bool AdicionarTipoViagem(TipoViagemViewModel TipoViagem)
        {
            var TipoViagemConvertido = ObterTipoViagemConvertido(TipoViagem);
            return _baseRepository.Adicionar(TipoViagemConvertido) > 0;
        }

        public bool AtualizarTipoViagem(TipoViagemViewModel TipoViagem)
        {
            if (_baseRepository.BuscarPorQueryGerador<TipoViagem>(TipoViagem.Codigo == 0 ? "" : $"ID = {TipoViagem.Codigo}") == null)
                throw new ArgumentException("Usuário não Encontrado");

            var TipoViagemConvertido = ObterTipoViagemConvertido(TipoViagem);

            return _baseRepository.Atualizar(Convert.ToInt32(TipoViagemConvertido.Codigo), TipoViagemConvertido) > 0;
        }

        public bool RemoverTipoViagem(int codigo)
        {
            var TipoViagem = _baseRepository.BuscarPorQueryGerador<TipoViagem>(codigo == 0 ? "" : $"ID = {codigo}");

            if (TipoViagem == null)
                throw new ArgumentException("Usuário não Encontrado");

            TipoViagem.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(TipoViagem.Codigo), TipoViagem) > 0;
        }

        #endregion
    }
}
