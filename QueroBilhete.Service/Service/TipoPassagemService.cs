using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class TipoPassagemService : BaseService, ITipoPassagem
    {
        public TipoPassagemService(IBaseRepository repositorio) : base(repositorio)
        {
        }

        #region Métodos Privados
        private List<TipoPassagemViewModel> ObterTipoPassagems(IEnumerable<TipoPassagem> tipoPassagems)
        {
            var tipoPassagemModel = new List<TipoPassagemViewModel>();

            foreach (var item in tipoPassagems)
            {
                tipoPassagemModel.Add(new TipoPassagemViewModel
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    DataAtualizacao = DateTime.Now
                });
            }

            return tipoPassagemModel;
        }

        private TipoPassagemViewModel ObterTipoPassagem(TipoPassagem tipoPassagem) => new TipoPassagemViewModel()
        {
            Codigo = tipoPassagem.Codigo,
            Descricao = tipoPassagem.Descricao,
            DataCadastro = tipoPassagem.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        private TipoPassagem ObterTipoPassagemConvertido(TipoPassagemViewModel tipoPassagem) => new TipoPassagem()
        {
            Codigo = tipoPassagem.Codigo,
            Descricao = tipoPassagem.Descricao,
            Ativo = tipoPassagem.Ativo,
            DataCadastro = tipoPassagem.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        #endregion

        #region Métodos Públicos
        public List<TipoPassagemViewModel> ObterTodos(string nome)
        {
            return ObterTipoPassagems(_baseRepository.BuscarTodosPorQueryGerador<TipoPassagem>($"NOME LIKE '%{nome}%'"));
        }

        public TipoPassagemViewModel CarregaTipoPassagem(int codigoSelecionado)
        {
            var tipoPassagemEncontrado = _baseRepository.BuscarPorQueryGerador<TipoPassagem>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado}");
            return tipoPassagemEncontrado != null ? ObterTipoPassagem(_baseRepository.BuscarPorQueryGerador<TipoPassagem>($"ID = {codigoSelecionado}")) : new TipoPassagemViewModel();
        }

        public bool AdicionarTipoPassagem(TipoPassagemViewModel tipoPassagem)
        {
            var tipoPassagemConvertido = ObterTipoPassagemConvertido(tipoPassagem);
            return _baseRepository.Adicionar(tipoPassagemConvertido) > 0;
        }

        public bool AtualizarTipoPassagem(TipoPassagemViewModel tipoPassagem)
        {
            if (_baseRepository.BuscarPorQueryGerador<TipoPassagem>(tipoPassagem.Codigo == 0 ? "" : $"ID = {tipoPassagem.Codigo}") == null)
                throw new ArgumentException("Tipo de Passagem não Encontrada");

            var tipoPassagemConvertido = ObterTipoPassagemConvertido(tipoPassagem);

            return _baseRepository.Atualizar(Convert.ToInt32(tipoPassagemConvertido.Codigo), tipoPassagemConvertido) > 0;
        }

        public bool RemoverTipoPassagem(int codigo)
        {
            var TipoPassagem = _baseRepository.BuscarPorQueryGerador<TipoPassagem>(codigo == 0 ? "" : $"ID = {codigo}");

            if (TipoPassagem == null)
                throw new ArgumentException("Tipo de Passagem não Encontrada");

            TipoPassagem.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(TipoPassagem.Codigo), TipoPassagem) > 0;
        }

        #endregion
    }
}
