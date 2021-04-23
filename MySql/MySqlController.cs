using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    public class MySqlController
    {
        private MySqlTransaction mySqlTransaction = null;
        private List<MySqlParameter> parametros = new List<MySqlParameter>();
        private MySqlConnection mySqlConnection = null;

        public void PreparaConexao()
        {
            if (mySqlConnection == null)
            {
                mySqlConnection = new MySqlConnection(Properties.Settings.Default.ConnectionString);
                mySqlConnection.Open();
                mySqlTransaction = mySqlConnection.BeginTransaction();
            }
        }

        public void AdicionaParametro(string parametro, object valor)
        {
            parametros.Add(new MySqlParameter(parametro, valor));
        }

        public void LimpaParametros()
        {
            parametros.Clear();
        }

        public void Commit()
        {
            mySqlTransaction?.Commit();
        }

        public void Rollback()
        {
            mySqlTransaction?.Rollback();
        }

        public uint ExecuteNonQuery(string comando, CommandType commandType = CommandType.Text)
        {
            PreparaConexao();
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.Transaction = mySqlTransaction;
            mySqlCommand.CommandText = comando;
            mySqlCommand.CommandType = commandType;
            foreach (MySqlParameter parametro in parametros)
                mySqlCommand.Parameters.Add(parametro);
            if (mySqlCommand.ExecuteNonQuery() < 0)
                throw new Exception("Manipulação nao realizada por causa que o numero de linhas alteradas é menor que zero!");
            uint retorno = Convert.ToUInt32(mySqlCommand.LastInsertedId);
            mySqlCommand.Dispose();
            return retorno;
        }

        public uint ExecuteNonQuerySemTransacao(string comando, CommandType commandType = CommandType.Text)
        {
            MySqlConnection conexao = new MySqlConnection(Properties.Settings.Default.ConnectionString);
            conexao.Open();
            MySqlCommand mySqlCommand = conexao.CreateCommand();
            mySqlCommand.CommandText = comando;
            mySqlCommand.CommandType = commandType;
            foreach (MySqlParameter parametro in parametros)
                mySqlCommand.Parameters.Add(parametro);
            if (mySqlCommand.ExecuteNonQuery() < 0)
                throw new Exception("Manipulação nao realizada por causa que o numero de linhas alteradas é menor que zero!");
            uint codigo = Convert.ToUInt32(mySqlCommand.LastInsertedId);
            conexao.Dispose();
            mySqlCommand.Dispose();
            return codigo;
        }

        public object ExecuteScalar(string comando, CommandType commandType = CommandType.Text)
        {
            PreparaConexao();
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.Transaction = mySqlTransaction;
            mySqlCommand.CommandText = comando;
            mySqlCommand.CommandType = commandType;
            foreach (MySqlParameter parametro in parametros)
                mySqlCommand.Parameters.Add(parametro);
            object retorno = mySqlCommand.ExecuteScalar();
            mySqlCommand.Dispose();
            return retorno;
        }

        public object ExecuteScalarSemTransacao(string comando, CommandType commandType = CommandType.Text)
        {
            MySqlConnection conexao = new MySqlConnection(Properties.Settings.Default.ConnectionString);
            conexao.Open();
            MySqlCommand mySqlCommand = conexao.CreateCommand();
            mySqlCommand.CommandText = comando;
            mySqlCommand.CommandType = commandType;
            foreach (MySqlParameter parametro in parametros)
                mySqlCommand.Parameters.Add(parametro);
            object retorno = mySqlCommand.ExecuteScalar();
            conexao.Dispose();
            mySqlCommand.Dispose();
            return retorno;
        }


        public DataTable ExecuteReader(string comando, CommandType commandType = CommandType.Text)
        {
            MySqlConnection conexaoReader = new MySqlConnection(Properties.Settings.Default.ConnectionString);
            conexaoReader.Open();
            MySqlCommand mySqlCommand = conexaoReader.CreateCommand();
            mySqlCommand.CommandText = comando;
            mySqlCommand.CommandType = commandType;
            foreach (MySqlParameter parametro in parametros)
                mySqlCommand.Parameters.Add(parametro);
            DataTable dataTable = new DataTable();
            dataTable.Load(mySqlCommand.ExecuteReader());
            conexaoReader.Dispose();
            mySqlCommand.Dispose();
            return dataTable;
        }

        public void FechaConexaoTransacao()
        {
            mySqlConnection?.Dispose();
            mySqlConnection = null;
            mySqlTransaction?.Dispose();
        }

        public T CampoNulo<T>(object converter)
        {
            if (converter != null && converter != DBNull.Value)
                return (T)converter;
            return default(T);
        }
    }
}
