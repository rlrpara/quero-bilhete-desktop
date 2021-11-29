using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueroBilhete.Service.Service
{
    public class EmbarcacaoPoltronaService : BaseService, IEmbarcacaoPoltronaService
    {
        public EmbarcacaoPoltronaService(IBaseRepository repositorio)
            : base(repositorio)
        {
        }

        #region Métodos Privados
        private List<EmbarcacaoPoltronaViewModel> ObterEmbarcacaoPoltrona(IEnumerable<EmbarcacaoPoltrona> embarcacao)
        {
            var embarcacaoModel = new List<EmbarcacaoPoltronaViewModel>();

            foreach (var item in embarcacao)
            {
                embarcacaoModel.Add(new EmbarcacaoPoltronaViewModel
                {
                    Codigo = item.Codigo,
                    CodigoEmbarcacao = item.CodigoEmbarcacao,
                    Letra = item.Letra,
                    Inicio = item.Inicio,
                    Fim = item.Fim,
                    EixoX = item.EixoX,
                    EixoY = item.EixoY,
                    Alinhamento = item.Alinhamento,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    DataAtualizacao = DateTime.Now
                });
            }

            return embarcacaoModel;
        }

        private EmbarcacaoPoltronaViewModel ObterEmbarcacaoPoltrona(EmbarcacaoPoltrona embarcacaoPoltrona) => new EmbarcacaoPoltronaViewModel()
        {
            Codigo = embarcacaoPoltrona.Codigo,
            CodigoEmbarcacao = embarcacaoPoltrona.CodigoEmbarcacao,
            Letra = embarcacaoPoltrona.Letra,
            Inicio = embarcacaoPoltrona.Inicio,
            Fim = embarcacaoPoltrona.Fim,
            EixoX = embarcacaoPoltrona.EixoX,
            EixoY = embarcacaoPoltrona.EixoY,
            Alinhamento = embarcacaoPoltrona.Alinhamento,
            Ativo = embarcacaoPoltrona.Ativo,
            DataCadastro = embarcacaoPoltrona.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        private EmbarcacaoPoltrona ObterEmbarcacaoPoltronaConvertido(EmbarcacaoPoltronaViewModel embarcacaoPoltronaViewModel) => new EmbarcacaoPoltrona()
        {
            Codigo = embarcacaoPoltronaViewModel.Codigo,
            CodigoEmbarcacao = embarcacaoPoltronaViewModel.CodigoEmbarcacao,
            Letra = embarcacaoPoltronaViewModel.Letra,
            Inicio = embarcacaoPoltronaViewModel.Inicio,
            Fim = embarcacaoPoltronaViewModel.Fim,
            EixoX = embarcacaoPoltronaViewModel.EixoX,
            EixoY = embarcacaoPoltronaViewModel.EixoY,
            Alinhamento = embarcacaoPoltronaViewModel.Alinhamento,
            Ativo = embarcacaoPoltronaViewModel.Ativo,
            DataCadastro = embarcacaoPoltronaViewModel.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        #endregion

        #region Métodos Públicos
        public List<EmbarcacaoPoltronaViewModel> ObterTodos(string nome)
        {
            return ObterEmbarcacaoPoltrona(_baseRepository.BuscarTodosPorQueryGerador<EmbarcacaoPoltrona>($"NOME LIKE '%{nome}%'"));
        }

        public List<EmbarcacaoPoltrona> ObterDadosGrid(int codigoEmbarcacao)
        {
            return _baseRepository.BuscarTodosPorQueryGerador<EmbarcacaoPoltrona>($"ID_EMBARCACAO = {codigoEmbarcacao}").ToList();
        }

        public EmbarcacaoPoltronaViewModel CarregaEmbarcacaoPoltrona(int codigoSelecionado)
        {
            var EmbarcacaoEncontrada = _baseRepository.BuscarPorQueryGerador<Embarcacao>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado}");
            return EmbarcacaoEncontrada != null ? ObterEmbarcacaoPoltrona(_baseRepository.BuscarPorQueryGerador<EmbarcacaoPoltrona>($"ID = {codigoSelecionado}")) : new EmbarcacaoPoltronaViewModel();
        }

        public bool AdicionarEmbarcacaoPoltrona(EmbarcacaoPoltronaViewModel embarcacaoPoltrona)
        {
            var EmbarcacaoPoltronaConvertido = ObterEmbarcacaoPoltronaConvertido(embarcacaoPoltrona);
            return _baseRepository.Adicionar(EmbarcacaoPoltronaConvertido) > 0;
        }

        public bool AtualizarEmbarcacaoPoltrona(EmbarcacaoPoltronaViewModel embarcacaoPoltrona)
        {
            if (_baseRepository.BuscarPorQueryGerador<EmbarcacaoPoltrona>(embarcacaoPoltrona.Codigo == 0 ? "" : $"ID = {embarcacaoPoltrona.Codigo}") == null)
                throw new ArgumentException("Usuário não Encontrado");

            var EmbarcacaoPoltronaConvertido = ObterEmbarcacaoPoltronaConvertido(embarcacaoPoltrona);

            return _baseRepository.Atualizar(Convert.ToInt32(EmbarcacaoPoltronaConvertido.Codigo), EmbarcacaoPoltronaConvertido) > 0;
        }

        public bool RemoverEmbarcacaoPoltrona(int codigo)
        {
            var EmbarcacaoPoltrona = _baseRepository.BuscarPorQueryGerador<EmbarcacaoPoltrona>(codigo == 0 ? "" : $"ID = {codigo}");

            if (EmbarcacaoPoltrona == null)
                throw new ArgumentException("Poltrona não Encontrada");

            EmbarcacaoPoltrona.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(EmbarcacaoPoltrona.Codigo), EmbarcacaoPoltrona) > 0;
        }

        #endregion
    }
}
