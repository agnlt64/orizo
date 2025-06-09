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
            margin-top: 8%;
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
            ConsulterIti formIti = new ConsulterIti();
            formIti.Show();
            this.Hide();
        }

        private void AfficherDetails()
        {
            // Récupérer tous les arrêts pour retrouver les objets ArretBus
            var arrets = BD.GetArrets();
            ArretBus? arretDepart = null;
            ArretBus? arretArrivee = null;

            arretDepart = graphe.Arrets.FirstOrDefault(a => a.Nom == depart);
            arretArrivee = graphe.Arrets.FirstOrDefault(a => a.Nom == arrivee);

            // Calculer le chemin avec Dijkstra
            List<ArretBus>? chemin = null;
            if (arretDepart != null && arretArrivee != null)
            {
                chemin = graphe.Dijkstra(arretDepart, arretArrivee);
            }

            // Nettoyage et configuration ListView
            lswTableau.Items.Clear();
            lswTableau.Columns.Clear();
            lswTableau.View = View.Details;
            lswTableau.FullRowSelect = true;
            lswTableau.GridLines = true;

            // Ajouter colonnes
            lswTableau.Columns.Add("Ordre");
            lswTableau.Columns.Add("Arrêt");
            lswTableau.Columns.Add("Latitude");
            lswTableau.Columns.Add("Longitude");

            if (chemin != null && chemin.Count > 0)
            {
                int ordre = 1;
                foreach (var arret in chemin)
                {
                    var item = new ListViewItem(ordre.ToString());
                    item.SubItems.Add(arret.Nom);
                    item.SubItems.Add(arret.Latitude.ToString("F6"));
                    item.SubItems.Add(arret.Longitude.ToString("F6"));
                    lswTableau.Items.Add(item);
                    ordre++;
                }

                if (chemin.Count > 1)
                {
                    double tempsTotal = 0;
                    for (int i = 0; i < chemin.Count - 1; i++)
                    {
                        var arretA = chemin[i];
                        var arretB = chemin[i + 1];
                        double? poids = graphe.GetPoidsEntre(arretA, arretB);
                        if (poids.HasValue)
                            tempsTotal += poids.Value;
                    }

                    // Affichage du temps total (arrondir si besoin)
                    lblIndication.Text = $"Itinéraire de {arretDepart?.Nom} à {arretArrivee?.Nom} ({chemin.Count} arrêts) - Temps total : {tempsTotal:F0} min";
                }
                else
                {
                    lblIndication.Text = $"Itinéraire de {arretDepart?.Nom} à {arretArrivee?.Nom} ({chemin.Count} arrêts)";
                }
            }
            else
            {
                MessageBox.Show($"Aucun itinéraire trouvé entre les arrêts {depart} et {arrivee}.", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // afficher les lignes entre les arrêts
            if (chemin != null && chemin.Count > 1)
            {
                for (int i = 0; i < chemin.Count - 1; i++)
                {
                    var arretA = chemin[i];
                    var arretB = chemin[i + 1];
                    int? idLigne = graphe.GetLigneEntre(arretA, arretB);

                    // Affichez arretA, arretB, et idLigne (ou récupérez le nom de la ligne via BD.GetLignes())
                    // Par exemple :
                    var ligne = BD.GetLignes().FirstOrDefault(l => l.Id == idLigne);
                    string nomLigne = ligne != null ? ligne.Nom : idLigne?.ToString() ?? "Inconnu";

                    // Ajoutez à votre ListView ou autre affichage
                    var item = new ListViewItem(new[] {
                        arretA.Nom + " → " + arretB.Nom,
                        nomLigne
                    });
                    lswTableau.Items.Add(item);
                }
            }

            // Ajustement automatique des colonnes pour remplir l’espace
            int colCount = lswTableau.Columns.Count;
            if (colCount > 0)
            {
                int colWidth = lswTableau.ClientSize.Width / colCount;
                foreach (ColumnHeader col in lswTableau.Columns)
                {
                    col.Width = colWidth;
                }
            }
        }
    }
}
