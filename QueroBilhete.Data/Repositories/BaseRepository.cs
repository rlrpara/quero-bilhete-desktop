using Dapper;
using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Infra.Data.Contex;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QueroBilhete.Data.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        #region Propriedades Privadas
        protected readonly IDbConnection _conexao;
        private readonly static string _nomeBanco = Environment.GetEnvironmentVariable("MYSQL_DATABASE");
        #endregion

        #region Construtores
        public BaseRepository()
        {
            _conexao = ConnectionConfiguration.ObterConexao();
        }
        #endregion

        #region Métodos Privados
        private static string ObterNomeTabela<T>()
        {
            return TableNameMapper(typeof(T));
        }
        private static string TableNameMapper(Type type)
        {
            dynamic tableattr = type.GetCustomAttributes(false).SingleOrDefault(attr => attr.GetType().Name == "TableAttribute");
            return (tableattr != null ? tableattr.Name : string.Empty);
        }
        private void AbrirConexao()
        {
            FecharConexao();

            if (_conexao.State == ConnectionState.Closed && _conexao.State != ConnectionState.Open)
                _conexao.Open();
        }
        private void FecharConexao()
        {
            if (_conexao.State == ConnectionState.Open && _conexao.State != ConnectionState.Closed)
                _conexao.Close();
        }
        #endregion

        #region Métodos Públicos
        public int Adicionar(TEntity entidade)
        {
            AbrirConexao();
            return _conexao.Execute(GeradorDapper.RetornaInsert(entidade));
        }

        public int Atualizar(int id, TEntity entidade)
        {
            AbrirConexao();
            return _conexao.Execute(GeradorDapper.RetornaUpdate(id, entidade));
        }

        public TEntity BuscarPorId(int id)
        {
            AbrirConexao();
            return _conexao.QueryFirstOrDefault<TEntity>($"{GeradorDapper.RetornaSelect<TEntity>(id)}", commandTimeout: 80000000, commandType: CommandType.Text);
        }

        public TEntity BuscarPorQuery(string query)
        {
            AbrirConexao();
            return _conexao.QueryFirstOrDefault<TEntity>(query, commandTimeout: 80000000, commandType: CommandType.Text);
        }

        public TEntity BuscarPorQueryGerador(string sqlWhere = null)
        {
            AbrirConexao();
            var sqlPesquisa = new StringBuilder().AppendLine($"{GeradorDapper.RetornaSelect<TEntity>()}");

            if (!string.IsNullOrEmpty(sqlWhere)) sqlPesquisa.Append($"AND {sqlWhere}");

            return _conexao.Query<TEntity>(sqlPesquisa.ToString(), commandTimeout: 80000000, commandType: CommandType.Text).FirstOrDefault();
        }

        public IEnumerable<TEntity> BuscarTodosPorQuery(string query = null)
        {
            AbrirConexao();
            var sqlPesquisa = new StringBuilder();

            if (string.IsNullOrEmpty(query))
                sqlPesquisa.AppendLine($"{GeradorDapper.RetornaSelect<TEntity>()}");
            else
            {
                sqlPesquisa.AppendLine($"USE {_nomeBanco};");
                sqlPesquisa.AppendLine(query.Trim());
            }

            return _conexao.Query<TEntity>(sqlPesquisa.ToString(), commandTimeout: 80000000, commandType: CommandType.Text);
        }

        public IEnumerable<TEntity> BuscarTodosPorQueryGerador(string sqlWhere = null)
        {
            AbrirConexao();
            var sqlPesquisa = new StringBuilder().AppendLine($"{GeradorDapper.RetornaSelect<TEntity>()}");
            if (!string.IsNullOrEmpty(sqlWhere)) sqlPesquisa.AppendLine($"AND {sqlWhere}");

            return _conexao.Query<TEntity>(sqlPesquisa.ToString(), commandTimeout: 80000000, commandType: CommandType.Text).ToList();
        }

        public int Excluir(int id)
        {
            AbrirConexao();
            return _conexao.Execute($"{GeradorDapper.RetornaDelete<TEntity>(id)}");
        }

        public List<TEntity> Query(string where)
        {
            return _conexao.Query<TEntity>(where, commandTimeout: 80000000, commandType: CommandType.Text).ToList();
        }

        public void Dispose()
        {
            _conexao.Close();
            _conexao.Dispose();
        }
        #endregion
    }
}
