using GestionBus;

namespace orizo
{
    public partial class AdministrerSupLigne : Form
    {
        private List<LigneBus> lignes;

        public AdministrerSupLigne()
        {
            InitializeComponent();
            lignes = BD.GetLignes();
            ChargerLignes();
            btnSupLigne.Enabled = false;
        }

        private void ChargerLignes()
        {
            lstSupLigne.Items.Clear();
            foreach (LigneBus ligne in lignes)
            {
                lstSupLigne.Items.Add(ligne.Nom);
            }
        }

        private void btnSupLigne_Click(object sender, EventArgs e)
        {
            if (lstSupLigne.SelectedIndex != -1)
            {
                LigneBus ligneSelectionnee = lignes[lstSupLigne.SelectedIndex];

                DialogResult confirmation = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer la ligne : \"{ligneSelectionnee.Nom}\" ?",
                    "Alerte",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation == DialogResult.Yes)
                {
                    if (BD.SupprimerLigne(ligneSelectionnee))
                    {
                        lignes = BD.GetLignes();
                        ChargerLignes();

                        MessageBox.Show(
                            "Ligne supprimée",
                            "Alerte",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Une erreur est survenue lors de la suppression de la ligne.",
                            "Erreur",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }

                btnSupLigne.Enabled = lstSupLigne.SelectedIndex != -1;
            }
        }

        private void lstSupLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupLigne.Enabled = lstSupLigne.SelectedIndex != -1;
        }

        private void btnRetourSupLigne_Click(object sender, EventArgs e)
        {
            AdministrerSuiteSup frmAdministrerSuiteSup = new AdministrerSuiteSup();
            frmAdministrerSuiteSup.Show();  // Corrected line
            this.Close();
        }
    }
}
