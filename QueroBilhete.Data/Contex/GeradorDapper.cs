﻿using Dapper;
using QueroBilhete.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace QueroBilhete.Infra.Data.Contex
{
    public class GeradorDapper
    {
        #region Métodos Privados
        private readonly static string _nomeBanco = Environment.GetEnvironmentVariable("MYSQL_DATABASE");
        private static bool EhBrancoNulo(string valor)
            => string.IsNullOrWhiteSpace(valor.ToString().Trim());
        private static DynamicParameters RetornaListaParametros(ColumnAttribute atributo, object valor, string nome)
        {
            var listaParametros = new DynamicParameters();

            if (!EhBrancoNulo(atributo?.Name ?? "") && (valor != null) && !valor.ToString().Contains("01/01/0001 12:00:00 AM") && !valor.ToString().Equals("0"))
            {
                if (valor is DateTime) listaParametros.Add($"@{nome}", Convert.ToDateTime(valor.ToString()).ToString("yyyy-MM-dd HH:mm:ss"), DbType.DateTime);

                else if (valor is bool) listaParametros.Add($"@{nome}", Convert.ToBoolean(valor), DbType.Boolean);

                else if (valor is int) listaParametros.Add($"@{nome}", Convert.ToInt32(valor), DbType.Int32);

                else if (valor is string) listaParametros.Add($"@{nome}", valor.ToString(), DbType.String);
            }
            return listaParametros;
        }

        public static string ObterColunasGrid<T>(IEnumerable<T> list) where T : class
        {
            string chavePrimaria = string.Empty;
            List<string> campos = new List<string>();

            foreach (var lista in list)
            {
                foreach (var item in lista.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault()).Order))
                {
                    var opcoesBase = (OpcoesBase)item.GetCustomAttribute(typeof(OpcoesBase));
                    if (opcoesBase != null)
                    {
                        if (opcoesBase.UsarParaBuscar && item.GetCustomAttribute<ColumnAttribute>().Name != "")
                            campos.Add($"{item.GetCustomAttribute<ColumnAttribute>().Name}|{item.Name}|{opcoesBase.TamanhoColunaGrid}|{opcoesBase.UsarNaGrid}");
                    }
                }
                break;
            }

            var sqlPesquisa = new StringBuilder().AppendLine($"{(string.Join($";", campos.ToArray()))}");

            return sqlPesquisa.ToString();
        }

        public static string ObterDadosGrid<T>(string sqlWhere) where T : class
        {
            string chavePrimaria = string.Empty;
            List<string> campos = new List<string>();

            foreach (var item in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault()).Order))
            {
                var opcoesBase = (OpcoesBase)item.GetCustomAttribute(typeof(OpcoesBase));
                if (opcoesBase != null)
                {
                    var tipoCampo = item.PropertyType.Name;

                    if (opcoesBase.ChavePrimaria)
                        chavePrimaria = item.GetCustomAttribute<ColumnAttribute>().Name;

                    if (opcoesBase.UsarParaBuscar && item.GetCustomAttribute<ColumnAttribute>().Name != "" && opcoesBase.UsarNaGrid)
                        campos.Add($"{item.GetCustomAttribute<ColumnAttribute>().Name} AS {item.Name}");
                }
            }

            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"USE {_nomeBanco};");
            sqlPesquisa.AppendLine($"SELECT {(string.Join($",{Environment.NewLine}       ", campos.ToArray()))}");
            sqlPesquisa.AppendLine($"  FROM {ObterNomeTabela<T>()}");
            sqlPesquisa.AppendLine($" WHERE {chavePrimaria} IS NOT NULL");
            sqlPesquisa.AppendLine(sqlWhere);

            return sqlPesquisa.ToString();
        }

        private static string TipoPropriedade(PropertyInfo item)
        {
            return item.PropertyType.Name switch
            {
                "Int32" => "int(11) DEFAULT NULL",
                "Int64" => "bigint DEFAULT NULL",
                "Double" => "decimal(18,2)",
                "Single" => "float",
                "DateTime" => "datetime DEFAULT CURRENT_TIMESTAMP",
                "Boolean" => "tinyint(1) NOT NULL DEFAULT 1",
                "Nullable`1" => ObterParaTipoNulo(item.PropertyType.FullName),
                _ => "varchar(255) NULL",
            };
        }

        public static string InserirDadosPadroes<T>() where T : class
        {
            var nomeTabela = ObterNomeTabela<T>();

            var sqlInsert = new StringBuilder();

            switch (nomeTabela.ToLower())
            {
                case "usuario":
                        sqlInsert.AppendLine("INSERT INTO usuario (          NOME,             EMAIL, SENHA, ID_NIVEL_ACESSO)");
                        sqlInsert.AppendLine("             VALUES ('Administrador', 'admin@email.com', '123',               1)");
                    break;
                case "nivel_acesso":
                    sqlInsert.AppendLine("INSERT INTO nivel_acesso(        TITULO,       DESCRICAO)");
                    sqlInsert.AppendLine("                  VALUES('ADMINISTRADOR', 'ADMINISTRADOR');");
                    sqlInsert.AppendLine("INSERT INTO nivel_acesso(       TITULO,      DESCRICAO)");
                    sqlInsert.AppendLine("                  VALUES('PROPRIETARIO', 'PROPRIETARIO');");
                    sqlInsert.AppendLine("INSERT INTO nivel_acesso(   TITULO,  DESCRICAO)");
                    sqlInsert.AppendLine("                  VALUES('VENDEDOR', 'VENDEDOR')");
                    break;
                case "empresa":
                    sqlInsert.AppendLine("INSERT INTO empresa (RAZAO_SOCIAL,             CNPJ, TIPO_REGIME_ID, AMBIENTE_ID)");
                    sqlInsert.AppendLine("              VALUES(    'PADRAO', '00000000000000',              1,           1)");
                    break;
                case "alinhamento":
                    sqlInsert.AppendLine("INSERT INTO alinhamento(     NOME)");
                    sqlInsert.AppendLine("                 VALUES('DIREITA');");
                    sqlInsert.AppendLine("INSERT INTO alinhamento(      NOME)");
                    sqlInsert.AppendLine("                 VALUES('ESQUERDA');");
                    break;
                case "tipo_passagem":
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('INTEIRA');");
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('MEIA');");
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('IDOSO');");
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('CRIANCA');");
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('POLICIA');");
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('PESSOA COM DEFICIENCIA');");
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('PREFEITURA');");
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('VEREADOR');");
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('PATROCINIO');");
                    sqlInsert.AppendLine("INSERT INTO tipo_passagem (DESCRICAO)");
                    sqlInsert.AppendLine("                   VALUES ('OUTROS');");
                    break;
                case "tipo_regime_empresa":
                    sqlInsert.AppendLine("INSERT INTO tipo_regime_empresa (DESCRICAO)");
                    sqlInsert.AppendLine("                         VALUES ('1 – SIMPLES NACIONAL');");
                    sqlInsert.AppendLine("INSERT INTO tipo_regime_empresa (DESCRICAO)");
                    sqlInsert.AppendLine("                         VALUES ('2 – SIMPLES NACIONAL – EXCESSO DE SUBLIMITE DE RECEITA BRUTA');");
                    sqlInsert.AppendLine("INSERT INTO tipo_regime_empresa (DESCRICAO)");
                    sqlInsert.AppendLine("                         VALUES ('3 – REGIME NORMAL');");
                    break;
                case "tipo_viagem":
                    sqlInsert.AppendLine("INSERT INTO tipo_viagem (DESCRICAO)");
                    sqlInsert.AppendLine("                 VALUES ('00-REGULAR');");
                    sqlInsert.AppendLine("INSERT INTO tipo_viagem (DESCRICAO)");
                    sqlInsert.AppendLine("                 VALUES ('01-EXTRA');");
                    break;
                case "ambiente_servidor":
                    sqlInsert.AppendLine("INSERT INTO ambiente_servidor (NOME)");
                    sqlInsert.AppendLine("                       VALUES ('HOMOLOGACAO');");
                    sqlInsert.AppendLine("INSERT INTO ambiente_servidor (NOME)");
                    sqlInsert.AppendLine("                       VALUES ('PRODUCAO');");
                    break;
                default:
                    break;
            }

            return sqlInsert.ToString();
        }

        private static string ObterParaTipoNulo(string fullName)
        {
            if (fullName.Contains("Int32"))
                return "int(11) DEFAULT NULL";
            else if (fullName.Contains("DateTime"))
                return "datetime DEFAULT NULL";
            else
                return "varchar(255) NULL";
        }
        #endregion

        #region Métodos Públicos
        public static string ObterNomeTabela<T>() where T : class
        {
            dynamic tableattr = typeof(T).GetCustomAttributes(false).SingleOrDefault(attr => attr.GetType().Name == "TableAttribute");

            return (tableattr != null ? tableattr.Name.ToLower() : "");
        }
        public static string RetornaSelect<T>(int? id = null) where T : class
        {
            string chavePrimaria = string.Empty;
            List<string> campos = new List<string>();

            foreach (PropertyInfo item in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault()).Order))
            {
                var opcoesBase = (OpcoesBase)item.GetCustomAttribute(typeof(OpcoesBase));
                if (opcoesBase != null)
                {
                    var tipoCampo = item.PropertyType.Name;

                    if (opcoesBase.ChavePrimaria)
                        chavePrimaria = item.GetCustomAttribute<ColumnAttribute>().Name;

                    if (opcoesBase.UsarParaBuscar && item.GetCustomAttribute<ColumnAttribute>().Name != "")
                        campos.Add($"{item.GetCustomAttribute<ColumnAttribute>().Name} AS {item.Name}");
                }
            }

            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"USE {_nomeBanco};");
            sqlPesquisa.AppendLine($"SELECT {(string.Join($",{Environment.NewLine}       ", campos.ToArray()))}");
            sqlPesquisa.AppendLine($"  FROM {ObterNomeTabela<T>()}");
            sqlPesquisa.AppendLine($" WHERE {chavePrimaria} IS NOT NULL");

            if (id != null)
                sqlPesquisa.AppendLine($"   AND {chavePrimaria} = {id}");

            return sqlPesquisa.ToString();
        }
        public static string RetornaInsert<T>(T entidade) where T : class
        {
            List<string> campos = new List<string>();
            List<string> valores = new List<string>();

            foreach (PropertyInfo item in entidade.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault()).Order))
            {
                var tipoCampo = item.PropertyType;
                var opcoesBase = (OpcoesBase)item.GetCustomAttribute(typeof(OpcoesBase));

                if (opcoesBase != null && opcoesBase.UsarNoBancoDeDados && !opcoesBase.ChavePrimaria)
                {
                    var valor = item.GetValue(entidade);

                    if (valor != null)
                    {
                        campos.Add(item.GetCustomAttribute<ColumnAttribute>().Name);

                        if (tipoCampo.Name.ToLower().Contains("string"))
                            valores.Add($"'{valor}'");

                        else if (tipoCampo.Name.ToLower().Contains("datetime"))
                            valores.Add($"'{Convert.ToDateTime(valor):yyyy-MM-dd HH:mm:ss}'");

                        else if (tipoCampo.Name.ToLower().Contains("nullable`1"))
                            if (tipoCampo.ToString().ToLower().Contains("datetime"))
                                valores.Add($"'{Convert.ToDateTime(valor):yyyy-MM-dd HH:mm:ss}'");

                            else if (tipoCampo.ToString().ToLower().Contains("int32"))
                                valores.Add($"{valor}");

                            else
                                valores.Add($"'{valor}'");

                        else
                            valores.Add($"{valor}");
                    }
                }
            }

            var sqlInsert = new StringBuilder();

            sqlInsert.Append($"USE {_nomeBanco};");
            sqlInsert.AppendLine($"INSERT INTO {ObterNomeTabela<T>()} ({string.Join(", ", campos.ToArray())})");
            sqlInsert.AppendLine($"            VALUES ({string.Join(", ", valores.ToArray())});");

            return sqlInsert.ToString();
        }

        public static string GerarProcedureAddIfColumnNotExists(string nomeBanco)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"USE {nomeBanco};");
            sqlPesquisa.AppendLine($"DROP PROCEDURE IF EXISTS AddIfColumnNotExists; ");
            sqlPesquisa.AppendLine($"DROP FUNCTION IF EXISTS IfColumnExists; ");
            sqlPesquisa.AppendLine($"CREATE FUNCTION IfColumnExists (table_name_IN VARCHAR(100), field_name_IN VARCHAR(100)) ");
            sqlPesquisa.AppendLine($"RETURNS INT");
            sqlPesquisa.AppendLine($"RETURN (");
            sqlPesquisa.AppendLine($"    SELECT COUNT(COLUMN_NAME) ");
            sqlPesquisa.AppendLine($"    FROM INFORMATION_SCHEMA.columns ");
            sqlPesquisa.AppendLine($"    WHERE TABLE_SCHEMA = DATABASE() ");
            sqlPesquisa.AppendLine($"    AND TABLE_NAME = table_name_IN ");
            sqlPesquisa.AppendLine($"    AND COLUMN_NAME = field_name_IN");
            sqlPesquisa.AppendLine($");");
            sqlPesquisa.AppendLine($"CREATE PROCEDURE AddIfColumnNotExists (");
            sqlPesquisa.AppendLine($"    IN table_name_IN VARCHAR(100)");
            sqlPesquisa.AppendLine($"    , IN field_name_IN VARCHAR(100)");
            sqlPesquisa.AppendLine($"    , IN field_definition_IN VARCHAR(100)");
            sqlPesquisa.AppendLine($")");
            sqlPesquisa.AppendLine($"BEGIN");
            sqlPesquisa.AppendLine($"    SET @isFieldThere = IfColumnExists(table_name_IN, field_name_IN);");
            sqlPesquisa.AppendLine($"    IF (@isFieldThere = 0) THEN");
            sqlPesquisa.AppendLine($"        SET @ddl = CONCAT('ALTER TABLE ', table_name_IN);");
            sqlPesquisa.AppendLine($"        SET @ddl = CONCAT(@ddl, ' ', 'ADD COLUMN') ;");
            sqlPesquisa.AppendLine($"        SET @ddl = CONCAT(@ddl, ' ', field_name_IN);");
            sqlPesquisa.AppendLine($"        SET @ddl = CONCAT(@ddl, ' ', field_definition_IN);");
            sqlPesquisa.AppendLine($"        PREPARE stmt FROM @ddl;");
            sqlPesquisa.AppendLine($"        EXECUTE stmt;");
            sqlPesquisa.AppendLine($"        DEALLOCATE PREPARE stmt;");
            sqlPesquisa.AppendLine($"    END IF;");
            sqlPesquisa.AppendLine($"END;");

            return sqlPesquisa.ToString();
        }

        public static string RetornaUpdate<T>(int id, T entidade) where T : class
        {
            List<string> condicao = new List<string>();
            string campoChave = string.Empty;

            foreach (PropertyInfo item in entidade.GetType().GetProperties(BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault()).Order))
            {
                OpcoesBase opcoesBase = (OpcoesBase)item.GetCustomAttribute(typeof(OpcoesBase));

                if (opcoesBase != null && opcoesBase.UsarNoBancoDeDados && !opcoesBase.ChavePrimaria)
                {
                    var valor = item.GetValue(entidade);
                    var campo = item.GetCustomAttribute<ColumnAttribute>().Name;
                    var tipoCampo = item.PropertyType.Name.ToLower();

                    if (opcoesBase.ChavePrimaria)
                        campoChave = item.GetCustomAttribute<ColumnAttribute>().Name;

                    if (valor != null)
                    {
                        if (tipoCampo.Contains("string"))
                            condicao.Add($"{campo} = '{valor}'");

                        else if (tipoCampo.Contains("datetime"))
                            condicao.Add($"{campo} = '{Convert.ToDateTime(valor):yyyy-MM-dd HH:mm:ss}'");

                        else if (tipoCampo.Contains("nullable`1"))
                            if (tipoCampo.ToString().ToLower().Contains("datetime"))
                                condicao.Add($"{campo} = '{Convert.ToDateTime(valor):yyyy-MM-dd HH:mm:ss}'");

                            else if (tipoCampo.ToString().ToLower().Contains("int32"))
                                condicao.Add($"{campo} = {valor}");

                            else
                                condicao.Add($"{campo} = '{valor}'");
                        else
                            condicao.Add($"{campo} = {valor}");
                    }
                }
                else if (opcoesBase != null && opcoesBase.ChavePrimaria)
                {
                    campoChave = item.GetCustomAttribute<ColumnAttribute>().Name;
                }
            }

            var sqlAtualizar = new StringBuilder();

            sqlAtualizar.AppendLine($"USE {_nomeBanco};");
            sqlAtualizar.AppendLine($"UPDATE {ObterNomeTabela<T>()}");
            sqlAtualizar.AppendLine($"   SET {(string.Join($",{Environment.NewLine}       ", condicao.ToArray()))}");
            sqlAtualizar.AppendLine($" WHERE {campoChave} = {id}");

            return sqlAtualizar.ToString();
        }
        public static string RetornaDelete<T>(int id) where T : class
        {
            string campoChave = string.Empty;

            foreach (PropertyInfo item in typeof(T).GetProperties(BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault()).Order))
            {
                OpcoesBase opcoesBase = (OpcoesBase)item.GetCustomAttribute(typeof(OpcoesBase));

                if (opcoesBase != null && opcoesBase.UsarNoBancoDeDados && opcoesBase.ChavePrimaria)
                    campoChave = item.GetCustomAttribute<ColumnAttribute>().Name;
            }

            var sqlDelete = new StringBuilder();

            sqlDelete.AppendLine($"USE {_nomeBanco};");
            sqlDelete.AppendLine($"DELETE FROM {ObterNomeTabela<T>()}");
            sqlDelete.AppendLine($" WHERE {campoChave} = {id}");

            return sqlDelete.ToString();
        }
        public static string CriarTabela<T>(string nomeBanco) where T : class
        {
            string chavePrimaria = string.Empty;
            List<string> campos = new List<string>();
            StringBuilder sqlConstraint = new StringBuilder();

            foreach (PropertyInfo item in typeof(T).GetProperties(BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public))
            {
                var opcoesBase = (OpcoesBase)item.GetCustomAttribute(typeof(OpcoesBase));

                if (opcoesBase != null)
                {
                    var nomeCampo = item.GetCustomAttribute<ColumnAttribute>().Name;

                    if (opcoesBase.UsarParaBuscar)
                    {
                        if (opcoesBase.ChavePrimaria)
                            chavePrimaria = $"{nomeCampo}";

                        else if (nomeCampo != "")
                            campos.Add($"{nomeCampo} {TipoPropriedade(item)}");
                    }

                    if (!string.IsNullOrEmpty(opcoesBase.ChaveEstrangeira))
                    {
                        string tabelaChaveEstrangeira = $"{opcoesBase.ChaveEstrangeira.ToLower()}";
                        string campoChaveEstrangeira = $"{nomeCampo}";
                        string nomeChave = $"FK_{ObterNomeTabela<T>()}_{campoChaveEstrangeira}".ToUpper();

                        sqlConstraint.AppendLine($"CALL PROC_DROP_FOREIGN_KEY('{ObterNomeTabela<T>()}', '{nomeChave}');");
                        sqlConstraint.AppendLine($"ALTER TABLE {nomeBanco}.{ObterNomeTabela<T>()}");
                        sqlConstraint.AppendLine($"ADD CONSTRAINT {nomeChave} FOREIGN KEY ({campoChaveEstrangeira})");
                        sqlConstraint.AppendLine($"REFERENCES {nomeBanco}.{tabelaChaveEstrangeira} (ID) ON DELETE NO ACTION ON UPDATE NO ACTION;{Environment.NewLine}");
                    }
                }
            }

            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"USE {nomeBanco};");
            sqlPesquisa.AppendLine($"CREATE TABLE IF NOT EXISTS {nomeBanco}.{ObterNomeTabela<T>()} (");
            sqlPesquisa.AppendLine($"  {chavePrimaria} int(11) NOT NULL AUTO_INCREMENT,");
            sqlPesquisa.AppendLine($"  {string.Join($",{Environment.NewLine}   ", campos.ToArray())},");
            sqlPesquisa.AppendLine($"  PRIMARY KEY ({chavePrimaria})");
            sqlPesquisa.AppendLine($")");
            sqlPesquisa.AppendLine($"ENGINE = INNODB,");
            sqlPesquisa.AppendLine($"CHARACTER SET utf8,");
            sqlPesquisa.AppendLine($"COLLATE utf8_general_ci;{Environment.NewLine}");

            if (!string.IsNullOrEmpty(sqlConstraint.ToString()))
                sqlPesquisa.AppendLine(sqlConstraint.ToString());

            return sqlPesquisa.ToString();
        }
        #endregion
    }
}
