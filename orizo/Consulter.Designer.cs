namespace orizo
{
    partial class Consulter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConsulterLigne = new Button();
            btnConsulterItineraire = new Button();
            btnRetourAccueil = new Button();
            lstConsultation = new ListBox();
            btnRechercheConsultation = new Button();
            btnRetourConsulter = new Button();
            btnRetourConsulter2 = new Button();
            lblConsulterLigne = new Label();
            SuspendLayout();
            // 
            // btnConsulterLigne
            // 
            btnConsulterLigne.BackColor = Color.Silver;
            btnConsulterLigne.Location = new Point(88, 475);
            btnConsulterLigne.Name = "btnConsulterLigne";
            btnConsulterLigne.Size = new Size(194, 29);
            btnConsulterLigne.TabIndex = 0;
            btnConsulterLigne.Text = "Consulter une ligne";
            btnConsulterLigne.UseVisualStyleBackColor = false;
            btnConsulterLigne.Click += btnconsulterligne_Click;
            // 
            // btnConsulterItineraire
            // 
            btnConsulterItineraire.BackColor = Color.Silver;
            btnConsulterItineraire.Location = new Point(536, 475);
            btnConsulterItineraire.Name = "btnConsulterItineraire";
            btnConsulterItineraire.Size = new Size(194, 29);
            btnConsulterItineraire.TabIndex = 1;
            btnConsulterItineraire.Text = "Consulter un itinéraire";
            btnConsulterItineraire.UseVisualStyleBackColor = false;
            btnConsulterItineraire.Click += btnconsulteriti_Click;
            // 
            // btnRetourAccueil
            // 
            btnRetourAccueil.BackColor = Color.Silver;
            btnRetourAccueil.Location = new Point(12, 12);
            btnRetourAccueil.Name = "btnRetourAccueil";
            btnRetourAccueil.Size = new Size(41, 46);
            btnRetourAccueil.TabIndex = 2;
            btnRetourAccueil.Text = "<-";
            btnRetourAccueil.UseVisualStyleBackColor = false;
            btnRetourAccueil.Click += btnretour_Click;
            // 
            // lstConsultation
            // 
            lstConsultation.FormattingEnabled = true;
            lstConsultation.Items.AddRange(new object[] { "Ligne 1 ", "Ligne 2", "Ligne 3" });
            lstConsultation.Location = new Point(269, 136);
            lstConsultation.Name = "lstConsultation";
            lstConsultation.Size = new Size(265, 264);
            lstConsultation.TabIndex = 3;
            lstConsultation.SelectedIndexChanged += lstconsultation_SelectedIndexChanged;
            // 
            // btnRechercheConsultation
            // 
            btnRechercheConsultation.BackColor = Color.Silver;
            btnRechercheConsultation.Location = new Point(269, 440);
            btnRechercheConsultation.Name = "btnRechercheConsultation";
            btnRechercheConsultation.Size = new Size(265, 29);
            btnRechercheConsultation.TabIndex = 4;
            btnRechercheConsultation.Text = "Effectuer une recherche";
            btnRechercheConsultation.UseVisualStyleBackColor = false;
            btnRechercheConsultation.Click += btnrechercheconsultation_Click;
            // 
            // btnRetourConsulter
            // 
            btnRetourConsulter.BackColor = Color.Silver;
            btnRetourConsulter.Location = new Point(12, 12);
            btnRetourConsulter.Margin = new Padding(2);
            btnRetourConsulter.Name = "btnRetourConsulter";
            btnRetourConsulter.Size = new Size(41, 46);
            btnRetourConsulter.TabIndex = 5;
            btnRetourConsulter.Text = "<-";
            btnRetourConsulter.UseVisualStyleBackColor = false;
            btnRetourConsulter.Click += btnRetourConsulter_Click;
            // 
            // btnRetourConsulter2
            // 
            btnRetourConsulter2.BackColor = Color.Silver;
            btnRetourConsulter2.Location = new Point(12, 12);
            btnRetourConsulter2.Margin = new Padding(2);
            btnRetourConsulter2.Name = "btnRetourConsulter2";
            btnRetourConsulter2.Size = new Size(41, 46);
            btnRetourConsulter2.TabIndex = 8;
            btnRetourConsulter2.Text = "<-";
            btnRetourConsulter2.UseVisualStyleBackColor = false;
            btnRetourConsulter2.Click += btnretourconsulter2_Click;
            // 
            // lblConsulterLigne
            // 
            lblConsulterLigne.AutoSize = true;
            lblConsulterLigne.Font = new Font("Segoe UI", 15F);
            lblConsulterLigne.Location = new Point(284, 86);
            lblConsulterLigne.Name = "lblConsulterLigne";
            lblConsulterLigne.Size = new Size(229, 35);
            lblConsulterLigne.TabIndex = 9;
            lblConsulterLigne.Text = "Consulter une ligne";
            // 
            // Consulter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 555);
            Controls.Add(lblConsulterLigne);
            Controls.Add(btnRetourConsulter2);
            Controls.Add(btnRetourConsulter);
            Controls.Add(btnRechercheConsultation);
            Controls.Add(lstConsultation);
            Controls.Add(btnRetourAccueil);
            Controls.Add(btnConsulterItineraire);
            Controls.Add(btnConsulterLigne);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Consulter";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Réseau de transport - Consultation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsulterLigne;
        private Button btnConsulterItineraire;
        private Button btnRetourAccueil;
        private ListBox lstConsultation;
        private Button btnRechercheConsultation;
        private Button btnRetourConsulter;
        private Button btnRetourConsulter2;
        private Label lblConsulterLigne;
    }
}