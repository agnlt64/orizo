using GestionBus;

namespace orizo
{
    public partial class AdministrerModifLigne : Form
    {
        private List<LigneBus> lignes;
        private List<ArretBus> arrets;

        public AdministrerModifLigne()
        {
            InitializeComponent();
            arrets = BD.GetArrets();
            lignes = BD.GetLignes();

            ChargerArrets();
            ChargerLignes();
        }

        private void ChargerArrets()
        {
            // todo charger les arrets de la ligne sélectionnée
            lstArrets.Items.Clear();
            foreach (var arret in arrets)
            {
                lstArrets.Items.Add(arret.Nom);
            }
        }

        private void ChargerLignes()
        {
            cmbNomLigne.Items.Clear();
            foreach (var ligne in lignes)
            {
                cmbNomLigne.Items.Add(ligne.Nom);
            }
        }

        private void btnRetourModifLigne_Click(object sender, EventArgs e)
        {
            AdministrerSuiteModif frmAdministrerSuiteModif = new AdministrerSuiteModif();
            frmAdministrerSuiteModif.Show();
            this.Close();
        }

        private void btnCouleur_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnCouleur.BackColor = colorDialog1.Color;
            }
        }
    }
}
