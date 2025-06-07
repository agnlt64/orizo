using System.Windows.Forms;

namespace orizo
{
    public partial class AdministrerModifLigne : Form
    {
        public AdministrerModifLigne()
        {
            InitializeComponent();
        }

        private void btnRetourModifLigne_Click(object sender, EventArgs e)
        {
            AdministrerSuiteModif frmAdministrerSuiteModif = new AdministrerSuiteModif();
            frmAdministrerSuiteModif.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
            }
        }
    }
}
