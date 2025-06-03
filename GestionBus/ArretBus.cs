
namespace GestionBus
{
    public class ArretBus
    {
        int id;
        string nom;
        double latitude;
        double longitude;

        public int Id => id;
        public string Nom => nom;
        public double Latitude => latitude;
        public double Longitude => longitude;

        public ArretBus(int id, string nom, double latitude, double longitude)
        {
            this.id = id;
            this.nom = nom;
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
