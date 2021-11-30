using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class TrajetoService : BaseService, ITrajeto
    {
        public TrajetoService(IBaseRepository repositorio) : base(repositorio)
        {
        }

        #region Métodos Privados
        private List<TrajetoViewModel> ObterTrajetos(IEnumerable<Trajeto> trajetos)
        {
            var trajetoModel = new List<TrajetoViewModel>();

            foreach (var item in trajetos)
            {
                trajetoModel.Add(new TrajetoViewModel
                {
                    Codigo = item.Codigo,
                    CodigoEmbarcacao = item.CodigoEmbarcacao,
                    Origem = item.Origem,
                    Destino = item.Destino,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    DataAtualizacao = DateTime.Now
                });
            }

            return trajetoModel;
        }

        private TrajetoViewModel ObterTrajeto(Trajeto trajeto) => new TrajetoViewModel()
        {
            Codigo = trajeto.Codigo,
            CodigoEmbarcacao = trajeto.CodigoEmbarcacao,
            Origem = trajeto.Origem,
            Destino = trajeto.Destino,
            DataCadastro = trajeto.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        private Trajeto ObterTrajetoConvertido(TrajetoViewModel trajeto) => new Trajeto()
        {
            Codigo = trajeto.Codigo,
            CodigoEmbarcacao = trajeto.CodigoEmbarcacao,
            Origem = trajeto.Origem,
            Destino = trajeto.Destino,
            Ativo = trajeto.Ativo,
            DataCadastro = trajeto.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        #endregion

        #region Métodos Públicos
        public List<TrajetoViewModel> ObterTodos(string nome)
        {
            return ObterTrajetos(_baseRepository.BuscarTodosPorQueryGerador<Trajeto>($"NOME LIKE '%{nome}%'"));
        }

        public TrajetoViewModel CarregaTrajeto(int codigoSelecionado)
        {
            var trajetoEncontrado = _baseRepository.BuscarPorQueryGerador<Trajeto>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado}");
            return trajetoEncontrado != null ? ObterTrajeto(_baseRepository.BuscarPorQueryGerador<Trajeto>($"ID = {codigoSelecionado}")) : new TrajetoViewModel();
        }

        public bool AdicionarTrajeto(TrajetoViewModel trajeto)
        {
            var trajetoConvertido = ObterTrajetoConvertido(trajeto);
            return _baseRepository.Adicionar(trajetoConvertido) > 0;
        }

        public bool AtualizarTrajeto(TrajetoViewModel trajeto)
        {
            if (_baseRepository.BuscarPorQueryGerador<Trajeto>(trajeto.Codigo == 0 ? "" : $"ID = {trajeto.Codigo}") == null)
                throw new ArgumentException("Trajeto não Encontrado");

            var trajetoConvertido = ObterTrajetoConvertido(trajeto);

            return _baseRepository.Atualizar(Convert.ToInt32(trajetoConvertido.Codigo), trajetoConvertido) > 0;
        }

        public bool RemoverTrajeto(int codigo)
        {
            var trajeto = _baseRepository.BuscarPorQueryGerador<Trajeto>(codigo == 0 ? "" : $"ID = {codigo}");

            if (trajeto == null)
                throw new ArgumentException("Trajeto não Encontrado");

            trajeto.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(trajeto.Codigo), trajeto) > 0;
        }

        #endregion
    }
}
