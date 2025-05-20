using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           
            string identifiantCorrect = "admin";
            string motDePasseCorrect = "1234";

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
                MessageBox.Show("Erreur : mauvais identifiant ou mot de passe");
            }
        }

        private void txtIdAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMdpAdmin_TextChanged(object sender, EventArgs e)
        {

        }
        private void VerifierChamps(object sender, EventArgs e)
        {
            btnAdminConnexion.Enabled =
                !string.IsNullOrWhiteSpace(txtIdAdmin.Text) &&
                !string.IsNullOrWhiteSpace(txtMdpAdmin.Text);
        }
    }
}
