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

        public Consulter()
        {
            InitializeComponent();
            InitializeWebView();
            btnretour.Visible = false; // Masquer le bouton de retour au départ
            lstbxconsultation.Visible = false; // Masquer la liste des lignes au départ
            btnrechercheconsultation.Visible = false; // Masquer le bouton de recherche au départ
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
        height: 100%;
        width: 100%;
    }

    #map {
        height: 70%;
        width: 98%;
        margin-top: 1%;
        margin-right: 1%;
        margin-left: 1%;
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
                webView.Visible = false; // Masquer la carte
                btnretour.Visible = true; // Afficher le bouton de retour
                btnconsulteriti.Visible = false; // Masquer le bouton de consultation d'itinéraire
                btnconsulterligne.Visible = false; // Masquer le bouton de consultation de ligne
                lstbxconsultation.Visible = true; // Afficher la liste des lignes
                btnrechercheconsultation.Visible = true; // Afficher le bouton de recherche
            }
        }

        private void btnconsulteriti_Click(object sender, EventArgs e)
        {

        }

        private void btnretour_Click(object sender, EventArgs e)
        {


            webView.Visible = true; // Masquer la carte
            btnretour.Visible = false; // Afficher le bouton de retour
            btnconsulteriti.Visible = true; // Masquer le bouton de consultation d'itinéraire
            btnconsulterligne.Visible = true; // Masquer le bouton de consultation de ligne
            lstbxconsultation.Visible = false; // Masquer la liste des lignes
            btnrechercheconsultation.Visible = false; // Masquer le bouton de recherche

        }

        private void btnrechercheconsultation_Click(object sender, EventArgs e)
        {

        }
    }
}
