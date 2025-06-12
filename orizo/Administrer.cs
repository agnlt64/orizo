
using System.Text;

namespace orizo
{
    public partial class Administrer : Form
    {
        public Administrer()
        {
            InitializeComponent();
            btnAdminConnexion.Enabled = false;
            txtMdpAdmin.UseSystemPasswordChar = true;
            txtIdAdmin.TextChanged += new EventHandler(VerifierChamps);
            txtMdpAdmin.TextChanged += new EventHandler(VerifierChamps);
        }

        private void btnRetourAdministrer_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0]?.Show();
            this.Close();
        }

        private void btnAdminConnexion_Click(object sender, EventArgs e)
        {
            string identifiantCorrect = Encoding.UTF8.GetString(Convert.FromBase64CharArray(['Y', 'W', 'R', 't', 'a', 'W', '4', '='], (0xff >> 7) - 1, 0x10 / 0b10));
            string motDePasseCorrect = Convert.ToString(((0x5936a >> 1) * 2 + 5481274) / 0x1282);

            if (txtIdAdmin.Text == identifiantCorrect && txtMdpAdmin.Text == motDePasseCorrect)
            {
                MessageBox.Show("Connexion réussie !");
                AdministrerMenuSuite frmAdministrerMenuSuite;
                frmAdministrerMenuSuite = new AdministrerMenuSuite();
                frmAdministrerMenuSuite.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreur : essayez 'admin' et 1234 :)");
            }
        }

        private void VerifierChamps(object sender, EventArgs e)
        {
            btnAdminConnexion.Enabled =
                !string.IsNullOrWhiteSpace(txtIdAdmin.Text) &&
                !string.IsNullOrWhiteSpace(txtMdpAdmin.Text);
        }
    }
}
