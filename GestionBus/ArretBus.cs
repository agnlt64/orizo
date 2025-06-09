
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

        public override bool Equals(object? obj)
        {
            if (obj is not ArretBus other) return false;
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
