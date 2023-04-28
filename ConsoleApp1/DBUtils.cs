using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    internal class DBUtils
    {
        public static MySqlConnection GetMySqlConnection()
        {
            string host = "localhost";
            int port = 2525;
            string database = "world";
            string user = "root";
            string password = "Umsf_sqltutor";

            return DBMySqlUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
