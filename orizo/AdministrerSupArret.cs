using GestionBus;

namespace orizo
{
    public partial class AdministrerSupArret : Form
    {
        private List<ArretBus> arrets;

        public AdministrerSupArret()
        {
            InitializeComponent();
            arrets = BD.GetArrets();
            ChargerArrets();
            btnSupArret.Enabled = false;
        }

        private void ChargerArrets()
        {
            lstSupArret.Items.Clear();
            foreach (ArretBus arret in arrets)
            {
                lstSupArret.Items.Add(arret.Nom);
            }
        }

        private void btnSupArret_Click(object sender, EventArgs e)
        {
            if (lstSupArret.SelectedIndex != -1)
            {
                ArretBus arretSelectionne = arrets[lstSupArret.SelectedIndex];

                DialogResult confirmation = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer l'arrêt : \"{arretSelectionne.Nom}\" ?",
                    "Alerte",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation == DialogResult.Yes)
                {
                    if (BD.SupprimerArret(arretSelectionne))
                    {
                        arrets = BD.GetArrets();
                        ChargerArrets();

                        MessageBox.Show(
                            "Arrêt supprimé",
                            "Alerte",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Une erreur est survenue lors de la suppression de l'arrêt.",
                            "Erreur",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }

                btnSupArret.Enabled = lstSupArret.SelectedIndex != -1;
            }
        }

        private void lstSupArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupArret.Enabled = lstSupArret.SelectedIndex != -1;
        }

        private void btnRetourSupArret_Click(object sender, EventArgs e)
        {
            AdministrerSuiteSup frmAdministrerSuiteSup = new AdministrerSuiteSup();
            frmAdministrerSuiteSup.Show();
            this.Close();
        }
    }
}
