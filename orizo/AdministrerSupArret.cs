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
    public partial class AdministrerSupArret : Form
    {
        public AdministrerSupArret()
        {
            InitializeComponent();
            btnSupArret.Enabled = false;
        }

        private void btnSupArret_Click(object sender, EventArgs e)
        {
            if (lstSupArret.SelectedIndex != -1)
            {
                string arretSelectionne = lstSupArret.SelectedItem.ToString();

                DialogResult confirmation = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer l'arrêt : \"{arretSelectionne}\" ?",
                    "Alerte",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation == DialogResult.Yes)
                {
                    lstSupArret.Items.RemoveAt(lstSupArret.SelectedIndex);

                    MessageBox.Show(
                        "Arrêt supprimé",
                        "Alerte",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                btnSupArret.Enabled = lstSupArret.SelectedIndex != -1;
            }
        }

        private void lstSupArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupArret.Enabled = lstSupArret.SelectedIndex != -1;
        }

        private void btnRetourSupArret_Click(object sender, EventArgs e)
        {
            AdministrerSuiteSup frmAdministrerSuiteSup = new AdministrerSuiteSup();
            frmAdministrerSuiteSup.Show();  // Corrected line
            this.Close();
        }
    }
}
