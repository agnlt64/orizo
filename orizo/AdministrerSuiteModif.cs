
namespace orizo
{
    public partial class AdministrerSuiteModif : Form
    {
        public AdministrerSuiteModif()
        {
            InitializeComponent();
        }

        private void btnRetourAdministrerModif_Click(object sender, EventArgs e)
        {
            AdministrerMenuSuite frmAdministrerMenuSuite = new AdministrerMenuSuite();
            frmAdministrerMenuSuite.Show();  // Corrected line
            this.Close();
        }

        private void btnAdminModifierArret_Click(object sender, EventArgs e)
        {
            AdministrerModifArret frmAdministrerModifArret;
            frmAdministrerModifArret = new AdministrerModifArret();
            frmAdministrerModifArret.Show();
            this.Close();
        }

        private void btnAdminModifierLigne_Click(object sender, EventArgs e)
        {
            AdministrerModifLigne frmAdministrerModifLigne;
            frmAdministrerModifLigne = new AdministrerModifLigne();
            frmAdministrerModifLigne.Show();
            this.Close();
        }
    }
}
