using QueroBilhete.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace QueroBilhete.Service.Service
{
    public class GenericService<T> : BaseService where T : class
    {
        #region Construtor
        public GenericService(IBaseRepository repositorio) :
            base(repositorio)
        {
        }
        #endregion

        #region Métodos Privados
        #endregion

        #region Métodos Públicos
        public List<T> ObterTodos(string sql)
        {
            return _baseRepository.BuscarTodosPorQuery<T>(sql).ToList();
        }
        #endregion
    }
}
