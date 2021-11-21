using Newtonsoft.Json;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Infra.Utilities.Utilitarios;
using QueroBilhete.Service.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace QueroBilhete.Service.Service
{
    public abstract class BaseService : IBaseService
    {
        protected readonly IBaseRepository _baseRepository;

        public BaseService(IBaseRepository repositorio)
        {
            _baseRepository = repositorio;
        }

        public int Adicionar<TEntity>(TEntity entidade) where TEntity : class
        {
            try
            {
                return _baseRepository.Adicionar(entidade);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public int Atualizar<TEntity>(int id, TEntity entidade) where TEntity : class
        {
            try
            {
                return _baseRepository.Atualizar(id, entidade);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public TEntity BuscarPorId<TEntity>(int id) where TEntity : class
        {
            try
            {
                return _baseRepository.BuscarPorId<TEntity>(id);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public TEntity BuscarPorQuery<TEntity>(string query) where TEntity : class
        {
            try
            {
                return _baseRepository.BuscarPorQuery<TEntity>(query);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public TEntity BuscarPorQueryGerador<TEntity>(string sqlWhere = null) where TEntity : class
        {
            try
            {
                return _baseRepository.BuscarPorQueryGerador<TEntity>(sqlWhere);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public IEnumerable<TEntity> BuscarTodosPorQuery<TEntity>(string query = null) where TEntity : class
        {
            try
            {
                return _baseRepository.BuscarTodosPorQuery<TEntity>(query);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public IEnumerable<TEntity> BuscarTodosPorQueryGerador<TEntity>(string sqlWhere = null) where TEntity : class
        {
            try
            {
                return _baseRepository.BuscarTodosPorQueryGerador<TEntity>(sqlWhere);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public int Excluir<TEntity>(int id) where TEntity : class
        {
            try
            {
                return _baseRepository.Excluir<TEntity>(id);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public List<TEntity> Query<TEntity>(string where) where TEntity : class
        {
            return _baseRepository.Query<TEntity>(where);
        }

        public void Dispose()
        {
            _baseRepository.Dispose();
        }

        public async Task<T> ConsultaGenericaApi<T>(string url) where T : class
        {
            if (Utils.ChecaConexaoInternet())
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"{url}");
                    var resposta = await client.GetAsync("");
                    string dados = await resposta.Content.ReadAsStringAsync();

                    if (resposta.IsSuccessStatusCode)
                    {
                        var dadosConvertidos = JsonConvert.DeserializeObject<T>(dados);
                        return dadosConvertidos;
                    }

                    return default(T);
                }
            }

            return default(T);
        }
    }
}
