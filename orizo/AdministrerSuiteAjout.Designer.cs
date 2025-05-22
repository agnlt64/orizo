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
            btnAdminAjoutLigne.Location = new Point(287, 309);
            btnAdminAjoutLigne.Margin = new Padding(2);
            btnAdminAjoutLigne.Name = "btnAdminAjoutLigne";
            btnAdminAjoutLigne.Size = new Size(272, 71);
            btnAdminAjoutLigne.TabIndex = 11;
            btnAdminAjoutLigne.Text = "Ajouter une ligne";
            btnAdminAjoutLigne.UseVisualStyleBackColor = true;
            // 
            // btnAdminAjoutArret
            // 
            btnAdminAjoutArret.Location = new Point(287, 172);
            btnAdminAjoutArret.Margin = new Padding(2);
            btnAdminAjoutArret.Name = "btnAdminAjoutArret";
            btnAdminAjoutArret.Size = new Size(272, 71);
            btnAdminAjoutArret.TabIndex = 10;
            btnAdminAjoutArret.Text = "Ajouter un arrêt";
            btnAdminAjoutArret.UseVisualStyleBackColor = true;
            // 
            // btnRetourAdministrerAjout
            // 
            btnRetourAdministrerAjout.Location = new Point(11, 11);
            btnRetourAdministrerAjout.Margin = new Padding(2);
            btnRetourAdministrerAjout.Name = "btnRetourAdministrerAjout";
            btnRetourAdministrerAjout.Size = new Size(60, 58);
            btnRetourAdministrerAjout.TabIndex = 12;
            btnRetourAdministrerAjout.Text = "<-";
            btnRetourAdministrerAjout.UseVisualStyleBackColor = true;
            btnRetourAdministrerAjout.Click += btnRetourAdministrerAjout_Click;
            // 
            // lblAdminSuiteAjout
            // 
            lblAdminSuiteAjout.AutoSize = true;
            lblAdminSuiteAjout.Font = new Font("Segoe UI", 15F);
            lblAdminSuiteAjout.Location = new Point(296, 64);
            lblAdminSuiteAjout.Margin = new Padding(2, 0, 2, 0);
            lblAdminSuiteAjout.Name = "lblAdminSuiteAjout";
            lblAdminSuiteAjout.Size = new Size(254, 41);
            lblAdminSuiteAjout.TabIndex = 13;
            lblAdminSuiteAjout.Text = "Ajout de données";
            // 
            // AdministrerSuiteAjout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 510);
            Controls.Add(lblAdminSuiteAjout);
            Controls.Add(btnRetourAdministrerAjout);
            Controls.Add(btnAdminAjoutLigne);
            Controls.Add(btnAdminAjoutArret);
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