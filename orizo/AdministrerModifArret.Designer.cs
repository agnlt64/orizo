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
            SuspendLayout();
            // 
            // txtLongitudeModif
            // 
            txtLongitudeModif.Location = new Point(537, 496);
            txtLongitudeModif.Name = "txtLongitudeModif";
            txtLongitudeModif.Size = new Size(272, 31);
            txtLongitudeModif.TabIndex = 34;
            // 
            // txtLatitudeModif
            // 
            txtLatitudeModif.Location = new Point(537, 344);
            txtLatitudeModif.Name = "txtLatitudeModif";
            txtLatitudeModif.Size = new Size(272, 31);
            txtLatitudeModif.TabIndex = 33;
            // 
            // txtNomModif
            // 
            txtNomModif.Location = new Point(537, 207);
            txtNomModif.Name = "txtNomModif";
            txtNomModif.Size = new Size(272, 31);
            txtNomModif.TabIndex = 32;
            // 
            // lblNomArretModif
            // 
            lblNomArretModif.AutoSize = true;
            lblNomArretModif.Font = new Font("Segoe UI", 15F);
            lblNomArretModif.Location = new Point(626, 151);
            lblNomArretModif.Margin = new Padding(2, 0, 2, 0);
            lblNomArretModif.Name = "lblNomArretModif";
            lblNomArretModif.Size = new Size(79, 41);
            lblNomArretModif.TabIndex = 31;
            lblNomArretModif.Text = "nom";
            // 
            // lblLatitudeModif
            // 
            lblLatitudeModif.AutoSize = true;
            lblLatitudeModif.Font = new Font("Segoe UI", 15F);
            lblLatitudeModif.Location = new Point(577, 272);
            lblLatitudeModif.Margin = new Padding(2, 0, 2, 0);
            lblLatitudeModif.Name = "lblLatitudeModif";
            lblLatitudeModif.Size = new Size(180, 41);
            lblLatitudeModif.TabIndex = 30;
            lblLatitudeModif.Text = "latitude GPS";
            // 
            // lblLongitudeModif
            // 
            lblLongitudeModif.AutoSize = true;
            lblLongitudeModif.Font = new Font("Segoe UI", 15F);
            lblLongitudeModif.Location = new Point(561, 419);
            lblLongitudeModif.Margin = new Padding(2, 0, 2, 0);
            lblLongitudeModif.Name = "lblLongitudeModif";
            lblLongitudeModif.Size = new Size(208, 41);
            lblLongitudeModif.TabIndex = 29;
            lblLongitudeModif.Text = "longitude GPS";
            // 
            // lblModifArret
            // 
            lblModifArret.AutoSize = true;
            lblModifArret.Font = new Font("Segoe UI", 15F);
            lblModifArret.Location = new Point(328, 54);
            lblModifArret.Margin = new Padding(2, 0, 2, 0);
            lblModifArret.Name = "lblModifArret";
            lblModifArret.Size = new Size(241, 41);
            lblModifArret.TabIndex = 28;
            lblModifArret.Text = "Modifier un arrêt";
            // 
            // btnModifArretEnregistrer
            // 
            btnModifArretEnregistrer.Location = new Point(304, 604);
            btnModifArretEnregistrer.Margin = new Padding(2);
            btnModifArretEnregistrer.Name = "btnModifArretEnregistrer";
            btnModifArretEnregistrer.Size = new Size(272, 71);
            btnModifArretEnregistrer.TabIndex = 27;
            btnModifArretEnregistrer.Text = "Enregistrer";
            btnModifArretEnregistrer.UseVisualStyleBackColor = true;
            btnModifArretEnregistrer.Click += btnModifArretEnregistrer_Click;
            // 
            // btnRetourModifArret
            // 
            btnRetourModifArret.Location = new Point(11, 11);
            btnRetourModifArret.Margin = new Padding(2);
            btnRetourModifArret.Name = "btnRetourModifArret";
            btnRetourModifArret.Size = new Size(60, 58);
            btnRetourModifArret.TabIndex = 26;
            btnRetourModifArret.Text = "<-";
            btnRetourModifArret.UseVisualStyleBackColor = true;
            btnRetourModifArret.Click += btnRetourModifArret_Click;
            // 
            // lstModifArret
            // 
            lstModifArret.FormattingEnabled = true;
            lstModifArret.ItemHeight = 25;
            lstModifArret.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            lstModifArret.Location = new Point(52, 198);
            lstModifArret.Name = "lstModifArret";
            lstModifArret.Size = new Size(255, 329);
            lstModifArret.TabIndex = 35;
            // 
            // AdministrerModifArret
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 681);
            Controls.Add(lstModifArret);
            Controls.Add(txtLongitudeModif);
            Controls.Add(txtLatitudeModif);
            Controls.Add(txtNomModif);
            Controls.Add(lblNomArretModif);
            Controls.Add(lblLatitudeModif);
            Controls.Add(lblLongitudeModif);
            Controls.Add(lblModifArret);
            Controls.Add(btnModifArretEnregistrer);
            Controls.Add(btnRetourModifArret);
            Name = "AdministrerModifArret";
            Text = "AdministrerModifArret";
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
    }
}