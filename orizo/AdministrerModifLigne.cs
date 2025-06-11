using GestionBus;

namespace orizo
{
    public partial class AdministrerModifLigne : Form
    {
        private List<LigneBus> lignes;
        private List<ArretBus> arrets;
        // 2e tableau pour stocker les nouveaux arrêts à ajouter
        private List<ArretBus> nouveauxArrets;

        public AdministrerModifLigne()
        {
            InitializeComponent();
            arrets = BD.GetArrets();
            nouveauxArrets = [];
            lignes = BD.GetLignes();

            ChargerLignes();
            ChargerArrets();
        }

        private void ChargerLignes()
        {
            cmbNomLigne.Items.Clear();
            foreach (var ligne in lignes)
            {
                cmbNomLigne.Items.Add(ligne.Nom);
            }
        }

        private void ChargerArrets()
        {
            cmbArrets.Items.Clear();
            foreach (var arret in arrets)
            {
                cmbArrets.Items.Add(arret.Nom);
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

        private void cmbNomLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            LigneBus ligne = lignes.FirstOrDefault(l => l.Nom == cmbNomLigne.SelectedItem!.ToString())!;
            List<ArretBus> arrets = BD.GetArrets(ligne.Id);

            lstArrets.Items.Clear();
            foreach (var arret in arrets)
            {
                lstArrets.Items.Add(arret.Nom);
            }

            btnCouleur.BackColor = ColorTranslator.FromHtml(ligne.Couleur);
            nudHeure1erAjout.Value = ligne.HeureDepart.Hours;
            nudMin1erAjout.Value = ligne.HeureDepart.Minutes;
            nudNbPassageAjout.Value = ligne.NbPassages;
        }

        private void cmbArrets_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArretBus arret = arrets.FirstOrDefault(a => a.Nom == cmbArrets.SelectedItem!.ToString())!;
            nudHeuresEcartArret.Value = arret.Ecart.Hours;
            nudMinEcartArret.Value = arret.Ecart.Minutes;
        }

        private void btnAjouterArret_Click(object sender, EventArgs e)
        {
            string? nomArret = (string?)cmbArrets.SelectedItem;
            if (nomArret == null)
            {
                MessageBox.Show("Veuillez sélectionner un arrêt", "Alerte");
                return;
            }
            lstArrets.Items.Add(nomArret);
            int nbHeures = (int)nudHeuresEcartArret.Value;
            int nbMinutes = (int)nudMinEcartArret.Value;
            TimeSpan ecart = new TimeSpan(nbHeures, nbMinutes, 0);
            ArretBus arret = arrets.FirstOrDefault(a => a.Nom == nomArret)!;
            arret.Ecart = ecart;
            arrets.Add(arret);
            nouveauxArrets.Add(arret);
        }

        private void btnModifierLigne_Click(object sender, EventArgs e)
        {
            int heures = (int)nudHeure1erAjout.Value;
            int min = (int)nudMin1erAjout.Value;
            string nomLigne = cmbNomLigne.Text;
            LigneBus ligne = lignes.FirstOrDefault(l => l.Nom == nomLigne)!;

            for (int i = 0; i < nouveauxArrets.Count; i++)
            {
                ArretBus arret = nouveauxArrets[i];
                if (!BD.AjouterLigneArret(ligne.Id, arret.Id, arrets.Count + i, arret.Ecart))
                {
                    MessageBox.Show($"Erreur lors de l'ajout de l'arrêt {arret.Nom} à la ligne {ligne.Nom}", "Alerte");
                    return;
                }
            }

            MessageBox.Show($"Ligne {ligne.Nom} modifiée avec succès", "Succès");
        }
    }
}
