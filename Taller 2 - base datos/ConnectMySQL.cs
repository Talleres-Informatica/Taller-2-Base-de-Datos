using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Taller2
{
    public class ConnectMySQL
    {
        private MySqlConnection connection;

        private static ConnectMySQL _instance = new ConnectMySQL();

        public static ConnectMySQL Instance => _instance;

        private string server;
        private string database;
        private string username;
        private string password;

        private ConnectMySQL()
        {
            server = "localhost";
            database = "taller2";
            username = "root";
            password = "Amor1022";

            string connectionString = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Ejecuta una consulta en la base de datos (insert, update, delete) con parámetros.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <param name="parameters">Los parámetros de la consulta.</param>
        /// <returns>1 si la consulta se ejecuta correctamente, -1 en caso contrario.</returns>
        public int ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            try
            {
                OpenConnection();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    command.ExecuteNonQuery();
                }

                CloseConnection();
                return 1;
            }
            catch (Exception)
            {
                CloseConnection();
                return -1;
            }
        }
        /// <summary>
        /// Ejecuta una consulta SELECT en la base de datos y devuelve un valor escalar como resultado.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <param name="values">Los valores de los parámetros de la consulta.</param>
        /// <returns>Un valor escalar como resultado de la consulta.</returns>
        public string SelectQueryScalar(string query, params string[] values)
        {
            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    for (int pos = 0; pos < values.Length; pos += 2)
                    {
                        cmd.Parameters.AddWithValue(values[pos], values[pos + 1]);
                    }

                    object resultObj = cmd.ExecuteScalar();
                    string result = resultObj != null ? resultObj.ToString() : null;

                    CloseConnection();
                    return result;
                }
            }
            catch (Exception)
            {
                CloseConnection();
                throw;
            }
        }
        /// <summary>
        /// Ejecuta una consulta SELECT en la base de datos y devuelve los resultados en un objeto DataTable.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <param name="values">Los valores de los parámetros de la consulta.</param>
        /// <returns>Un objeto DataTable que contiene los resultados de la consulta.</returns>
        public DataTable SelectQuery(string query, params string[] values)
        {
            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    
                    for (int pos = 0; pos < values.Length; pos += 2)
                    {
                        cmd.Parameters.AddWithValue(values[pos], values[pos + 1]);
                    }
                    

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
            catch (Exception)
            {
                CloseConnection();
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }
    }

}
