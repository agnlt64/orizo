
namespace GestionBus
{
    // type alias pour les voisins
    using Voisins = List<(ArretBus, double)>;

    class Arete
    {
        public ArretBus Depart { get; }
        public ArretBus Arrivee { get; }
        public double Poids { get; }

        public Arete(ArretBus depart, ArretBus arrivee, double poids)
        {
            Depart = depart;
            Arrivee = arrivee;
            Poids = poids;
        }
    }

    class AlgoParcours
    {
        private List<ArretBus> arrets = [];
        // Adjacency list: for each ArretBus, a list of (neighbor, weight)
        private Dictionary<ArretBus, Voisins> adjacence = new();

        public AlgoParcours()
        {
            arrets = new List<ArretBus>();
            adjacence = new Dictionary<ArretBus, Voisins>();
        }

        public AlgoParcours(List<ArretBus> arrets, List<Arete> aretes)
        {
            this.arrets = arrets;
            adjacence = new Dictionary<ArretBus, Voisins>();
            // liste d'adjacence initialisée pour chaque arret
            foreach (var arret in arrets)
                adjacence[arret] = new Voisins();

            // ajout des aretes
            foreach (var arete in aretes)
                AjouterArete(arete);
        }

        public void AjouterArete(Arete arete)
        {
            if (!adjacence.ContainsKey(arete.Depart))
                adjacence[arete.Depart] = new Voisins();
            adjacence[arete.Depart].Add((arete.Arrivee, arete.Poids));
        }

        public void AfficherArrets()
        {
            foreach (ArretBus arret in arrets)
            {
                Console.WriteLine($"Nom: {arret.Nom}, Position: ({arret.Latitude}, {arret.Longitude})");
            }
        }

        public Voisins? GetVoisins(ArretBus arret)
        {
            // Retourne la liste des voisins à partir de la liste d'adjacence
            return adjacence.TryGetValue(arret, out var voisins) ? voisins : null;
        }

        public List<ArretBus>? Dijkstra(ArretBus depart, ArretBus arrivee)
        {
            Dictionary<ArretBus, double> distances = [];
            Dictionary<ArretBus, ArretBus?> precedent = [];
            HashSet<ArretBus> nonVisites = [.. arrets];

            foreach (ArretBus arret in arrets)
            {
                distances[arret] = double.PositiveInfinity;
                precedent[arret] = null;
            }
            distances[depart] = 0;

            while (nonVisites.Count > 0)
            {
                var courant = nonVisites.OrderBy(a => distances[a]).First();
                nonVisites.Remove(courant);

                if (courant == arrivee) break;

                Voisins? voisins = GetVoisins(courant);
                if (voisins == null) continue;

                foreach (var (voisin, poids) in voisins)
                {
                    if (!nonVisites.Contains(voisin)) continue;
                    double distance = distances[courant] + poids;
                    if (distance < distances[voisin])
                    {
                        distances[voisin] = distance;
                        precedent[voisin] = courant;
                    }
                }
            }

            List<ArretBus> chemin = [];
            ArretBus? temp = arrivee;
            while (temp != null)
            {
                chemin.Insert(0, temp);
                temp = precedent[temp];
            }
            if (chemin.First() != depart) return null;
            return chemin;
        }

        public List<ArretBus>? Dijkstra(string nomDepart, string nomArrivee)
        {
            ArretBus? depart = arrets.Find(a => a.Nom == nomDepart);
            ArretBus? arrivee = arrets.Find(a => a.Nom == nomArrivee);
            if (depart == null || arrivee == null) return null;

            return Dijkstra(depart, arrivee);
        }
    }
}
