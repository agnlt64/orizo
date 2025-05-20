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
    public partial class AdministrerMenuSuite : Form
    {
        public AdministrerMenuSuite()
        {
            InitializeComponent();
        }

        private void btnRetourAdministrer_Click(object sender, EventArgs e)
        {
            Administrer frmAdministrer = new Administrer();
            frmAdministrer.Show();  // Corrected line
            this.Hide();
        }

        private void btnAdminAjouterData_Click(object sender, EventArgs e)
        {
            AdministrerSuiteAjout frmAdministrerSuiteAjout;
            frmAdministrerSuiteAjout = new AdministrerSuiteAjout();
            frmAdministrerSuiteAjout.Show();
            this.Hide();
        }

        private void btnAdminModifData_Click(object sender, EventArgs e)
        {
            AdministrerSuiteModif frmAdministrerSuiteModif;
            frmAdministrerSuiteModif = new AdministrerSuiteModif();
            frmAdministrerSuiteModif.Show();
            this.Hide();
        }

        private void btnAdminSupData_Click(object sender, EventArgs e)
        {
            AdministrerSuiteSup frmAdministrerSuiteSup;
            frmAdministrerSuiteSup = new AdministrerSuiteSup();
            frmAdministrerSuiteSup.Show();
            this.Hide();
        }
    }
}
