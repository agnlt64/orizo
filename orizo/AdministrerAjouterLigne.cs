using GestionBus;

namespace orizo
{
    using NouvelArret = Dictionary<string, TimeSpan>;

    public partial class AdministrerAjouterLigne : Form
    {
        private List<ArretBus> arrets = [];
        private List<NouvelArret> nouveauxArrets = [];

        public AdministrerAjouterLigne()
        {
            InitializeComponent();

            arrets = BD.GetArrets();
            ChargerArrets();
        }

        private void ChargerArrets()
        {
            cmbArrets.Items.Clear();
            foreach (ArretBus arret in arrets)
            {
                cmbArrets.Items.Add(arret.Nom);
            }
        }

        private void btnRetourAjoutLigne_Click(object sender, EventArgs e)
        {
            AdministrerSuiteAjout frmAdministrerSuiteAjout = new AdministrerSuiteAjout();
            frmAdministrerSuiteAjout.Show();
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int heures = (int)nudHeure1erAjout.Value;
            int min = (int)nudMin1erAjout.Value;
            LigneBus ligne = new LigneBus(0, txtNomAjoutLigne.Text, ColorTranslator.ToHtml(btnCouleur.BackColor), Convert.ToInt32(nudNbPassageAjout.Value), new TimeSpan(heures, min, 0));
            if (BD.AjouterLigne(ligne))
            {
                MessageBox.Show("Ligne ajoutée à la base", "Alerte");
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de la ligne", "Alerte");
            }
        }

        private void btnCouleur_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnCouleur.BackColor = colorDialog1.Color;
            }
        }

        private void btnAjouterArret_Click(object sender, EventArgs e)
        {
            string? arret = (string?)cmbArrets.SelectedItem;
            if (arret == null)
            {
                MessageBox.Show("Veuillez sélectionner un arrêt", "Alerte");
                return;
            }
            int nbHeures = (int)nudArretHeures.Value;
            int nbMinutes = (int)nudArretMinutes.Value;
            TimeSpan ecart = new TimeSpan(nbHeures, nbMinutes, 0);
            nouveauxArrets.Add(new NouvelArret { { arret, ecart } });
            lstArrets.Items.Add(arret);
            // utiliser la table LigneArret pour ajouter l'arrêt à la ligne
            // envoyer la valeur de l'écart avec l'arret d'avant
        }
    }
}
