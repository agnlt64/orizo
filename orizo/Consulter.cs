using Microsoft.Web.WebView2.WinForms;
using GestionBus;

namespace orizo
{
    public partial class Consulter : Form
    {
        private WebView2? webView;
        public ListBox lstconsultationPublic;
        private List<LigneBus> lignes;

        public Consulter()
        {
            InitializeComponent();
            lstconsultationPublic = lstConsultation;
            InitializeWebView();
            btnRetourAccueil.Visible = false; // Masquer le bouton de retour au départ
            btnRetourConsulter2.Visible = false; // Masquer le bouton de retour au départ
            lstConsultation.Visible = false; // Masquer la liste des lignes au départ
            btnRechercheConsultation.Visible = false; // Masquer le bouton de recherche au départ
            lblConsulterLigne.Visible = false; // Masquer le label de consultation de ligne au départ

            ChargerLignes();
            lignes = BD.GetLignes();
        }
        //espaces pour les fonctions

        public void MasquerConsultation()
        {
            webView.Visible = true; // Masquer la carte
            btnRetourAccueil.Visible = false; // Afficher le bouton de retour
            btnRetourConsulter2.Visible = false; // Masquer le bouton de retour au départ
            btnConsulterItineraire.Visible = true; // Masquer le bouton de consultation d'itinéraire
            btnConsulterLigne.Visible = true; // Masquer le bouton de consultation de ligne
            lstConsultation.Visible = false; // Masquer la liste des lignes
            btnRechercheConsultation.Visible = false; // Masquer le bouton de recherche
            btnRetourConsulter.Visible = true;
            lblConsulterLigne.Visible = false; // Masquer le label de consultation de ligne au départ
        }

        public void MasquerLigne()
        {
            webView.Visible = false; // Masquer la carte
            btnRetourAccueil.Visible = true; // Afficher le bouton de retour
            btnRetourConsulter2.Visible = false; // Masquer le bouton de retour au départ
            btnConsulterItineraire.Visible = false; // Masquer le bouton de consultation d'itinéraire
            btnConsulterLigne.Visible = false; // Masquer le bouton de consultation de ligne
            lstConsultation.Visible = true; // Afficher la liste des lignes
            btnRechercheConsultation.Visible = true; // Afficher le bouton de recherche
            btnRetourConsulter.Visible = false;
            lblConsulterLigne.Visible = true; // Afficher le label de consultation de ligne
        }

        public void MasquerLigne2()
        {

            if (webView != null) webView.Visible = false;
            btnRetourAccueil.Visible = false;
            btnRetourConsulter2.Visible = true; // Masquer le bouton de retour au départ
            btnConsulterItineraire.Visible = false;
            btnConsulterLigne.Visible = false;
            lstConsultation.Visible = false;
            btnRechercheConsultation.Visible = false;
            btnRetourConsulter.Visible = false;
        }

        //fin de l'espace pour les fonctions

        private void ChargerLignes()
        {
            lstConsultation.Items.Clear();
            var lignes = BD.GetLignes();
            foreach (LigneBus ligne in lignes)
            {
                // Affichez le nom de la ligne (ajustez selon vos besoins)
                lstConsultation.Items.Add(ligne.Nom);
            }
        }

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
            if (webView != null)
            {
                MasquerLigne();
                return;
            }

            string? nomLigne = lstConsultation.SelectedItem?.ToString();
            LigneBus? ligne = lignes.FirstOrDefault(a => a.Nom == nomLigne);

            if (ligne == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne valide.", "Alerte", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnconsulteriti_Click(object sender, EventArgs e)
        {
            int nbrliste = lstConsultation.Items.Count;

            if (nbrliste == 0)
            {
                MessageBox.Show("Aucune ligne n'est présent dans la base de données", "Alerte", MessageBoxButtons.OK);
                return;
            }
            if (webView != null)
            {
                ConsulterIti formIti = new ConsulterIti();
                formIti.Show();
                this.Hide();
            }
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            MasquerConsultation();
        }

        private void btnrechercheconsultation_Click(object sender, EventArgs e)
        {
            if (lstConsultation.SelectedItem != null)
            {
                string nomLigne = (string)lstConsultation.SelectedItem;
                LigneBus ligne = lignes.FirstOrDefault(a => a.Nom == nomLigne)!;
                ConsulterLigne formLigne = new ConsulterLigne(ligne.Id, ligne.Nom);
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
            get { return lstConsultation.SelectedIndex; }
        }
    }
}
