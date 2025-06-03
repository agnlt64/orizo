using GestionBus;

namespace orizo
{
    public partial class AdministrerAjouterArret : Form
    {
        public AdministrerAjouterArret()
        {
            InitializeComponent();
            btnAjouterArret.Enabled = false;
            txtNom.TextChanged += VerifierChamps;
            txtLatitude.TextChanged += VerifierChamps;
            txtLongitude.TextChanged += VerifierChamps;
        }

        private void btnRetourAjoutArret_Click(object sender, EventArgs e)
        {
            AdministrerSuiteAjout frmAdministrerSuiteAjout = new AdministrerSuiteAjout();
            frmAdministrerSuiteAjout.Show();  
            this.Close();
        }

        private void VerifierChamps(object sender, EventArgs e)
        {
            
            if (txtNom.Text != "" &&
                double.TryParse(txtLatitude.Text, out _) &&
                double.TryParse(txtLongitude.Text, out _))
            {
                btnAjouterArret.Enabled = true;
            }
            else
            {
                btnAjouterArret.Enabled = false;
            }
        }

        private void btnAjouterArret_Click(object sender, EventArgs e)
        {
            ArretBus arret = new ArretBus(0, txtNom.Text, Convert.ToDouble(txtLatitude.Text), Convert.ToDouble(txtLongitude.Text));
            if (BD.AjouterArret(arret))
                MessageBox.Show("Arrêt ajouté à la base", "Alerte");
            else
                MessageBox.Show("Erreur lors de l'ajout de l'arrêt", "Alerte");
        }
    }
}
