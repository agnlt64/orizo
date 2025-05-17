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
    public partial class ConsulterIti : Form
    {
        public ConsulterIti()
        {
            InitializeComponent();
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
            if (IndexSelectionneDep < 0 || IndexSelectionneArr < 0)
            {
                MessageBox.Show("Veuillez sélectionner un point de départ et un point d'arrivée.", "Champs manquants", MessageBoxButtons.OK);
                return;
            }

            int heure = (int)nudHeure.Value;
            int minute = (int)nudMinute.Value;
            bool filtrerDepart = chkDepart.Checked;
            bool filtrerArrivee = chkArrive.Checked;

            ConsulterIti2 formIti2 = new ConsulterIti2(IndexSelectionneDep, IndexSelectionneArr,heure, minute, filtrerDepart, filtrerArrivee);
            formIti2.Show();
            this.Hide();
        }
        public int IndexSelectionneDep
        {
            get { return cmbDepart.SelectedIndex; }
        }
        public int IndexSelectionneArr
        {
            get { return cmbArrive.SelectedIndex; }
        }

    }
}
