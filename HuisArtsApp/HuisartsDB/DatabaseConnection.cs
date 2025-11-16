using MySql.Data.MySqlClient;

namespace HuisartsDB
{
    public static class DatabaseConnection
    {
        // Define the connection string to connect to the MySQL database
        private static readonly string _connectionString =
            "server=localhost;database=general_practitioner_db;user=root;password=;";

        // Method to get a new MySqlConnection
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
