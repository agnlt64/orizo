using GestionBus;

namespace orizo
{
    public partial class AdministrerModifArret : Form
    {
        List<ArretBus> arrets;

        public AdministrerModifArret()
        {
            InitializeComponent();

            arrets = BD.GetArrets();
            ChargerArrets();

            btnModifArretEnregistrer.Enabled = false;

            txtNomModif.TextChanged += VerifierChamps;
            txtLatitudeModif.TextChanged += VerifierChamps;
            txtLongitudeModif.TextChanged += VerifierChamps;
            lstModifArret.SelectedIndexChanged += VerifierChamps;
        }

        private void ChargerArrets()
        {
            lstModifArret.Items.Clear();

            foreach (ArretBus arret in arrets)
            {
                lstModifArret.Items.Add(arret.Nom);
            }
        }

        private void btnRetourModifArret_Click(object sender, EventArgs e)
        {
            AdministrerSuiteModif frmAdministrerSuiteModif = new AdministrerSuiteModif();
            frmAdministrerSuiteModif.Show();
            this.Close();
        }

        private void VerifierChamps(object sender, EventArgs e)
        {
            bool tousChampsRemplis =
                !string.IsNullOrWhiteSpace(txtNomModif.Text) &&
                double.TryParse(txtLatitudeModif.Text, out _) &&
                double.TryParse(txtLongitudeModif.Text, out _);

            bool elementSelectionne = lstModifArret.SelectedIndex != -1;

            btnModifArretEnregistrer.Enabled = tousChampsRemplis && elementSelectionne;
        }

        private void btnModifArretEnregistrer_Click(object sender, EventArgs e)
        {
            string nouveauNom = txtNomModif.Text;
            double nouvelleLatitude = Convert.ToDouble(txtLatitudeModif.Text);
            double nouvelleLongitude = Convert.ToDouble(txtLongitudeModif.Text);
            ArretBus arretSelectionne = arrets[lstModifArret.SelectedIndex];

            if (BD.ModifierArret(arretSelectionne, nouveauNom, nouvelleLatitude, nouvelleLongitude))
            {
                MessageBox.Show("L'arrêt a été modifié avec succès.");
                arrets = BD.GetArrets();
                ChargerArrets();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue lors de la modification de l'arrêt.");
            }
        }

        private void lblLatitudeModif_Click(object sender, EventArgs e)
        {

        }
    }
}
