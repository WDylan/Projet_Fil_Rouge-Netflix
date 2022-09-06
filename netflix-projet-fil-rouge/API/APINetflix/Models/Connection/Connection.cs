using Microsoft.Data.SqlClient;


namespace APINetflix.Models.Connection
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=(localdb)\PRF2022;Integrated Security = True";
        public static SqlConnection New { get => new SqlConnection(connectionString);}
    }
}
