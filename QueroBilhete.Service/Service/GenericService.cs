using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Infra.Data.Contex;
using System;
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
        private static string ObterNomeBanco()
            => Environment.GetEnvironmentVariable("MYSQL_DATABASE");
        #endregion

        #region Métodos Públicos
        public List<T> ObterTodos<T>(string sql) where T: class
        {
            return _baseRepository.BuscarTodosPorQueryGerador<T>(sql).ToList();
        }
        public string ObterDescricao<T>(int codigoSelecionado, string coluna) where T : class
        {
            var sql = $"USE {ObterNomeBanco()};SELECT {coluna} FROM {GeradorDapper.ObterNomeTabela<T>()} WHERE ID = {codigoSelecionado};";
            return _baseRepository.BuscarPorQuery<string>(sql);
        }

        #endregion
    }
}
