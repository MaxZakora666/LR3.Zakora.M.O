using System;
using System.Data.Common;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting connection...");
            MySqlConnection conn = DBUtils.GetMySqlConnection();

            try
            {
                Console.WriteLine("Opening connection");

                conn.Open();

                Console.WriteLine("Connection successful!");
                QueryEmployee(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            Console.Read();
        }
        private static void QueryEmployee(MySqlConnection conn)
        {
            string id, name, country;
            string sql = "Select Code,Name,Continent from country";

            MySqlCommand cmd = new MySqlCommand(sql);

            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read()) { 
                    while (reader.Read()) 
                    {
                        id = reader["Code"].ToString();
                        name = reader["Name"].ToString();
                        country = reader["Continent"].ToString();

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"Код: {id},Название: {name},Континент: {country}");
                        Console.WriteLine("--------------------------------");
                    }
                }
            }
        }
    }
}
