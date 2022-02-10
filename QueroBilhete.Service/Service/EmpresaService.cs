using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Infra.Data.Repositories;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class EmpresaService : BaseService, IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        public EmpresaService(IBaseRepository repositorio)
            : base(repositorio)
        {
            _empresaRepository = new EmpresaRepository();
        }

        #region Métodos Privados
        private List<EmpresaViewModel> ObterEmpresas(IEnumerable<Empresa> Empresas)
        {
            var EmpresaModel = new List<EmpresaViewModel>();

            foreach (var item in Empresas)
            {
                EmpresaModel.Add(new EmpresaViewModel
                {
                    Codigo = item.Codigo,
                    UId = item.UId,
                    RazaoSocial = item.RazaoSocial,
                    Cnpj = item.Cnpj,
                    InscricaoEstadual = item.InscricaoEstadual,
                    InscricaoMunicipal = item.InscricaoMunicipal,
                    Telefone = item.Telefone,
                    Celular = item.Celular,
                    Email = item.Email,
                    Site = item.Site,
                    Logo = item.Logo,
                    Cep = item.Cep,
                    Estado = item.Estado,
                    Cidade = item.Cidade,
                    Bairro = item.Bairro,
                    Rua = item.Rua,
                    Numero = item.Numero,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    DataAtualizacao = DateTime.Now
                });
            }

            return EmpresaModel;
        }

        private EmpresaViewModel ObterEmpresa(Empresa empresa) => new EmpresaViewModel()
        {
            Codigo = empresa.Codigo,
            UId = empresa.UId,
            RazaoSocial = empresa.RazaoSocial,
            Cnpj = empresa.Cnpj,
            InscricaoEstadual = empresa.InscricaoEstadual,
            InscricaoMunicipal = empresa.InscricaoMunicipal,
            Telefone = empresa.Telefone,
            Celular = empresa.Celular,
            Email = empresa.Email,
            Site = empresa.Site,
            Logo = empresa.Logo,
            Cep = empresa.Cep,
            Estado = empresa.Estado,
            Cidade = empresa.Cidade,
            Bairro = empresa.Bairro,
            Rua = empresa.Rua,
            Numero = empresa.Numero,
            CodigoRegimeEmpresa = empresa.CodigoRegimeEmpresa,
            CodigoAmbiente = empresa.CodigoAmbiente,
            DataCadastro = empresa.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        private Empresa ObterEmpresaConvertido(EmpresaViewModel empresa) => new Empresa()
        {
            Codigo = empresa.Codigo,
            UId = empresa.UId,
            RazaoSocial = empresa.RazaoSocial,
            Cnpj = empresa.Cnpj,
            CodigoRegimeEmpresa = empresa.CodigoRegimeEmpresa,
            InscricaoEstadual = empresa.InscricaoEstadual,
            InscricaoMunicipal = empresa.InscricaoMunicipal,
            Telefone = empresa.Telefone,
            Celular = empresa.Celular,
            Email = empresa.Email,
            Site = empresa.Site,
            Logo = empresa.Logo,
            Cep = empresa.Cep,
            Estado = empresa.Estado,
            Cidade = empresa.Cidade,
            Bairro = empresa.Bairro,
            Rua = empresa.Rua,
            Numero = empresa.Numero,
            Ativo = empresa.Ativo,
            CodigoAmbiente = empresa.CodigoAmbiente,
            DataCadastro = empresa.DataCadastro,
            DataAtualizacao = DateTime.Now
        };

        #endregion

        #region Métodos Públicos
        public List<EmpresaViewModel> ObterTodos(string nome)
        {
            return ObterEmpresas(_baseRepository.BuscarTodosPorQueryGerador<Empresa>($"NOME LIKE '%{nome}%'"));
        }

        public EmpresaViewModel CarregaEmpresa(int codigoSelecionado)
        {
            var EmpresaEncontrado = _baseRepository.BuscarPorQueryGerador<Empresa>(codigoSelecionado == 0 ? "" : $"ID = {codigoSelecionado}");
            return EmpresaEncontrado != null ? ObterEmpresa(_baseRepository.BuscarPorQueryGerador<Empresa>($"ID = {codigoSelecionado}")) : new EmpresaViewModel();
        }

        public bool AdicionarEmpresa(EmpresaViewModel Empresa)
        {
            var EmpresaConvertido = ObterEmpresaConvertido(Empresa);
            return _baseRepository.Adicionar(EmpresaConvertido) > 0;
        }

        public bool AtualizarEmpresa(EmpresaViewModel Empresa)
        {
            if (_baseRepository.BuscarPorQueryGerador<Empresa>(Empresa.Codigo == 0 ? "" : $"ID = {Empresa.Codigo}") == null)
                throw new ArgumentException("Empresa não Encontrada");

            var EmpresaConvertido = ObterEmpresaConvertido(Empresa);

            return _baseRepository.Atualizar(Convert.ToInt32(EmpresaConvertido.Codigo), EmpresaConvertido) > 0;
        }

        public bool RemoverEmpresa(int codigo)
        {
            var Empresa = _baseRepository.BuscarPorQueryGerador<Empresa>(codigo == 0 ? "" : $"ID = {codigo}");

            if (Empresa == null)
                throw new ArgumentException("Usuário não Encontrado");

            Empresa.Ativo = false;

            return _baseRepository.Atualizar(Convert.ToInt32(Empresa.Codigo), Empresa) > 0;
        }

        #endregion

    }
}
