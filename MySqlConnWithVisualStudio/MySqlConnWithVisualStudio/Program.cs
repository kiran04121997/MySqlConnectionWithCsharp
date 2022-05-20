using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlConnWithVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "localhost";
            string database = "kirandb1";
            string username = "root";
            string password = "kiran@992192";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            string query = "select * from Customers";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["CustomerID"]);
                Console.WriteLine(reader["CustomerName"]);
                Console.WriteLine(reader["ContactName"]);
                Console.WriteLine(reader["Address"]);
                Console.WriteLine(reader["City"]);
                Console.WriteLine(reader["PostalCode"]);
                Console.WriteLine(reader["Price"]);
            }
            Console.ReadLine();
        }
    }
}
