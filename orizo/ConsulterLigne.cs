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
            lbl10.Visible = false; // Masquer le label de consultation de ligne au départ
            lbl11.Visible = false; // Masquer le label de consultation de ligne au départ
            btnretour.Visible = true; // Afficher le bouton de retour
            AfficherDetails();
        }

        private void AfficherDetails()
        {
            // Exemple d'utilisation
            if (indexSelectionne == 0)
            {
                lbl10.Visible = true;
            }
            else if (indexSelectionne == 1)
            {
                lbl11.Visible = true;
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
            Consulter formConsulter = new Consulter(); // Recréation
            formConsulter.Show();
            this.Close(); // ou this.Hide();
        }



        // Ici tu peux utiliser consulterForm.LstConsultation par exemple


    }
}
