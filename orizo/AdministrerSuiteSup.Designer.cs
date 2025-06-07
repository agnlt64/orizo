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
            lblAdminSuiteSup.Location = new Point(50, 95);
            lblAdminSuiteSup.Margin = new Padding(2, 0, 2, 0);
            lblAdminSuiteSup.Name = "lblAdminSuiteSup";
            lblAdminSuiteSup.Size = new Size(279, 35);
            lblAdminSuiteSup.TabIndex = 21;
            lblAdminSuiteSup.Text = "Supprimer des données";
            // 
            // btnRetourAdministrerSup
            // 
            btnRetourAdministrerSup.Location = new Point(9, 9);
            btnRetourAdministrerSup.Margin = new Padding(2);
            btnRetourAdministrerSup.Name = "btnRetourAdministrerSup";
            btnRetourAdministrerSup.Size = new Size(48, 46);
            btnRetourAdministrerSup.TabIndex = 20;
            btnRetourAdministrerSup.Text = "<-";
            btnRetourAdministrerSup.UseVisualStyleBackColor = true;
            btnRetourAdministrerSup.Click += btnRetourAdministrerSup_Click;
            // 
            // btnAdminSupLigne
            // 
            btnAdminSupLigne.Location = new Point(77, 327);
            btnAdminSupLigne.Margin = new Padding(2);
            btnAdminSupLigne.Name = "btnAdminSupLigne";
            btnAdminSupLigne.Size = new Size(218, 57);
            btnAdminSupLigne.TabIndex = 19;
            btnAdminSupLigne.Text = "Supprimer une ligne";
            btnAdminSupLigne.UseVisualStyleBackColor = true;
            btnAdminSupLigne.Click += btnAdminSupLigne_Click;
            // 
            // btnAdminSupArret
            // 
            btnAdminSupArret.Location = new Point(77, 247);
            btnAdminSupArret.Margin = new Padding(2);
            btnAdminSupArret.Name = "btnAdminSupArret";
            btnAdminSupArret.Size = new Size(218, 57);
            btnAdminSupArret.TabIndex = 18;
            btnAdminSupArret.Text = "Supprimer un arrêt";
            btnAdminSupArret.UseVisualStyleBackColor = true;
            btnAdminSupArret.Click += btnAdminSupArret_Click;
            // 
            // AdministrerSuiteSup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 454);
            Controls.Add(lblAdminSuiteSup);
            Controls.Add(btnRetourAdministrerSup);
            Controls.Add(btnAdminSupLigne);
            Controls.Add(btnAdminSupArret);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(396, 501);
            MinimumSize = new Size(396, 501);
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