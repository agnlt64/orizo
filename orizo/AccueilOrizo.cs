using GestionBus;

namespace orizo
{
    public partial class AccueilOrizo : Form
    {
        public AccueilOrizo()
        {
            InitializeComponent();
            if (!BD.Connect())
            {
                MessageBox.Show("Erreur de connexion à la base de données.");
                Close();
                Application.Exit();
            }
        }

        private void btnConsulterAccueil_Click(object sender, EventArgs e)
        {
            Consulter frmConsulter;
            frmConsulter = new Consulter();
            frmConsulter.Show();
            this.Hide();
        }

        private void btnAdminAccueil_Click(object sender, EventArgs e)
        {
            Administrer frmAdministrer;
            frmAdministrer = new Administrer();
            frmAdministrer.Show();
            this.Hide();
        }

        private void AccueilOrizo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!BD.Disconnect())
            {
                MessageBox.Show("Erreur de déconnexion de la base de données.");
                e.Cancel = true; // Annule la fermeture du formulaire si la déconnexion échoue
            }
        }

        private void lblAccueilChoix_Click(object sender, EventArgs e)
        {

        }
    }
}
