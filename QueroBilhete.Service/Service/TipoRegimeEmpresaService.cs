using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class TipoRegimeEmpresaervice : BaseService, ITipoRegimeEmpresa
    {
        public TipoRegimeEmpresaervice(IBaseRepository repositorio) : base(repositorio)
        {
        }

        #region Métodos Privados
        private List<TipoRegimeEmpresaViewModel> ObterTipoRegimeEmpresa(IEnumerable<TipoRegimeEmpresa> tipoRegimeEmpresa)
        {
            var tipoRegimeEmpresaModel = new List<TipoRegimeEmpresaViewModel>();

            foreach (var item in tipoRegimeEmpresa)
            {
                tipoRegimeEmpresaModel.Add(new TipoRegimeEmpresaViewModel
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    DataAtualizacao = DateTime.Now
                });
            }

            return tipoRegimeEmpresaModel;
        }

        private TipoRegimeEmpresaViewModel ObterTipoRegimeEmpresa(TipoRegimeEmpresa tipoRegimeEmpresa) => new TipoRegimeEmpresaViewModel()
        {
            Codigo = tipoRegimeEmpresa.Codigo,
            Descricao = tipoRegimeEmpresa.Descricao,
            DataCadastro = tipoRegimeEmpresa.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        private TipoRegimeEmpresa ObterTipoRegimeEmpresaConvertido(TipoRegimeEmpresaViewModel tipoRegimeEmpresa) => new TipoRegimeEmpresa()
        {
            Codigo = tipoRegimeEmpresa.Codigo,
            Descricao = tipoRegimeEmpresa.Descricao,
            Ativo = tipoRegimeEmpresa.Ativo,
            DataCadastro = tipoRegimeEmpresa.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        #endregion

        #region Métodos Públicos
        public List<TipoRegimeEmpresaViewModel> ObterTodos(string nome)
        {
            return ObterTipoRegimeEmpresa(_baseRepository.BuscarTodosPorQueryGerador<TipoRegimeEmpresa>($"NOME LIKE '%{nome}%'"));
        }

        public TipoRegimeEmpresaViewModel CarregaTipoRegimeEmpresa(int codigoSelecionado)
        {
            var tipoRegimeEmpresaEncontrado = _baseRepository.BuscarPorQueryGerador<TipoRegimeEmpresa>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado}");
            return tipoRegimeEmpresaEncontrado != null ? ObterTipoRegimeEmpresa(_baseRepository.BuscarPorQueryGerador<TipoRegimeEmpresa>($"ID = {codigoSelecionado}")) : new TipoRegimeEmpresaViewModel();
        }

        public bool AdicionarTipoRegimeEmpresa(TipoRegimeEmpresaViewModel tipoRegimeEmpresa)
        {
            var tipoRegimeEmpresaConvertido = ObterTipoRegimeEmpresaConvertido(tipoRegimeEmpresa);
            return _baseRepository.Adicionar(tipoRegimeEmpresaConvertido) > 0;
        }

        public bool AtualizarTipoRegimeEmpresa(TipoRegimeEmpresaViewModel tipoRegimeEmpresa)
        {
            if (_baseRepository.BuscarPorQueryGerador<TipoRegimeEmpresa>(tipoRegimeEmpresa.Codigo == 0 ? "" : $"ID = {tipoRegimeEmpresa.Codigo}") == null)
                throw new ArgumentException("Tipo Regime da Empresa não Encontrada.");

            var tipoRegimeEmpresaConvertido = ObterTipoRegimeEmpresaConvertido(tipoRegimeEmpresa);

            return _baseRepository.Atualizar(Convert.ToInt32(tipoRegimeEmpresaConvertido.Codigo), tipoRegimeEmpresaConvertido) > 0;
        }

        public bool RemoverTipoRegimeEmpresa(int codigo)
        {
            var tipoRegimeEmpresa = _baseRepository.BuscarPorQueryGerador<TipoRegimeEmpresa>(codigo == 0 ? "" : $"ID = {codigo}");

            if (tipoRegimeEmpresa == null)
                throw new ArgumentException("Tipo do Regime da Empresa não Encontrada");

            tipoRegimeEmpresa.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(tipoRegimeEmpresa.Codigo), tipoRegimeEmpresa) > 0;
        }

        #endregion
    }
}
