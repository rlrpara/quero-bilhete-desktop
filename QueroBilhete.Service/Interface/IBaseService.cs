using System;
using System.Collections.Generic;

namespace QueroBilhete.Service.Interface
{
    public interface IBaseService<TEntity>: IDisposable where TEntity : class
    {
        List<TEntity> Query(string where);
        TEntity BuscarPorId(int id);
        TEntity BuscarPorQuery(string query);
        IEnumerable<TEntity> BuscarTodosPorQuery(string query = "");
        IEnumerable<TEntity> BuscarTodosPorQueryGerador(string sqlWhere = "");
        int Adicionar(TEntity entidade);
        int Atualizar(int id, TEntity entidade);
        int Excluir(int id);
    }
}
