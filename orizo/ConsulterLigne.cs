using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orizo
{
    public partial class ConsulterLigne : Form
    {
        private int indexSelectionne;


        public ConsulterLigne(int indexSelectionne)
        {
            InitializeComponent();
            this.indexSelectionne = indexSelectionne;
            btnretour.Visible = true; // Afficher le bouton de retour
            AfficherDetails();
        }

        private void AfficherDetails()
        {
     
            if (indexSelectionne == 0)
            {
                dgvconsulterligne.Rows.Clear();

                // Ajoute des lignes correspondant au cas 0
                dgvconsulterligne.Rows.Add("Arrêt 1", "9h - 9h30 ");
                dgvconsulterligne.Rows.Add("Arrêt 2", "8h - 10h ");
            }
            else if (indexSelectionne == 1)
            {
                dgvconsulterligne.Rows.Clear();

                // Ajoute des lignes correspondant au cas 1
                dgvconsulterligne.Rows.Add("Arrêt 1", "19h - 20h30 ");
                dgvconsulterligne.Rows.Add("Arrêt 2", "20h - 22h ");
            }
            else
            {
                MessageBox.Show("Ligne indisponible", "Erreur", MessageBoxButtons.OK);

            }


        }





        private void ConsulterLigne_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            Consulter formConsulter = new Consulter(); 
            formConsulter.Show();
            this.Hide();
        }



        


    }
}
