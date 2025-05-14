namespace orizo
{
    partial class AccueilOrizo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picAccueil = new PictureBox();
            lblAccueilChoix = new Label();
            btnConsulterAccueil = new Button();
            btnAdminAccueil = new Button();
            ((System.ComponentModel.ISupportInitialize)picAccueil).BeginInit();
            SuspendLayout();
            // 
            // picAccueil
            // 
            picAccueil.Image = Properties.Resources.Logo_orizo;
            picAccueil.Location = new Point(388, 12);
            picAccueil.Name = "picAccueil";
            picAccueil.Size = new Size(362, 303);
            picAccueil.SizeMode = PictureBoxSizeMode.Zoom;
            picAccueil.TabIndex = 0;
            picAccueil.TabStop = false;
            // 
            // lblAccueilChoix
            // 
            lblAccueilChoix.AutoSize = true;
            lblAccueilChoix.Location = new Point(434, 341);
            lblAccueilChoix.Name = "lblAccueilChoix";
            lblAccueilChoix.Size = new Size(273, 25);
            lblAccueilChoix.TabIndex = 2;
            lblAccueilChoix.Text = "Veuillez choisir l'option souhaitée";
            // 
            // btnConsulterAccueil
            // 
            btnConsulterAccueil.Location = new Point(434, 437);
            btnConsulterAccueil.Name = "btnConsulterAccueil";
            btnConsulterAccueil.Size = new Size(273, 71);
            btnConsulterAccueil.TabIndex = 3;
            btnConsulterAccueil.Text = "Consulter le réseau";
            btnConsulterAccueil.UseVisualStyleBackColor = true;
            btnConsulterAccueil.Click += btnConsulterAccueil_Click;
            // 
            // btnAdminAccueil
            // 
            btnAdminAccueil.Location = new Point(434, 574);
            btnAdminAccueil.Name = "btnAdminAccueil";
            btnAdminAccueil.Size = new Size(273, 71);
            btnAdminAccueil.TabIndex = 4;
            btnAdminAccueil.Text = "Administrer le réseau";
            btnAdminAccueil.UseVisualStyleBackColor = true;
            btnAdminAccueil.Click += btnAdminAccueil_Click;
            // 
            // AccueilOrizo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnAdminAccueil);
            Controls.Add(btnConsulterAccueil);
            Controls.Add(lblAccueilChoix);
            Controls.Add(picAccueil);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AccueilOrizo";
            Text = "Réseau de transport";
            ((System.ComponentModel.ISupportInitialize)picAccueil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAccueil;
        private Label lblAccueilChoix;
        private Button btnConsulterAccueil;
        private Button btnAdminAccueil;
    }
}
