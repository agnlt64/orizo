namespace GestionBus
{
    public class LigneBus
    {
        string nom;
        string couleur;
        int id;
        int nbPassages;
        TimeSpan heureDepart;

        public string Nom => nom;
        public string Couleur => couleur;
        public int Id { get => id; set { id = value; } }
        public int NbPassages => nbPassages;
        public TimeSpan HeureDepart => heureDepart;
        
        public LigneBus(int id, string nom, string couleur, int nbPassages, TimeSpan heureDepart)
        {
            this.id = id;
            this.nom = nom;
            this.couleur = couleur;
            this.nbPassages = nbPassages;
            this.heureDepart = heureDepart;
        }
    }
}
