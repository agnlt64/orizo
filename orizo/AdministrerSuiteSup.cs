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
    public partial class AdministrerSuiteSup : Form
    {
        public AdministrerSuiteSup()
        {
            InitializeComponent();
        }

        private void btnAdminSupArret_Click(object sender, EventArgs e)
        {

        }

        private void btnRetourAdministrerSup_Click(object sender, EventArgs e)
        {
            AdministrerMenuSuite frmAdministrerMenuSuite = new AdministrerMenuSuite();
            frmAdministrerMenuSuite.Show();  // Corrected line
            this.Close();
        }
    }
}
