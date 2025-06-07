using GestionBus;

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

        private TimeSpan ConvertToTimeSpan()
        {
            int heures = (int)nudHeure1erAjout.Value;
            int min = (int)nudMin1erAjout.Value;
            return new TimeSpan(heures, min, 0);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            LigneBus ligne = new LigneBus(0, txtNomAjoutLigne.Text, "", Convert.ToInt32(nudNbPassageAjout.Value), ConvertToTimeSpan());
            if (BD.AjouterLigne(ligne))
            {
                MessageBox.Show("Ligne ajoutée à la base", "Alerte");
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de la ligne", "Alerte");
            }
        }

        private void lblFrequenceAjout_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
