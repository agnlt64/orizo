    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Microsoft.Web.WebView2.WinForms;

    namespace orizo
    {
        public partial class Consulter : Form
        {
            private WebView2? webView;
            public ListBox lstconsultationPublic;

            public Consulter()
            {
                InitializeComponent();
                lstconsultationPublic = lstconsultation;
                InitializeWebView();
                btnretour.Visible = false; // Masquer le bouton de retour au départ
                btnretourconsulter2.Visible = false; // Masquer le bouton de retour au départ
                lstconsultation.Visible = false; // Masquer la liste des lignes au départ
                btnrechercheconsultation.Visible = false; // Masquer le bouton de recherche au départ
                lblconsulterligne.Visible = false; // Masquer le label de consultation de ligne au départ
           

            }
            //espaces pour les fonctions

            public void MasquerConsultation()
            {
                webView.Visible = true; // Masquer la carte
                btnretour.Visible = false; // Afficher le bouton de retour
                btnretourconsulter2.Visible = false; // Masquer le bouton de retour au départ
                btnconsulteriti.Visible = true; // Masquer le bouton de consultation d'itinéraire
                btnconsulterligne.Visible = true; // Masquer le bouton de consultation de ligne
                lstconsultation.Visible = false; // Masquer la liste des lignes
                btnrechercheconsultation.Visible = false; // Masquer le bouton de recherche
                btnRetourConsulter.Visible = true;
                lblconsulterligne.Visible = false; // Masquer le label de consultation de ligne au départ
            }

            public void MasquerLigne()
            {
                webView.Visible = false; // Masquer la carte
                btnretour.Visible = true; // Afficher le bouton de retour
                btnretourconsulter2.Visible = false; // Masquer le bouton de retour au départ
                btnconsulteriti.Visible = false; // Masquer le bouton de consultation d'itinéraire
                btnconsulterligne.Visible = false; // Masquer le bouton de consultation de ligne
                lstconsultation.Visible = true; // Afficher la liste des lignes
                btnrechercheconsultation.Visible = true; // Afficher le bouton de recherche
                btnRetourConsulter.Visible = false;
                lblconsulterligne.Visible = true; // Afficher le label de consultation de ligne
            }


            public void MasquerLigne2()
            {

                if (webView != null) webView.Visible = false;
                btnretour.Visible = false;
                btnretourconsulter2.Visible = true; // Masquer le bouton de retour au départ
                btnconsulteriti.Visible = false;
                btnconsulterligne.Visible = false;
                lstconsultation.Visible = false;
                btnrechercheconsultation.Visible = false;
                btnRetourConsulter.Visible = false;
            }





            //fin de l'espace pour les fonctions


            private async void InitializeWebView()
            {
                webView = new WebView2
                {
                    Dock = DockStyle.Fill
                };

                this.Controls.Add(webView);

                try
                {
                    await webView.EnsureCoreWebView2Async();

                    string htmlContent = @"
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset='utf-8'>
        <title>Carte Leaflet - Avignon</title>
        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
        <link rel='stylesheet' href='https://unpkg.com/leaflet@1.7.1/dist/leaflet.css' />
        <script src='https://unpkg.com/leaflet@1.7.1/dist/leaflet.js'></script>
        <style>
            html, body {
            margin: 0;
            padding: 0;
            height: 99%;
            width: 100%;
        }

        #map {
            height: 70%;
            width: 90%;
            margin-top: 1%;
            margin-right: 1%;
            margin-left: 9%;
        }
        </style>
    </head>
    <body>
        <div id='map'></div>
        <script>
            var map = L.map('map').setView([43.9493, 4.8055], 13);
            L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                maxZoom: 19,
                attribution: '© OpenStreetMap'
            }).addTo(map);
        </script>
    </body>
    </html>";
                    webView.NavigateToString(htmlContent);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur WebView2 : " + ex.Message);
                }
            }

            private void btnconsulterligne_Click(object sender, EventArgs e)
            {
                int nbrliste = lstconsultation.Items.Count;

                if (nbrliste == 0)
                {
                    MessageBox.Show("Aucun arrêt n'est présent dans la base de données", "Alerte", MessageBoxButtons.OK );
                    return; // Sortir de la fonction pour ne pas continuer
                }

                if (webView != null)
                {
                    MasquerLigne();
                }
            }

            private void btnconsulteriti_Click(object sender, EventArgs e)
            {
                int nbrliste = lstconsultation.Items.Count;

                if (nbrliste == 0)
                {
                    MessageBox.Show("Aucune ligne n'est présent dans la base de données", "Alerte", MessageBoxButtons.OK);
                    return; // Sortir de la fonction pour ne pas continuer
                }
                if (webView != null)
                {
                ConsulterIti formIti = new ConsulterIti(); // passe l'index directement
                formIti.Show();
                this.Hide(); // facultatif
            }
            }

            private void btnretour_Click(object sender, EventArgs e)
            {


                MasquerConsultation();


            }

        private void btnrechercheconsultation_Click(object sender, EventArgs e)
        {
            if (lstconsultation.SelectedItem != null)
            {
                int indexSelectionne = lstconsultation.SelectedIndex;
                ConsulterLigne formLigne = new ConsulterLigne(indexSelectionne); // passe l'index directement
                formLigne.Show();
                this.Hide(); // facultatif
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.", "Alerte", MessageBoxButtons.OK);
            }
        }

        private void btnRetourConsulter_Click(object sender, EventArgs e)
            {
                Application.OpenForms[0]?.Show();
                this.Close();
            }

            private void btnretourconsulter2_Click(object sender, EventArgs e)
            {
            
        }
    

            private void lstconsultation_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        public int IndexSelectionne
        {
            get { return lstconsultation.SelectedIndex; }
        }
    }
    }
