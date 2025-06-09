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
            picAccueil.Location = new Point(121, 20);
            picAccueil.Margin = new Padding(2, 2, 2, 2);
            picAccueil.Name = "picAccueil";
            picAccueil.Size = new Size(254, 182);
            picAccueil.SizeMode = PictureBoxSizeMode.Zoom;
            picAccueil.TabIndex = 0;
            picAccueil.TabStop = false;
            // 
            // lblAccueilChoix
            // 
            lblAccueilChoix.AutoSize = true;
            lblAccueilChoix.Font = new Font("Segoe UI", 15F);
            lblAccueilChoix.Location = new Point(186, 226);
            lblAccueilChoix.Margin = new Padding(2, 0, 2, 0);
            lblAccueilChoix.Name = "lblAccueilChoix";
            lblAccueilChoix.Size = new Size(112, 28);
            lblAccueilChoix.TabIndex = 2;
            lblAccueilChoix.Text = "Bienvenue !";
            lblAccueilChoix.Click += lblAccueilChoix_Click;
            // 
            // btnConsulterAccueil
            // 
            btnConsulterAccueil.Location = new Point(152, 285);
            btnConsulterAccueil.Margin = new Padding(2, 2, 2, 2);
            btnConsulterAccueil.Name = "btnConsulterAccueil";
            btnConsulterAccueil.Size = new Size(191, 43);
            btnConsulterAccueil.TabIndex = 3;
            btnConsulterAccueil.Text = "Consulter le réseau";
            btnConsulterAccueil.UseVisualStyleBackColor = true;
            btnConsulterAccueil.Click += btnConsulterAccueil_Click;
            // 
            // btnAdminAccueil
            // 
            btnAdminAccueil.Location = new Point(152, 340);
            btnAdminAccueil.Margin = new Padding(2, 2, 2, 2);
            btnAdminAccueil.Name = "btnAdminAccueil";
            btnAdminAccueil.Size = new Size(191, 43);
            btnAdminAccueil.TabIndex = 4;
            btnAdminAccueil.Text = "Administrer le réseau";
            btnAdminAccueil.UseVisualStyleBackColor = true;
            btnAdminAccueil.Click += btnAdminAccueil_Click;
            // 
            // AccueilOrizo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(498, 426);
            Controls.Add(btnAdminAccueil);
            Controls.Add(btnConsulterAccueil);
            Controls.Add(lblAccueilChoix);
            Controls.Add(picAccueil);
            MaximumSize = new Size(514, 465);
            MinimumSize = new Size(514, 465);
            Name = "AccueilOrizo";
            Text = "Réseau de transport";
            FormClosing += AccueilOrizo_FormClosing;
            Load += Form1_Load;
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
