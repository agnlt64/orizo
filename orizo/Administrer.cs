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
        }

        private void btnRetourAdministrer_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0]?.Show();
            this.Close();
        }
    }
}
