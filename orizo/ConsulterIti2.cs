using Microsoft.Web.WebView2.WinForms;
using ParcoursBus;
using GestionBus;

namespace orizo
{
    public partial class ConsulterIti2 : Form
    {
        private WebView2 webView;
        private string depart;
        private string arrivee;
        private int heureFiltre;
        private int minuteFiltre;
        private bool filtrerParDepart;
        private bool filtrerParArrivee;
        private Graphe graphe;

        public ConsulterIti2(string depart, string arrivee, int heure, int minute, bool filtrerDepart, bool filtrerArrivee)
        {
            InitializeComponent();
            InitializeWebView();
            this.depart = depart;
            this.arrivee = arrivee;
            this.heureFiltre = heure;
            this.minuteFiltre = minute;
            this.filtrerParDepart = filtrerDepart;
            this.filtrerParArrivee = filtrerArrivee;
            this.graphe = Graphe.ConstruireDepuisBDD();
            graphe.AfficherArrets();

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
            margin-top: 12%;
            margin-left: 3%;
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
            ConsulterIti formIti = new ConsulterIti();
            formIti.Show();
            this.Hide();
        }

        private void AfficherDetails()
        {
            // calculer le chemin entre les arrêts de bus
            var arrets = BD.GetArrets();
            ArretBus? arretDepart = graphe.Arrets.FirstOrDefault(a => a.Nom == depart);
            ArretBus? arretArrivee = graphe.Arrets.FirstOrDefault(a => a.Nom == arrivee);

            List<ArretBus>? chemin = null;
            if (arretDepart != null && arretArrivee != null)
            {
                chemin = graphe.Dijkstra(arretDepart, arretArrivee);
            }

            lswTableau.Items.Clear();
            lswTableau.Columns.Clear();
            lswTableau.View = View.Details;
            lswTableau.FullRowSelect = true;
            lswTableau.GridLines = true;

            // Deux colonnes : Arrêt et Ligne
            lswTableau.Columns.Add("Arrêt");
            lswTableau.Columns.Add("Ligne");

            double tempsTotal = 0;

            if (chemin != null && chemin.Count > 0)
            {
                for (int i = 0; i < chemin.Count; i++)
                {
                    string nomArret = chemin[i].Nom;
                    string nomLigne = "";

                    if (i < chemin.Count - 1)
                    {
                        int? idLigne = graphe.GetLigneEntre(chemin[i], chemin[i + 1]);
                        var ligne = BD.GetLignes().FirstOrDefault(l => l.Id == idLigne);
                        nomLigne = ligne != null ? ligne.Nom : idLigne?.ToString() ?? "Inconnu";
                    }

                    var item = new ListViewItem(nomArret);
                    item.SubItems.Add(nomLigne);
                    lswTableau.Items.Add(item);
                }

                // Calcul du temps total
                for (int i = 0; i < chemin.Count - 1; i++)
                {
                    double? poids = graphe.GetPoidsEntre(chemin[i], chemin[i + 1]);
                    if (poids.HasValue)
                        tempsTotal += poids.Value;
                }

                lblItinéraire.Text = $"Itinéraire de {arretDepart?.Nom} à {arretArrivee?.Nom} ({chemin.Count} arrêts) - Temps total : {tempsTotal:F0} min";
            }
            else
            {
                MessageBox.Show($"Aucun itinéraire trouvé entre les arrêts {depart} et {arrivee}.", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ajustement automatique des colonnes
            int colCount = lswTableau.Columns.Count;
            if (colCount > 0)
            {
                int colWidth = lswTableau.ClientSize.Width / colCount;
                foreach (ColumnHeader col in lswTableau.Columns)
                {
                    col.Width = colWidth;
                }
            }

            // afficher les horaires
            if (filtrerParDepart)
            {
                TimeSpan heureArrivee = new TimeSpan(heureFiltre, minuteFiltre, 0);
                heureArrivee += TimeSpan.FromMinutes(tempsTotal);
                lblDepart.Text = $"Départ : {depart} à {heureFiltre:D2}:{minuteFiltre:D2}";
                lblArrivee.Text = $"Arrivée : {arrivee} à {heureArrivee.Hours:D2}:{heureArrivee.Minutes:D2}";
            }
            else if (filtrerParArrivee)
            {
                TimeSpan heureDepart = new TimeSpan(heureFiltre, minuteFiltre, 0);
                heureDepart -= TimeSpan.FromMinutes(tempsTotal);
                lblDepart.Text = $"Départ : {depart} à {heureDepart.Hours:D2}:{heureDepart.Minutes:D2}";
                lblArrivee.Text = $"Arrivée : {arrivee} à {heureFiltre:D2}:{minuteFiltre:D2}";
            }
        }
    }
}
