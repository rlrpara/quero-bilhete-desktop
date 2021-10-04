using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using System.Collections.Generic;

namespace QueroBilhete.Service.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : Entity
    {
        private readonly IBaseRepository<TEntity> _baseService;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _baseService = repository;
        }

        public int Adicionar(TEntity entidade)
        {
            try
            {
                return _baseService.Adicionar(entidade);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public int Atualizar(int id, TEntity entidade)
        {
            try
            {
                return _baseService.Atualizar(id, entidade);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public TEntity BuscarPorId(int id)
        {
            try
            {
                return _baseService.BuscarPorId(id);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public TEntity BuscarPorQuery(string query)
        {
            try
            {
                return _baseService.BuscarPorQuery(query);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public IEnumerable<TEntity> BuscarTodosPorQuery(string query = "")
        {
            try
            {
                return _baseService.BuscarTodosPorQuery(query);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public IEnumerable<TEntity> BuscarTodosPorQueryGerador(string sqlWhere = "")
        {
            try
            {
                return _baseService.BuscarTodosPorQueryGerador(sqlWhere);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public int Excluir(int id)
        {
            try
            {
                return _baseService.Excluir(id);
            }
            catch
            {
                return default(dynamic);
            }
        }

        public List<TEntity> Query(string where)
        {
            return _baseService.Query(where);
        }
    }
}
