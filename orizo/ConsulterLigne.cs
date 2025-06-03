
namespace orizo
{
    public partial class ConsulterLigne : Form
    {
        private int indexSelectionne;


        public ConsulterLigne(int indexSelectionne)
        {
            InitializeComponent();
            this.indexSelectionne = indexSelectionne;
            btnRetour.Visible = true; // Afficher le bouton de retour
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
            lswTableau.Columns.Add("Arrêt");
            lswTableau.Columns.Add("Horaires");

            // Ajouter les lignes selon l'index
            if (indexSelectionne == 0)
            {
                lswTableau.Items.Add(new ListViewItem(new[] { "Arrêt 1", "9h - 9h30" }));
                lswTableau.Items.Add(new ListViewItem(new[] { "Arrêt 2", "8h - 10h" }));
            }
            else if (indexSelectionne == 1)
            {
                lswTableau.Items.Add(new ListViewItem(new[] { "Arrêt 1", "19h - 20h30" }));
                lswTableau.Items.Add(new ListViewItem(new[] { "Arrêt 2", "20h - 22h" }));
            }
            else
            {
                MessageBox.Show("Ligne indisponible", "Erreur", MessageBoxButtons.OK);
                lswTableau.Items.Add(new ListViewItem(new[] { "Erreur", "Erreur" }));
            }

            // Ajuster la largeur des colonnes (1/2 pour chacune ici)
            int totalWidth = lswTableau.ClientSize.Width;
            if (lswTableau.Columns.Count >= 2)
            {
                lswTableau.Columns[0].Width = totalWidth / 2;
                lswTableau.Columns[1].Width = totalWidth / 2;
            }

            lblIndication.Text = "Ligne " + (indexSelectionne + 1);
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
