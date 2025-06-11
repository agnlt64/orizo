using GestionBus;

namespace orizo
{

    public partial class AdministrerAjouterLigne : Form
    {
        private List<ArretBus> arrets = [];
        private List<ArretBus> nouveauxArrets = [];

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
            if (BD.AjouterLigne(ref ligne))
            {
                MessageBox.Show("Ligne ajoutée à la base", "Alerte");
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de la ligne", "Alerte");
            }

            for (int i = 0; i < nouveauxArrets.Count; i++)
            {
                ArretBus arret = nouveauxArrets[i];
                if (!BD.AjouterLigneArret(ligne.Id, arret.Id, i + 1, arret.Ecart))
                {
                    MessageBox.Show($"Erreur lors de l'ajout de l'arrêt {arret.Nom} à la ligne {ligne.Nom}", "Alerte");
                }
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
            string? nomArret = (string?)cmbArrets.SelectedItem;
            if (nomArret == null)
            {
                MessageBox.Show("Veuillez sélectionner un arrêt", "Alerte");
                return;
            }
            lstArrets.Items.Add(nomArret);
            int nbHeures = (int)nudArretHeures.Value;
            int nbMinutes = (int)nudArretMinutes.Value;
            TimeSpan ecart = new TimeSpan(nbHeures, nbMinutes, 0);
            ArretBus arret = arrets.FirstOrDefault(a => a.Nom == nomArret)!;
            arret.Ecart = ecart;
            nouveauxArrets.Add(arret);
        }
    }
}
