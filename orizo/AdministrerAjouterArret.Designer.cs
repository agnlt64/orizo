namespace orizo
{
    partial class AdministrerAjouterArret
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
            btnRetourAjoutArret = new Button();
            btnAjouterArret = new Button();
            lblAjouterArret = new Label();
            lblLongitudeAjout = new Label();
            lblLatitudeAjout = new Label();
            lblNomArret = new Label();
            txtNom = new TextBox();
            txtLatitude = new TextBox();
            txtLongitude = new TextBox();
            SuspendLayout();
            // 
            // btnRetourAjoutArret
            // 
            btnRetourAjoutArret.Location = new Point(9, 9);
            btnRetourAjoutArret.Margin = new Padding(2);
            btnRetourAjoutArret.Name = "btnRetourAjoutArret";
            btnRetourAjoutArret.Size = new Size(48, 46);
            btnRetourAjoutArret.TabIndex = 17;
            btnRetourAjoutArret.Text = "<-";
            btnRetourAjoutArret.UseVisualStyleBackColor = true;
            btnRetourAjoutArret.Click += btnRetourAjoutArret_Click;
            // 
            // btnAjouterArret
            // 
            btnAjouterArret.Location = new Point(174, 460);
            btnAjouterArret.Margin = new Padding(2);
            btnAjouterArret.Name = "btnAjouterArret";
            btnAjouterArret.Size = new Size(218, 57);
            btnAjouterArret.TabIndex = 18;
            btnAjouterArret.Text = "Enregistrer";
            btnAjouterArret.UseVisualStyleBackColor = true;
            btnAjouterArret.Click += btnAjouterArret_Click;
            // 
            // lblAjouterArret
            // 
            lblAjouterArret.AutoSize = true;
            lblAjouterArret.Font = new Font("Segoe UI", 15F);
            lblAjouterArret.Location = new Point(188, 57);
            lblAjouterArret.Margin = new Padding(2, 0, 2, 0);
            lblAjouterArret.Name = "lblAjouterArret";
            lblAjouterArret.Size = new Size(190, 35);
            lblAjouterArret.TabIndex = 19;
            lblAjouterArret.Text = "Ajouter un arrêt";
            // 
            // lblLongitudeAjout
            // 
            lblLongitudeAjout.AutoSize = true;
            lblLongitudeAjout.Font = new Font("Segoe UI", 11F);
            lblLongitudeAjout.Location = new Point(215, 356);
            lblLongitudeAjout.Margin = new Padding(2, 0, 2, 0);
            lblLongitudeAjout.Name = "lblLongitudeAjout";
            lblLongitudeAjout.Size = new Size(136, 25);
            lblLongitudeAjout.TabIndex = 20;
            lblLongitudeAjout.Text = "Longitude GPS";
            // 
            // lblLatitudeAjout
            // 
            lblLatitudeAjout.AutoSize = true;
            lblLatitudeAjout.Font = new Font("Segoe UI", 11F);
            lblLatitudeAjout.Location = new Point(224, 264);
            lblLatitudeAjout.Margin = new Padding(2, 0, 2, 0);
            lblLatitudeAjout.MaximumSize = new Size(585, 607);
            lblLatitudeAjout.Name = "lblLatitudeAjout";
            lblLatitudeAjout.Size = new Size(119, 25);
            lblLatitudeAjout.TabIndex = 21;
            lblLatitudeAjout.Text = "Latitude GPS";
            // 
            // lblNomArret
            // 
            lblNomArret.AutoSize = true;
            lblNomArret.Font = new Font("Segoe UI", 11F);
            lblNomArret.Location = new Point(252, 148);
            lblNomArret.Margin = new Padding(2, 0, 2, 0);
            lblNomArret.Name = "lblNomArret";
            lblNomArret.Size = new Size(53, 25);
            lblNomArret.TabIndex = 22;
            lblNomArret.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(174, 185);
            txtNom.Margin = new Padding(2, 2, 2, 2);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(218, 27);
            txtNom.TabIndex = 23;
            // 
            // txtLatitude
            // 
            txtLatitude.Location = new Point(174, 305);
            txtLatitude.Margin = new Padding(2, 2, 2, 2);
            txtLatitude.Name = "txtLatitude";
            txtLatitude.Size = new Size(218, 27);
            txtLatitude.TabIndex = 24;
            // 
            // txtLongitude
            // 
            txtLongitude.Location = new Point(174, 392);
            txtLongitude.Margin = new Padding(2, 2, 2, 2);
            txtLongitude.Name = "txtLongitude";
            txtLongitude.Size = new Size(218, 27);
            txtLongitude.TabIndex = 25;
            // 
            // AdministrerAjouterArret
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 560);
            Controls.Add(txtLongitude);
            Controls.Add(txtLatitude);
            Controls.Add(txtNom);
            Controls.Add(lblNomArret);
            Controls.Add(lblLatitudeAjout);
            Controls.Add(lblLongitudeAjout);
            Controls.Add(lblAjouterArret);
            Controls.Add(btnAjouterArret);
            Controls.Add(btnRetourAjoutArret);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(585, 607);
            MinimumSize = new Size(585, 607);
            Name = "AdministrerAjouterArret";
            Text = "AdministrerAjouterArret";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetourAjoutArret;
        private Button btnAjouterArret;
        private Label lblAjouterArret;
        private Label lblLongitudeAjout;
        private Label lblLatitudeAjout;
        private Label lblNomArret;
        private TextBox txtNom;
        private TextBox txtLatitude;
        private TextBox txtLongitude;
    }
}