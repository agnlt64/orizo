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
            //si 2 meme selectionner erreur
            ConsulterIti2 formIti2 = new ConsulterIti2(); // passe l'index directement
            formIti2.Show();
            this.Hide();
        }

       
    }
}
