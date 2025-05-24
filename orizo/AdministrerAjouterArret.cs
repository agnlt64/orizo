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
            MessageBox.Show("Arrêt ajouté à la base", "Alerte");
        }
    }
}
