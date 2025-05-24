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
    public partial class AdministrerSupLigne : Form
    {
        public AdministrerSupLigne()
        {
            InitializeComponent();
            btnSupLigne.Enabled = false;
        }

        private void btnSupLigne_Click(object sender, EventArgs e)
        {
            if (lstSupLigne.SelectedIndex != -1)
            {
                string arretSelectionne = lstSupLigne.SelectedItem.ToString();

                DialogResult confirmation = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer l'arrêt : \"{arretSelectionne}\" ?",
                    "Alerte",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation == DialogResult.Yes)
                {
                    lstSupLigne.Items.RemoveAt(lstSupLigne.SelectedIndex);

                    MessageBox.Show(
                        "Arrêt supprimé",
                        "Alerte",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                btnSupLigne.Enabled = lstSupLigne.SelectedIndex != -1;
            }
        }

        private void lstSupLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupLigne.Enabled = lstSupLigne.SelectedIndex != -1;
        }

        private void btnRetourSupLigne_Click(object sender, EventArgs e)
        {
            AdministrerSuiteSup frmAdministrerSuiteSup = new AdministrerSuiteSup();
            frmAdministrerSuiteSup.Show();  // Corrected line
            this.Close();
        }
    }
}
