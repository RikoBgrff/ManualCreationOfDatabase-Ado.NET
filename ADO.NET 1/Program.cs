using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTable table = new MyTable();
            MyRow row = new MyRow();
            Console.Write("Enter the database name:");string databaseName = Console.ReadLine();
            Console.Write("Enter the table name:"); table.Name = Console.ReadLine();
            Console.Write("Enter the row name:");row.Name = Console.ReadLine();
            Console.Write("Enter the type of row");row.Type = Console.ReadLine();
            Console.Write("Enter the constraint of row");row.Constraint = Console.ReadLine();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=STHQ0123-10;Initial Catalog=CarShop;User ID=admin;Password=admin";
            connection.Open();
            Console.WriteLine(connection.State);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string tableName = Console.ReadLine();
            command.CommandText = $"CREATE DATABASE {databaseName};\n" +
                $"CREATE TABLE {tableName}" +
                "(Id INT)";
            //command.CommandText = "USE Riko;\n" +
            //    $"DROP TABLE {tableName}";
            //Console.ReadKey(true);
            //int res = command.ExecuteNonQuery();
            //Console.WriteLine(res);
            //SqlCommand command = new SqlCommand();



            connection.Close();
        }
    }
}
