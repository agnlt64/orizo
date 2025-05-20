namespace orizo
{
    partial class AdministrerSuiteModif
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
            lblAdminSuiteModif = new Label();
            btnRetourAdministrerModif = new Button();
            btnAdminModifierLigne = new Button();
            btnAdminModifierArret = new Button();
            SuspendLayout();
            // 
            // lblAdminSuiteModif
            // 
            lblAdminSuiteModif.AutoSize = true;
            lblAdminSuiteModif.Font = new Font("Segoe UI", 15F);
            lblAdminSuiteModif.Location = new Point(272, 63);
            lblAdminSuiteModif.Margin = new Padding(2, 0, 2, 0);
            lblAdminSuiteModif.Name = "lblAdminSuiteModif";
            lblAdminSuiteModif.Size = new Size(308, 41);
            lblAdminSuiteModif.TabIndex = 17;
            lblAdminSuiteModif.Text = "Modifier des données";
            // 
            // btnRetourAdministrerModif
            // 
            btnRetourAdministrerModif.Location = new Point(11, 11);
            btnRetourAdministrerModif.Margin = new Padding(2);
            btnRetourAdministrerModif.Name = "btnRetourAdministrerModif";
            btnRetourAdministrerModif.Size = new Size(60, 58);
            btnRetourAdministrerModif.TabIndex = 16;
            btnRetourAdministrerModif.Text = "<-";
            btnRetourAdministrerModif.UseVisualStyleBackColor = true;
            // 
            // btnAdminModifierLigne
            // 
            btnAdminModifierLigne.Location = new Point(287, 309);
            btnAdminModifierLigne.Margin = new Padding(2);
            btnAdminModifierLigne.Name = "btnAdminModifierLigne";
            btnAdminModifierLigne.Size = new Size(272, 71);
            btnAdminModifierLigne.TabIndex = 15;
            btnAdminModifierLigne.Text = "Modifier une ligne";
            btnAdminModifierLigne.UseVisualStyleBackColor = true;
            // 
            // btnAdminModifierArret
            // 
            btnAdminModifierArret.Location = new Point(287, 172);
            btnAdminModifierArret.Margin = new Padding(2);
            btnAdminModifierArret.Name = "btnAdminModifierArret";
            btnAdminModifierArret.Size = new Size(272, 71);
            btnAdminModifierArret.TabIndex = 14;
            btnAdminModifierArret.Text = "Modifier un arrêt";
            btnAdminModifierArret.UseVisualStyleBackColor = true;
            // 
            // AdministrerSuiteModif
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 519);
            Controls.Add(lblAdminSuiteModif);
            Controls.Add(btnRetourAdministrerModif);
            Controls.Add(btnAdminModifierLigne);
            Controls.Add(btnAdminModifierArret);
            Name = "AdministrerSuiteModif";
            Text = "AdministrerSuiteModif";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminSuiteModif;
        private Button btnRetourAdministrerModif;
        private Button btnAdminModifierLigne;
        private Button btnAdminModifierArret;
    }
}