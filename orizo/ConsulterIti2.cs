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
    public partial class ConsulterIti2 : Form
    {
        private WebView2 webView;
        public ConsulterIti2()
        {
            InitializeComponent();
            InitializeWebView();
        }


        // carte 

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
            height: 85%;
            width: 100%;
        }

        #map {
            height: 100%;
            width: 48%;
            margin-top: 15%;
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



        //carte



        private void btnretour_Click(object sender, EventArgs e)
        {
            ConsulterIti formIti = new ConsulterIti(); // passe l'index directement
            formIti.Show();
            this.Hide();
        }

        private void lblindication_Click(object sender, EventArgs e)
        {

        }
    }
}
