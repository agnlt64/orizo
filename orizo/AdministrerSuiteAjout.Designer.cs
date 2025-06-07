namespace orizo
{
    partial class AdministrerSuiteAjout
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
            btnAdminAjoutLigne = new Button();
            btnAdminAjoutArret = new Button();
            btnRetourAdministrerAjout = new Button();
            lblAdminSuiteAjout = new Label();
            SuspendLayout();
            // 
            // btnAdminAjoutLigne
            // 
            btnAdminAjoutLigne.Location = new Point(81, 337);
            btnAdminAjoutLigne.Margin = new Padding(2);
            btnAdminAjoutLigne.Name = "btnAdminAjoutLigne";
            btnAdminAjoutLigne.Size = new Size(218, 57);
            btnAdminAjoutLigne.TabIndex = 11;
            btnAdminAjoutLigne.Text = "Ajouter une ligne";
            btnAdminAjoutLigne.UseVisualStyleBackColor = true;
            btnAdminAjoutLigne.Click += btnAdminAjoutLigne_Click;
            // 
            // btnAdminAjoutArret
            // 
            btnAdminAjoutArret.Location = new Point(81, 267);
            btnAdminAjoutArret.Margin = new Padding(2);
            btnAdminAjoutArret.Name = "btnAdminAjoutArret";
            btnAdminAjoutArret.Size = new Size(218, 57);
            btnAdminAjoutArret.TabIndex = 10;
            btnAdminAjoutArret.Text = "Ajouter un arrêt";
            btnAdminAjoutArret.UseVisualStyleBackColor = true;
            btnAdminAjoutArret.Click += btnAdminAjoutArret_Click;
            // 
            // btnRetourAdministrerAjout
            // 
            btnRetourAdministrerAjout.Location = new Point(9, 9);
            btnRetourAdministrerAjout.Margin = new Padding(2);
            btnRetourAdministrerAjout.Name = "btnRetourAdministrerAjout";
            btnRetourAdministrerAjout.Size = new Size(48, 46);
            btnRetourAdministrerAjout.TabIndex = 12;
            btnRetourAdministrerAjout.Text = "<-";
            btnRetourAdministrerAjout.UseVisualStyleBackColor = true;
            btnRetourAdministrerAjout.Click += btnRetourAdministrerAjout_Click;
            // 
            // lblAdminSuiteAjout
            // 
            lblAdminSuiteAjout.AutoSize = true;
            lblAdminSuiteAjout.Font = new Font("Segoe UI", 15F);
            lblAdminSuiteAjout.Location = new Point(84, 110);
            lblAdminSuiteAjout.Margin = new Padding(2, 0, 2, 0);
            lblAdminSuiteAjout.Name = "lblAdminSuiteAjout";
            lblAdminSuiteAjout.Size = new Size(211, 35);
            lblAdminSuiteAjout.TabIndex = 13;
            lblAdminSuiteAjout.Text = "Ajout de données";
            // 
            // AdministrerSuiteAjout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 454);
            Controls.Add(lblAdminSuiteAjout);
            Controls.Add(btnRetourAdministrerAjout);
            Controls.Add(btnAdminAjoutLigne);
            Controls.Add(btnAdminAjoutArret);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(396, 501);
            MinimumSize = new Size(396, 501);
            Name = "AdministrerSuiteAjout";
            Text = "AdministrerSuiteAjout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdminAjoutLigne;
        private Button btnAdminAjoutArret;
        private Button btnRetourAdministrerAjout;
        private Label lblAdminSuiteAjout;
    }
}