﻿using GestionBus;
using ParcoursBus;

namespace orizo
{
    public partial class ConsulterIti : Form
    {
        // private Graphe graphe;
        List<ArretBus> arrets;


        public ConsulterIti()
        {
            InitializeComponent();

            ChargerArrets();
            TimeSpan timeSpan = DateTime.Now.TimeOfDay;
            nudHeure.Value = timeSpan.Hours;
            nudMinute.Value = timeSpan.Minutes;
            chkDepart.Checked = true;
        }

        private void ChargerArrets()
        {
            arrets = BD.GetArrets();
            cmbDepart.Items.Clear();
            cmbArrive.Items.Clear();

            foreach (ArretBus arret in arrets)
            {
                cmbDepart.Items.Add(arret.Nom);
                cmbArrive.Items.Add(arret.Nom);
            }
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            Consulter formConsulter = new Consulter();
            formConsulter.Show();
            this.Hide();
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {

            // Vérifie si les deux combobox ont une sélection valide
            if (cmbDepart.SelectedIndex < 0 || cmbArrive.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner un point de départ et un point d'arrivée.", "Champs manquants", MessageBoxButtons.OK);
                return;
            }

            int heure = (int)nudHeure.Value;
            int minute = (int)nudMinute.Value;
            bool filtrerDepart = chkDepart.Checked;
            bool filtrerArrivee = chkArrivee.Checked;

            ConsulterIti2 formIti2 = new ConsulterIti2((string)cmbDepart.SelectedItem!, (string)cmbArrive.SelectedItem!, heure, minute, filtrerDepart, filtrerArrivee);
            formIti2.Show();
            this.Hide();
        }
    }
}
