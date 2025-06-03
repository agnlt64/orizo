
namespace orizo
{
    public partial class AdministrerSuiteSup : Form
    {
        public AdministrerSuiteSup()
        {
            InitializeComponent();
        }

        private void btnAdminSupArret_Click(object sender, EventArgs e)
        {
            AdministrerSupArret frmAdministrerSupArret;
            frmAdministrerSupArret = new AdministrerSupArret();
            frmAdministrerSupArret.Show();
            this.Close();
        }

        private void btnRetourAdministrerSup_Click(object sender, EventArgs e)
        {
            AdministrerMenuSuite frmAdministrerMenuSuite = new AdministrerMenuSuite();
            frmAdministrerMenuSuite.Show();  // Corrected line
            this.Close();
        }

        private void btnAdminSupLigne_Click(object sender, EventArgs e)
        {
            AdministrerSupLigne frmAdministrerSupLigne;
            frmAdministrerSupLigne = new AdministrerSupLigne();
            frmAdministrerSupLigne.Show();
            this.Close();
        }
    }
}
