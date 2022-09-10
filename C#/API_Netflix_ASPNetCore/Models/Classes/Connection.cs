using Microsoft.Data.SqlClient;

namespace API_Netflix_ASPNetCore.Models.Classes
{
    public class Connection
    {
        private static string connectionString = @"Data Source=(localdb)\MSSqlLocalDB;Integrated Security=True";
        public static SqlConnection New { get => new SqlConnection(connectionString); }
    }
}
