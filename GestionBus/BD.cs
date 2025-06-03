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

        public static List<ArretBus> GetArrets()
        {
            List<ArretBus> arrets = [];

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
                        ArretBus arret = new(id, nom, latitude, longitude);
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

        public static bool AjouterArret(ArretBus arret)
        {
            string query = "INSERT INTO Arret (NomArret, CoordXArret, CoordYArret) VALUES (@nom, @lat, @long)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nom", arret.Nom);
            cmd.Parameters.AddWithValue("@lat", arret.Latitude);
            cmd.Parameters.AddWithValue("@long", arret.Longitude);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error adding stop: {ex.Message}");
            }
            return false;
        }

        public static bool AjouterLigne(LigneBus ligne)
        {
            string query = "INSERT INTO Ligne (NomLigne, CouleurLigne, NbPassagesJour, HeureDepart) VALUES (@nom, @couleur, @nbPassages, @heureDepart)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nom", ligne.Nom);
            cmd.Parameters.AddWithValue("@couleur", ligne.Couleur);
            cmd.Parameters.AddWithValue("@nbPassages", ligne.NbPassages);
            cmd.Parameters.AddWithValue("@heureDepart", ligne.HeureDepart);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error adding line: {ex.Message}");
            }
            return false;
        }

        public static bool ModifierArret(ArretBus original, string nom, double latitude, double longitude)
        {
            string query = "UPDATE Arret SET NomArret = @nom, CoordXArret = @lat, CoordYArret = @long WHERE IDArret = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", original.Id);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@lat", latitude);
            cmd.Parameters.AddWithValue("@long", longitude);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error modifying stop: {ex.Message}");
            }
            return false;
        }

        public static bool SupprimerLigne(LigneBus ligne)
        {
            string query = "DELETE FROM Ligne WHERE IDLigne = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", ligne.Id);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error deleting line: {ex.Message}");
            }
            return false;
        }

        public static bool SupprimerArret(ArretBus arret)
        {
            string query = "DELETE FROM Arret WHERE IDArret = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", arret.Id);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error deleting stop: {ex.Message}");
            }
            return false;
        }
    }
}
