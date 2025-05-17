using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace orizo
{
    public partial class ConsulterIti2 : Form
    {
        private WebView2 webView;
        private int indexSelectionneDep;
        private int indexSelectionneArr;
        private int heureFiltre;
        private int minuteFiltre;
        private bool filtrerParDepart;
        private bool filtrerParArrivee;

        public ConsulterIti2(int indexSelectionneDep, int indexSelectionneArr, int heure, int minute, bool filtrerDepart, bool filtrerArrivee)
        {
            InitializeComponent();
            InitializeWebView();
            this.indexSelectionneDep = indexSelectionneDep;
            this.indexSelectionneArr = indexSelectionneArr;
            this.heureFiltre = heure;
            this.minuteFiltre = minute;
            this.filtrerParDepart = filtrerDepart;
            this.filtrerParArrivee = filtrerArrivee;

            if (indexSelectionneDep < 0 || indexSelectionneArr < 0)
            {
                MessageBox.Show("Veuillez sélectionner un départ et une arrivée valides.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); 
                return;
            }
            AfficherDetails();
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


        private bool TryParseHeure(string heureStr, out TimeSpan result)
        {
            return TimeSpan.TryParse(heureStr.Trim(), out result);
        }


        private void btnretour_Click(object sender, EventArgs e)
        {
            ConsulterIti formIti = new ConsulterIti(); 
            formIti.Show();
            this.Hide();
        }

        private void AfficherDetails()
        {
            var heureReference = new TimeSpan(heureFiltre, minuteFiltre, 0);

            var itineraires = new Dictionary<(int, int), List<(string arret, string debut, string fin)>>()
            {
                { (0, 0), new List<(string, string, string)> { ("Arrêt 1", "9:00", "9:30"), ("Arrêt 2", "18:00", "19:00") } },
                { (0, 1), new List<(string, string, string)> { ("Arrêt 1", "19:00", "20:30"), ("Arrêt 2", "20:00", "22:00") } },
                { (1, 0), new List<(string, string, string)> { ("Arrêt 1", "18:00", "20:30"), ("Arrêt 2", "20:00", "22:00") } },
                { (1, 1), new List<(string, string, string)> { ("Arrêt 1", "17:00", "20:30"), ("Arrêt 2", "20:00", "22:00") } }
            };

            dvgTableauItineraire.Rows.Clear();

            var key = (indexSelectionneDep, indexSelectionneArr);

            if (itineraires.TryGetValue(key, out var stops))
            {
                foreach (var (arret, debutStr, finStr) in stops)
                {
                    if (TryParseHeure(debutStr, out TimeSpan debut) && TryParseHeure(finStr, out TimeSpan fin))
                    {
                        bool afficher;

                        if (!filtrerParDepart && !filtrerParArrivee)
                        {
                            afficher = true;
                        }
                        else if (filtrerParDepart && filtrerParArrivee)
                        {
                            afficher = (debut >= heureReference) && (fin >= heureReference);
                        }
                        else if (filtrerParDepart)
                        {
                            afficher = (debut >= heureReference);
                        }
                        else 
                        {
                            afficher = (fin >= heureReference);
                        }

                        if (afficher)
                            dvgTableauItineraire.Rows.Add(arret, debutStr, finStr);
                    }
                }

                if (dvgTableauItineraire.Rows.Count == 0)
                {
                    MessageBox.Show("Aucun trajet ne correspond à l'heure choisie.", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ligne indisponible", "Erreur", MessageBoxButtons.OK);
                dvgTableauItineraire.Rows.Add("Erreur", "Erreur");
            }
            
            lblIndication.Text = "Arrêt " + (indexSelectionneDep + 1) + " à Arrêt" + (indexSelectionneArr + 1);

        }
    }
}
