using System.Data;
using static AreaCalculator.Calculator;
using Microsoft.Data.SqlClient;


namespace HHTask
{
    public static class Program
    {
        private static SqlConnection SqlConnection()
        {
            const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Task;Trusted_Connection=True;";

            var connection = new SqlConnection(connectionString);
            return connection;
        }

        public static void Main(string[] args)
        {
            var connection = SqlConnection();
            var sql = @"
            SELECT pr.product_name, ca.category_name
            FROM ""Product"" pr
                LEFT OUTER JOIN product_category pc on pr.id = pc.product_id
                LEFT OUTER JOIN ""Category"" ca
                    ON pc.category_id = ca.id
            ";
            connection.Open();
            using var cmd = new SqlCommand(sql, connection);
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                Console.WriteLine($"product:{result[0]} category:{result[1]}");
            }
            connection.Close();
        }
    }
}