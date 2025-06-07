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
            picAccueil.Location = new Point(138, 26);
            picAccueil.Margin = new Padding(2, 3, 2, 3);
            picAccueil.Name = "picAccueil";
            picAccueil.Size = new Size(290, 243);
            picAccueil.SizeMode = PictureBoxSizeMode.Zoom;
            picAccueil.TabIndex = 0;
            picAccueil.TabStop = false;
            // 
            // lblAccueilChoix
            // 
            lblAccueilChoix.AutoSize = true;
            lblAccueilChoix.Font = new Font("Segoe UI", 15F);
            lblAccueilChoix.Location = new Point(212, 302);
            lblAccueilChoix.Margin = new Padding(2, 0, 2, 0);
            lblAccueilChoix.Name = "lblAccueilChoix";
            lblAccueilChoix.Size = new Size(142, 35);
            lblAccueilChoix.TabIndex = 2;
            lblAccueilChoix.Text = "Bienvenue !";
            lblAccueilChoix.Click += lblAccueilChoix_Click;
            // 
            // btnConsulterAccueil
            // 
            btnConsulterAccueil.Location = new Point(174, 380);
            btnConsulterAccueil.Margin = new Padding(2, 3, 2, 3);
            btnConsulterAccueil.Name = "btnConsulterAccueil";
            btnConsulterAccueil.Size = new Size(218, 57);
            btnConsulterAccueil.TabIndex = 3;
            btnConsulterAccueil.Text = "Consulter le réseau";
            btnConsulterAccueil.UseVisualStyleBackColor = true;
            btnConsulterAccueil.Click += btnConsulterAccueil_Click;
            // 
            // btnAdminAccueil
            // 
            btnAdminAccueil.Location = new Point(174, 453);
            btnAdminAccueil.Margin = new Padding(2, 3, 2, 3);
            btnAdminAccueil.Name = "btnAdminAccueil";
            btnAdminAccueil.Size = new Size(218, 57);
            btnAdminAccueil.TabIndex = 4;
            btnAdminAccueil.Text = "Administrer le réseau";
            btnAdminAccueil.UseVisualStyleBackColor = true;
            btnAdminAccueil.Click += btnAdminAccueil_Click;
            // 
            // AccueilOrizo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(567, 560);
            Controls.Add(btnAdminAccueil);
            Controls.Add(btnConsulterAccueil);
            Controls.Add(lblAccueilChoix);
            Controls.Add(picAccueil);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(585, 607);
            MinimumSize = new Size(585, 607);
            Name = "AccueilOrizo";
            Text = "Réseau de transport";
            FormClosing += AccueilOrizo_FormClosing;
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
