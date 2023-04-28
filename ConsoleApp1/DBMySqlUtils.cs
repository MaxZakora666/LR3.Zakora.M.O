using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    internal class DBMySqlUtils
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string user, string password)
        {
            String connString = $"Server={host};Database={database};Port={port};User={user};Password={password}";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn ;
        }
    }
}
