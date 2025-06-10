using GestionBus;

namespace orizo
{
    public partial class ConsulterLigne : Form
    {
        private int indexSelectionne;
        private string nomLigne;
        private List<ArretBus> arrets;


        public ConsulterLigne(int indexSelectionne, string nomLigne)
        {
            InitializeComponent();
            this.indexSelectionne = indexSelectionne;
            this.nomLigne = nomLigne;
            btnRetour.Visible = true; // Afficher le bouton de retour

            // +1 parce que les IDs de la BDD commencent à 1
            arrets = BD.GetArrets(indexSelectionne + 1);
            AfficherDetails();
        }

        private void AfficherDetails()
        {
            lswTableau.Clear(); // Réinitialiser les colonnes et les items

            // Configuration du ListView
            lswTableau.View = View.Details;
            lswTableau.FullRowSelect = true;
            lswTableau.GridLines = true;

            // Ajouter les colonnes
            lswTableau.Columns.Add("Ordre de passage");
            lswTableau.Columns.Add("Arrêt");

            for (int i = 0; i < arrets.Count; i++)
            {
                lswTableau.Items.Add(new ListViewItem([(i + 1).ToString(), arrets[i].Nom]));
            }

            // Ajuster la largeur des colonnes (1/2 pour chacune ici)
            int totalWidth = lswTableau.ClientSize.Width;
            if (lswTableau.Columns.Count >= 2)
            {
                lswTableau.Columns[0].Width = totalWidth / 2;
                lswTableau.Columns[1].Width = totalWidth / 2;
            }

            lblIndication.Text = $"Ligne {nomLigne}";
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            Consulter formConsulter = new Consulter();
            formConsulter.Show();
            this.Hide();
        }

        private void ConsulterLigne_Load(object sender, EventArgs e)
        {

        }
    }
}
