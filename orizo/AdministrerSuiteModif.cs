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
    public partial class AdministrerSuiteModif : Form
    {
        public AdministrerSuiteModif()
        {
            InitializeComponent();
        }

        private void btnRetourAdministrerModif_Click(object sender, EventArgs e)
        {
            AdministrerMenuSuite frmAdministrerMenuSuite = new AdministrerMenuSuite();
            frmAdministrerMenuSuite.Show();  // Corrected line
            this.Close();
        }
    }
}
