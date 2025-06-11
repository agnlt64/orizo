using GestionBus;
using MySql.Data.MySqlClient;

namespace ParcoursBus
{
    // type alias pour les voisins
    using Voisins = List<(ArretBus, double)>;

    public class Arete
    {
        public ArretBus Depart { get; }
        public ArretBus Arrivee { get; }
        public double Poids { get; }
        public int IdLigne { get; }

        public Arete(ArretBus depart, ArretBus arrivee, double poids, int idLigne)
        {
            Depart = depart;
            Arrivee = arrivee;
            Poids = poids;
            IdLigne = idLigne;
        }
    }

    public class Graphe
    {
        private List<ArretBus> arrets = [];
        private List<Arete> aretes = new();

        public List<ArretBus> Arrets => arrets; // propriété pour accéder à la liste des arrêts

        // liste d'adjacence (arret, voisins)
        private Dictionary<ArretBus, Voisins> adjacence = new();

        public Graphe()
        {
            arrets = new List<ArretBus>();
            adjacence = new Dictionary<ArretBus, Voisins>();
        }

        public Graphe(List<ArretBus> arrets, List<Arete> aretes)
        {
            this.arrets = arrets;
            this.aretes = aretes;
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

        public int? GetLigneEntre(ArretBus depart, ArretBus arrivee)
        {
            var arete = aretes.FirstOrDefault(a => a.Depart.Equals(depart) && a.Arrivee.Equals(arrivee));
            return arete?.IdLigne;
        }

        public double? GetPoidsEntre(ArretBus depart, ArretBus arrivee)
        {
            var arete = aretes.FirstOrDefault(a => a.Depart.Equals(depart) && a.Arrivee.Equals(arrivee));
            return arete?.Poids;
        }

        public List<ArretBus>? Dijkstra(ArretBus depart, ArretBus arrivee)
        {
            Console.WriteLine($"Calcul du chemin de {depart.Nom} à {arrivee.Nom}");
            Dictionary<ArretBus, double> distances = [];
            Dictionary<ArretBus, ArretBus?> precedent = [];
            HashSet<ArretBus> nonVisites = [.. arrets];

            // initialisation des distances et précédents
            foreach (ArretBus arret in arrets)
            {
                distances[arret] = double.PositiveInfinity;
                precedent[arret] = null;
            }
            distances[depart] = 0;

            while (nonVisites.Count > 0)
            {
                // trouver l'arrêt avec la distance minimale parmi les non visités
                var courant = nonVisites.OrderBy(a => distances[a]).First();
                nonVisites.Remove(courant);

                if (courant == arrivee) break;

                // si le sommet courant n'a pas de voisins, on passe au suivant
                Voisins? voisins = GetVoisins(courant);
                if (voisins == null) continue;

                foreach (var (voisin, poids) in voisins)
                {
                    if (!nonVisites.Contains(voisin)) continue;
                    // calcul de la distance avec lle poids de l'arete
                    // si la distance est plus courte, on met à jour
                    double distance = distances[courant] + poids;
                    if (distance < distances[voisin])
                    {
                        distances[voisin] = distance;
                        precedent[voisin] = courant;
                    }
                }
            }
            Console.WriteLine("Distances calculées :");
            foreach (var kvp in distances)
            {
                Console.WriteLine($"{kvp.Key.Nom}: {kvp.Value} minutes");
            }

            List<ArretBus> chemin = [];
            ArretBus? temp = arrivee;
            // reconstruction du chemin à partir des précédents
            while (temp != null)
            {
                chemin.Insert(0, temp);
                temp = precedent[temp];
            }
            // si le premier arrêt du chemin n'est pas le départ, il n'y a pas de chemin valide
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

        public static Graphe ConstruireDepuisBDD()
        {
            // Récupérer tous les arrêts
            var arrets = BD.GetArrets();

            // Création d'un dictionnaire pour accès rapide par ID
            var arretsDict = arrets.ToDictionary(a => a.Id);

            var aretes = new List<Arete>();

            // Charger les liaisons depuis LigneArret
            string requeteLignes = @"
                SELECT IDLigne, IDArret, OrdrePassage, EcartArretPrecedent
                FROM LigneArret
                ORDER BY IDLigne, OrdrePassage;
            ";

            using (var cmd = new MySqlCommand(requeteLignes, BD.GetConnection()))
            using (var reader = cmd.ExecuteReader())
            {
                int? idLigneCourante = null;
                int? arretPrecedent = null;

                while (reader.Read())
                {
                    int idLigne = reader.GetInt32("IDLigne");
                    int idArret = reader.GetInt32("IDArret");
                    TimeSpan ecart = reader.GetTimeSpan("EcartArretPrecedent");

                    if (idLigneCourante != idLigne)
                    {
                        idLigneCourante = idLigne;
                        arretPrecedent = null;
                    }

                    if (arretPrecedent.HasValue)
                    {
                        if (arretsDict.ContainsKey(arretPrecedent.Value) && arretsDict.ContainsKey(idArret))
                        {
                            var depart = arretsDict[arretPrecedent.Value];
                            var arrivee = arretsDict[idArret];
                            double poids = ecart.TotalMinutes;

                            aretes.Add(new Arete(depart, arrivee, poids, idLigne));
                        }
                    }

                    arretPrecedent = idArret;
                }
            }

            return new Graphe(arrets, aretes);
        }
    }
}
