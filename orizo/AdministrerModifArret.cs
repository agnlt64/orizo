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
    public partial class AdministrerModifArret : Form
    {
        public AdministrerModifArret()
        {
            InitializeComponent();
            InitializeComponent();

            btnModifArretEnregistrer.Enabled = false;

            txtNomModif.TextChanged += VerifierChamps;
            txtLatitudeModif.TextChanged += VerifierChamps;
            txtLongitudeModif.TextChanged += VerifierChamps;
            lstModifArret.SelectedIndexChanged += VerifierChamps; // Ajouté
        }

        private void btnRetourModifArret_Click(object sender, EventArgs e)
        {
            AdministrerSuiteModif frmAdministrerSuiteModif = new AdministrerSuiteModif();
            frmAdministrerSuiteModif.Show();
            this.Close();
        }
        private void VerifierChamps(object sender, EventArgs e)
        {
            bool tousChampsRemplis =
                !string.IsNullOrWhiteSpace(txtNomModif.Text) &&
                double.TryParse(txtLatitudeModif.Text, out _) &&
                double.TryParse(txtLongitudeModif.Text, out _);

            bool elementSelectionne = lstModifArret.SelectedIndex != -1;

            btnModifArretEnregistrer.Enabled = tousChampsRemplis && elementSelectionne;
        }

        private void btnModifArretEnregistrer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arrêt modifié avec succès", "Alerte");
        }
    }
}
