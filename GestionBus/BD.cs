using MySql.Data.MySqlClient;
using System.Data;

namespace GestionBus
{
    public static class BD
    {
        private static MySqlConnection conn;

        public static bool Connect()
        {
            string server = "10.1.139.236";
            string database = "basee1";
            string uid = "e1";
            string password = "skibidi";
            string connectionString = $"Server={server};Database={database};Uid={uid};Pwd={password};";
            conn = new(connectionString);

            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}");
                return false;
            }
        }

        public static bool Disconnect()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                try
                {
                    conn.Close();
                    conn.Dispose();
                    MessageBox.Show("Disconnected from the database successfully.");
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error disconnecting from the database: {ex.Message}");
                    return false;
                }
            }
            return false;
        }
    }
}
