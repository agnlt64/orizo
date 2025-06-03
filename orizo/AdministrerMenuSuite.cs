
namespace orizo
{
    public partial class AdministrerMenuSuite : Form
    {
        public AdministrerMenuSuite()
        {
            InitializeComponent();
        }

        private void btnRetourAdministrer_Click(object sender, EventArgs e)
        {
            Administrer frmAdministrer = new Administrer();
            frmAdministrer.Show();  // Corrected line
            this.Close();
        }

        private void btnAdminAjouterData_Click(object sender, EventArgs e)
        {
            AdministrerSuiteAjout frmAdministrerSuiteAjout;
            frmAdministrerSuiteAjout = new AdministrerSuiteAjout();
            frmAdministrerSuiteAjout.Show();
            this.Close();
        }

        private void btnAdminModifData_Click(object sender, EventArgs e)
        {
            AdministrerSuiteModif frmAdministrerSuiteModif;
            frmAdministrerSuiteModif = new AdministrerSuiteModif();
            frmAdministrerSuiteModif.Show();
            this.Close();
        }

        private void btnAdminSupData_Click(object sender, EventArgs e)
        {
            AdministrerSuiteSup frmAdministrerSuiteSup;
            frmAdministrerSuiteSup = new AdministrerSuiteSup();
            frmAdministrerSuiteSup.Show();
            this.Close();
        }
    }
}
