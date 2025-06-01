using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBus
{
    public class BusArret
    {
        int id;
        string nom;
        double latitude;
        double longitude;

        public int Id => id;
        public string Nom => nom;
        public double Latitude => latitude;
        public double Longitude => longitude;

        public BusArret(int id, string nom, double latitude, double longitude)
        {
            this.id = id;
            this.nom = nom;
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
