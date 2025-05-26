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
    public partial class AdministrerAjouterLigne : Form
    {
        public AdministrerAjouterLigne()
        {
            InitializeComponent();
        }

        private void btnRetourAjoutLigne_Click(object sender, EventArgs e)
        {
            AdministrerSuiteAjout frmAdministrerSuiteAjout = new AdministrerSuiteAjout();
            frmAdministrerSuiteAjout.Show();
            this.Close();
        }
    }
}
