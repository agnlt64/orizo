namespace orizo
{
    partial class AdministrerModifArret
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
            txtLongitudeModif = new TextBox();
            txtLatitudeModif = new TextBox();
            txtNomModif = new TextBox();
            lblNomArretModif = new Label();
            lblLatitudeModif = new Label();
            lblLongitudeModif = new Label();
            lblModifArret = new Label();
            btnModifArretEnregistrer = new Button();
            btnRetourModifArret = new Button();
            lstModifArret = new ListBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLongitudeModif
            // 
            txtLongitudeModif.Location = new Point(16, 259);
            txtLongitudeModif.Margin = new Padding(2, 2, 2, 2);
            txtLongitudeModif.Name = "txtLongitudeModif";
            txtLongitudeModif.Size = new Size(218, 27);
            txtLongitudeModif.TabIndex = 34;
            // 
            // txtLatitudeModif
            // 
            txtLatitudeModif.Location = new Point(16, 173);
            txtLatitudeModif.Margin = new Padding(2, 2, 2, 2);
            txtLatitudeModif.Name = "txtLatitudeModif";
            txtLatitudeModif.Size = new Size(218, 27);
            txtLatitudeModif.TabIndex = 33;
            // 
            // txtNomModif
            // 
            txtNomModif.Location = new Point(16, 54);
            txtNomModif.Margin = new Padding(2, 2, 2, 2);
            txtNomModif.Name = "txtNomModif";
            txtNomModif.Size = new Size(218, 27);
            txtNomModif.TabIndex = 32;
            // 
            // lblNomArretModif
            // 
            lblNomArretModif.AutoSize = true;
            lblNomArretModif.Font = new Font("Segoe UI", 11F);
            lblNomArretModif.Location = new Point(55, 15);
            lblNomArretModif.Margin = new Padding(2, 0, 2, 0);
            lblNomArretModif.Name = "lblNomArretModif";
            lblNomArretModif.Size = new Size(133, 25);
            lblNomArretModif.TabIndex = 31;
            lblNomArretModif.Text = "Nom de l'arrêt";
            // 
            // lblLatitudeModif
            // 
            lblLatitudeModif.AutoSize = true;
            lblLatitudeModif.Font = new Font("Segoe UI", 11F);
            lblLatitudeModif.Location = new Point(64, 134);
            lblLatitudeModif.Margin = new Padding(2, 0, 2, 0);
            lblLatitudeModif.Name = "lblLatitudeModif";
            lblLatitudeModif.Size = new Size(119, 25);
            lblLatitudeModif.TabIndex = 30;
            lblLatitudeModif.Text = "Latitude GPS";
            lblLatitudeModif.Click += lblLatitudeModif_Click;
            // 
            // lblLongitudeModif
            // 
            lblLongitudeModif.AutoSize = true;
            lblLongitudeModif.Font = new Font("Segoe UI", 11F);
            lblLongitudeModif.Location = new Point(55, 219);
            lblLongitudeModif.Margin = new Padding(2, 0, 2, 0);
            lblLongitudeModif.Name = "lblLongitudeModif";
            lblLongitudeModif.Size = new Size(136, 25);
            lblLongitudeModif.TabIndex = 29;
            lblLongitudeModif.Text = "Longitude GPS";
            // 
            // lblModifArret
            // 
            lblModifArret.AutoSize = true;
            lblModifArret.Font = new Font("Segoe UI", 15F);
            lblModifArret.Location = new Point(179, 49);
            lblModifArret.Margin = new Padding(2, 0, 2, 0);
            lblModifArret.Name = "lblModifArret";
            lblModifArret.Size = new Size(203, 35);
            lblModifArret.TabIndex = 28;
            lblModifArret.Text = "Modifier un arrêt";
            // 
            // btnModifArretEnregistrer
            // 
            btnModifArretEnregistrer.Location = new Point(35, 483);
            btnModifArretEnregistrer.Margin = new Padding(2);
            btnModifArretEnregistrer.Name = "btnModifArretEnregistrer";
            btnModifArretEnregistrer.Size = new Size(496, 45);
            btnModifArretEnregistrer.TabIndex = 27;
            btnModifArretEnregistrer.Text = "Enregistrer";
            btnModifArretEnregistrer.UseVisualStyleBackColor = true;
            btnModifArretEnregistrer.Click += btnModifArretEnregistrer_Click;
            // 
            // btnRetourModifArret
            // 
            btnRetourModifArret.Location = new Point(9, 9);
            btnRetourModifArret.Margin = new Padding(2);
            btnRetourModifArret.Name = "btnRetourModifArret";
            btnRetourModifArret.Size = new Size(48, 46);
            btnRetourModifArret.TabIndex = 26;
            btnRetourModifArret.Text = "<-";
            btnRetourModifArret.UseVisualStyleBackColor = true;
            btnRetourModifArret.Click += btnRetourModifArret_Click;
            // 
            // lstModifArret
            // 
            lstModifArret.FormattingEnabled = true;
            lstModifArret.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            lstModifArret.Location = new Point(42, 148);
            lstModifArret.Margin = new Padding(2, 2, 2, 2);
            lstModifArret.Name = "lstModifArret";
            lstModifArret.Size = new Size(224, 304);
            lstModifArret.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblLatitudeModif);
            panel1.Controls.Add(lblLongitudeModif);
            panel1.Controls.Add(txtLongitudeModif);
            panel1.Controls.Add(lblNomArretModif);
            panel1.Controls.Add(txtLatitudeModif);
            panel1.Controls.Add(txtNomModif);
            panel1.Location = new Point(281, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 304);
            panel1.TabIndex = 36;
            // 
            // AdministrerModifArret
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 560);
            Controls.Add(panel1);
            Controls.Add(lstModifArret);
            Controls.Add(lblModifArret);
            Controls.Add(btnModifArretEnregistrer);
            Controls.Add(btnRetourModifArret);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(585, 607);
            MinimumSize = new Size(585, 607);
            Name = "AdministrerModifArret";
            Text = "AdministrerModifArret";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLongitudeModif;
        private TextBox txtLatitudeModif;
        private TextBox txtNomModif;
        private Label lblNomArretModif;
        private Label lblLatitudeModif;
        private Label lblLongitudeModif;
        private Label lblModifArret;
        private Button btnModifArretEnregistrer;
        private Button btnRetourModifArret;
        private ListBox lstModifArret;
        private Panel panel1;
    }
}