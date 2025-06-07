namespace orizo
{
    partial class AdministrerMenuSuite
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
            btnAdminModifData = new Button();
            btnAdminAjouterData = new Button();
            lblAdminSuite = new Label();
            picAccueil = new PictureBox();
            btnAdminSupData = new Button();
            btnRetourAdministrer = new Button();
            ((System.ComponentModel.ISupportInitialize)picAccueil).BeginInit();
            SuspendLayout();
            // 
            // btnAdminModifData
            // 
            btnAdminModifData.Location = new Point(181, 379);
            btnAdminModifData.Margin = new Padding(2);
            btnAdminModifData.Name = "btnAdminModifData";
            btnAdminModifData.Size = new Size(218, 57);
            btnAdminModifData.TabIndex = 8;
            btnAdminModifData.Text = "Modifier des données";
            btnAdminModifData.UseVisualStyleBackColor = true;
            btnAdminModifData.Click += btnAdminModifData_Click;
            // 
            // btnAdminAjouterData
            // 
            btnAdminAjouterData.Location = new Point(181, 302);
            btnAdminAjouterData.Margin = new Padding(2);
            btnAdminAjouterData.Name = "btnAdminAjouterData";
            btnAdminAjouterData.Size = new Size(218, 57);
            btnAdminAjouterData.TabIndex = 7;
            btnAdminAjouterData.Text = "Ajouter des données";
            btnAdminAjouterData.UseVisualStyleBackColor = true;
            btnAdminAjouterData.Click += btnAdminAjouterData_Click;
            // 
            // lblAdminSuite
            // 
            lblAdminSuite.AutoSize = true;
            lblAdminSuite.Font = new Font("Segoe UI", 15F);
            lblAdminSuite.Location = new Point(162, 248);
            lblAdminSuite.Margin = new Padding(2, 0, 2, 0);
            lblAdminSuite.Name = "lblAdminSuite";
            lblAdminSuite.Size = new Size(249, 35);
            lblAdminSuite.TabIndex = 6;
            lblAdminSuite.Text = "Accès Administration";
            // 
            // picAccueil
            // 
            picAccueil.Image = Properties.Resources.Logo_orizo;
            picAccueil.Location = new Point(182, 31);
            picAccueil.Margin = new Padding(2);
            picAccueil.Name = "picAccueil";
            picAccueil.Size = new Size(211, 186);
            picAccueil.SizeMode = PictureBoxSizeMode.Zoom;
            picAccueil.TabIndex = 5;
            picAccueil.TabStop = false;
            // 
            // btnAdminSupData
            // 
            btnAdminSupData.Location = new Point(181, 456);
            btnAdminSupData.Margin = new Padding(2);
            btnAdminSupData.Name = "btnAdminSupData";
            btnAdminSupData.Size = new Size(218, 57);
            btnAdminSupData.TabIndex = 9;
            btnAdminSupData.Text = "Supprimer des données";
            btnAdminSupData.UseVisualStyleBackColor = true;
            btnAdminSupData.Click += btnAdminSupData_Click;
            // 
            // btnRetourAdministrer
            // 
            btnRetourAdministrer.Location = new Point(9, 9);
            btnRetourAdministrer.Margin = new Padding(2);
            btnRetourAdministrer.Name = "btnRetourAdministrer";
            btnRetourAdministrer.Size = new Size(48, 46);
            btnRetourAdministrer.TabIndex = 10;
            btnRetourAdministrer.Text = "<-";
            btnRetourAdministrer.UseVisualStyleBackColor = true;
            btnRetourAdministrer.Click += btnRetourAdministrer_Click;
            // 
            // AdministrerMenuSuite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 560);
            Controls.Add(btnRetourAdministrer);
            Controls.Add(btnAdminSupData);
            Controls.Add(btnAdminModifData);
            Controls.Add(btnAdminAjouterData);
            Controls.Add(lblAdminSuite);
            Controls.Add(picAccueil);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(585, 607);
            MinimumSize = new Size(585, 607);
            Name = "AdministrerMenuSuite";
            Text = "AdministrerMenuSuite";
            ((System.ComponentModel.ISupportInitialize)picAccueil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdminModifData;
        private Button btnAdminAjouterData;
        private Label lblAdminSuite;
        private PictureBox picAccueil;
        private Button btnAdminSupData;
        private Button btnRetourAdministrer;
    }
}