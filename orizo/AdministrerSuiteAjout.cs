
namespace orizo
{
    public partial class AdministrerSuiteAjout : Form
    {
        public AdministrerSuiteAjout()
        {
            InitializeComponent();
        }

        private void btnRetourAdministrerAjout_Click(object sender, EventArgs e)
        {
            AdministrerMenuSuite frmAdministrerMenuSuite = new AdministrerMenuSuite();
            frmAdministrerMenuSuite.Show();  // Corrected line
            this.Close();
        }

        private void btnAdminAjoutArret_Click(object sender, EventArgs e)
        {
            AdministrerAjouterArret frmAdministrerAjouterArret;
            frmAdministrerAjouterArret = new AdministrerAjouterArret();
            frmAdministrerAjouterArret.Show();
            this.Close();
        }

        private void btnAdminAjoutLigne_Click(object sender, EventArgs e)
        {
            AdministrerAjouterLigne frmAdministrerAjouterLigne;
            frmAdministrerAjouterLigne = new AdministrerAjouterLigne();
            frmAdministrerAjouterLigne.Show();
            this.Close();
        }
    }
}
