namespace orizo
{
    public partial class AdministrerModifLigne : Form
    {
        public AdministrerModifLigne()
        {
            InitializeComponent();
        }

        private void btnRetourModifLigne_Click(object sender, EventArgs e)
        {
            AdministrerSuiteModif frmAdministrerSuiteModif = new AdministrerSuiteModif();
            frmAdministrerSuiteModif.Show();
            this.Close();
        }
    }
}
