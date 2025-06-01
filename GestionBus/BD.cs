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

        public static List<LigneBus> GetLignes()
        {
            List<LigneBus> lignes = [];
            
            string query = "SELECT * FROM Ligne";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("IDLigne");
                        string nom = reader.GetString("NomLigne");
                        string color = reader.GetString("CouleurLigne");
                        int nbPassagesJour = reader.GetInt32("NbPassagesJour");
                        TimeSpan heureDepart = reader.GetTimeSpan("HeureDepart");
                        string couleur = reader.GetString("CouleurLigne");
                        LigneBus ligne = new(id, nom, couleur, nbPassagesJour, heureDepart);
                        lignes.Add(ligne);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error retrieving lines: {ex.Message}");
            }
            return lignes;
        }

        public static List<BusArret> GetArrets()
        {
            List<BusArret> arrets = [];

            string query = "SELECT * FROM Arret";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("IDArret");
                        string nom = reader.GetString("NomArret");
                        double latitude = reader.GetDouble("CoordXArret");
                        double longitude = reader.GetDouble("CoordYArret");
                        BusArret arret = new(id, nom, latitude, longitude);
                        arrets.Add(arret);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error retrieving stops: {ex.Message}");
            }
            return arrets;
        }
    }
}
