using QueroBilhete.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace QueroBilhete.Service.Service
{
    public class GenericService : BaseService
    {
        #region Construtor
        public GenericService(IBaseRepository repositorio)
            : base(repositorio)
        {
        }
        #endregion

        #region Métodos Privados
        #endregion

        #region Métodos Públicos
        public List<T> ObterTodos<T>(string sql) where T: class
        {
            return _baseRepository.BuscarTodosPorQueryGerador<T>(sql).ToList();
        }
        #endregion
    }
}
