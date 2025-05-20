namespace orizo
{
    partial class AdministrerSuiteSup
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
            lblAdminSuiteSup = new Label();
            btnRetourAdministrerSup = new Button();
            btnAdminSupLigne = new Button();
            btnAdminSupArret = new Button();
            SuspendLayout();
            // 
            // lblAdminSuiteSup
            // 
            lblAdminSuiteSup.AutoSize = true;
            lblAdminSuiteSup.Font = new Font("Segoe UI", 15F);
            lblAdminSuiteSup.Location = new Point(272, 63);
            lblAdminSuiteSup.Margin = new Padding(2, 0, 2, 0);
            lblAdminSuiteSup.Name = "lblAdminSuiteSup";
            lblAdminSuiteSup.Size = new Size(334, 41);
            lblAdminSuiteSup.TabIndex = 21;
            lblAdminSuiteSup.Text = "Supprimer des données";
            // 
            // btnRetourAdministrerSup
            // 
            btnRetourAdministrerSup.Location = new Point(11, 11);
            btnRetourAdministrerSup.Margin = new Padding(2);
            btnRetourAdministrerSup.Name = "btnRetourAdministrerSup";
            btnRetourAdministrerSup.Size = new Size(60, 58);
            btnRetourAdministrerSup.TabIndex = 20;
            btnRetourAdministrerSup.Text = "<-";
            btnRetourAdministrerSup.UseVisualStyleBackColor = true;
            // 
            // btnAdminSupLigne
            // 
            btnAdminSupLigne.Location = new Point(287, 309);
            btnAdminSupLigne.Margin = new Padding(2);
            btnAdminSupLigne.Name = "btnAdminSupLigne";
            btnAdminSupLigne.Size = new Size(272, 71);
            btnAdminSupLigne.TabIndex = 19;
            btnAdminSupLigne.Text = "Supprimer une ligne";
            btnAdminSupLigne.UseVisualStyleBackColor = true;
            // 
            // btnAdminSupArret
            // 
            btnAdminSupArret.Location = new Point(287, 172);
            btnAdminSupArret.Margin = new Padding(2);
            btnAdminSupArret.Name = "btnAdminSupArret";
            btnAdminSupArret.Size = new Size(272, 71);
            btnAdminSupArret.TabIndex = 18;
            btnAdminSupArret.Text = "Supprimer un arrêt";
            btnAdminSupArret.UseVisualStyleBackColor = true;
            // 
            // AdministrerSuiteSup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 509);
            Controls.Add(lblAdminSuiteSup);
            Controls.Add(btnRetourAdministrerSup);
            Controls.Add(btnAdminSupLigne);
            Controls.Add(btnAdminSupArret);
            Name = "AdministrerSuiteSup";
            Text = "AdministrerSuiteSup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminSuiteSup;
        private Button btnRetourAdministrerSup;
        private Button btnAdminSupLigne;
        private Button btnAdminSupArret;
    }
}