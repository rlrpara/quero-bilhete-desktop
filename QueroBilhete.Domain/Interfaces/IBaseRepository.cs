using System;
using System.Collections.Generic;

namespace QueroBilhete.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        List<TEntity> Query(string where);
        TEntity BuscarPorId(int id);
        TEntity BuscarPorQuery(string query);
        TEntity BuscarPorQueryGerador(string sqlWhere = null);
        IEnumerable<TEntity> BuscarTodosPorQuery(string query = null);
        IEnumerable<TEntity> BuscarTodosPorQueryGerador(string sqlWhere = null);
        int Adicionar(TEntity entidade);
        int Atualizar(int id, TEntity entidade);
        int Excluir(int id);
    }
}
