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
    public partial class AdministrerSuiteAjout : Form
    {
        public AdministrerSuiteAjout()
        {
            InitializeComponent();
        }

        private void btnRetourAdministrerAjout_Click(object sender, EventArgs e)
        {
            AdministrerMenuSuite frmAdministrerMenuSuite = new AdministrerMenuSuite();
            frmAdministrerMenuSuite.Show();  // Corrected line
            this.Close();
        }
    }
}
