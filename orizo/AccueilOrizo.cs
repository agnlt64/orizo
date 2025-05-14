namespace orizo
{
    public partial class AccueilOrizo : Form
    {
        public AccueilOrizo()
        {
            InitializeComponent();
        }

        private void btnConsulterAccueil_Click(object sender, EventArgs e)
        {
            Consulter frmConsulter;
            frmConsulter = new Consulter();
            frmConsulter.Show();
        }

        private void btnAdminAccueil_Click(object sender, EventArgs e)
        {
            Administrer frmAdministrer;
            frmAdministrer = new Administrer();
            frmAdministrer.Show();
        }

        private void AccueilOrizo_Load(object sender, EventArgs e)
        {

        }
    }
}
