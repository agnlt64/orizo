namespace orizo
{
    public partial class Administrer : Form
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
            picAdmin = new PictureBox();
            btnRetourAdministrer = new Button();
            lblAccesAdmin = new Label();
            lblIdAdmin = new Label();
            lblMdpAdmin = new Label();
            txtIdAdmin = new TextBox();
            txtMdpAdmin = new TextBox();
            btnAdminConnexion = new Button();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            SuspendLayout();
            // 
            // picAdmin
            // 
            picAdmin.Image = Properties.Resources.Logo_orizo;
            picAdmin.Location = new Point(183, 19);
            picAdmin.Margin = new Padding(2);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(199, 178);
            picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            picAdmin.TabIndex = 1;
            picAdmin.TabStop = false;
            // 
            // btnRetourAdministrer
            // 
            btnRetourAdministrer.Location = new Point(10, 10);
            btnRetourAdministrer.Margin = new Padding(2);
            btnRetourAdministrer.Name = "btnRetourAdministrer";
            btnRetourAdministrer.Size = new Size(41, 46);
            btnRetourAdministrer.TabIndex = 2;
            btnRetourAdministrer.Text = "<-";
            btnRetourAdministrer.UseVisualStyleBackColor = true;
            btnRetourAdministrer.Click += btnRetourAdministrer_Click;
            // 
            // lblAccesAdmin
            // 
            lblAccesAdmin.AutoSize = true;
            lblAccesAdmin.Font = new Font("Segoe UI", 12F);
            lblAccesAdmin.Location = new Point(185, 254);
            lblAccesAdmin.Margin = new Padding(2, 0, 2, 0);
            lblAccesAdmin.Name = "lblAccesAdmin";
            lblAccesAdmin.Size = new Size(196, 28);
            lblAccesAdmin.TabIndex = 3;
            lblAccesAdmin.Text = "Accès Administration";
            // 
            // lblIdAdmin
            // 
            lblIdAdmin.AutoSize = true;
            lblIdAdmin.Location = new Point(183, 329);
            lblIdAdmin.Margin = new Padding(2, 0, 2, 0);
            lblIdAdmin.Name = "lblIdAdmin";
            lblIdAdmin.Size = new Size(77, 20);
            lblIdAdmin.TabIndex = 4;
            lblIdAdmin.Text = "Identifiant";
            // 
            // lblMdpAdmin
            // 
            lblMdpAdmin.AutoSize = true;
            lblMdpAdmin.Location = new Point(183, 399);
            lblMdpAdmin.Margin = new Padding(2, 0, 2, 0);
            lblMdpAdmin.Name = "lblMdpAdmin";
            lblMdpAdmin.Size = new Size(98, 20);
            lblMdpAdmin.TabIndex = 5;
            lblMdpAdmin.Text = "Mot de passe";
            // 
            // txtIdAdmin
            // 
            txtIdAdmin.Location = new Point(183, 351);
            txtIdAdmin.Margin = new Padding(2);
            txtIdAdmin.Name = "txtIdAdmin";
            txtIdAdmin.Size = new Size(200, 27);
            txtIdAdmin.TabIndex = 6;
            txtIdAdmin.TextChanged += txtIdAdmin_TextChanged;
            // 
            // txtMdpAdmin
            // 
            txtMdpAdmin.Location = new Point(183, 421);
            txtMdpAdmin.Margin = new Padding(2);
            txtMdpAdmin.Name = "txtMdpAdmin";
            txtMdpAdmin.Size = new Size(200, 27);
            txtMdpAdmin.TabIndex = 7;
            txtMdpAdmin.TextChanged += txtMdpAdmin_TextChanged;
            // 
            // btnAdminConnexion
            // 
            btnAdminConnexion.Location = new Point(183, 478);
            btnAdminConnexion.Margin = new Padding(2);
            btnAdminConnexion.Name = "btnAdminConnexion";
            btnAdminConnexion.Size = new Size(199, 48);
            btnAdminConnexion.TabIndex = 8;
            btnAdminConnexion.Text = "Connexion";
            btnAdminConnexion.UseVisualStyleBackColor = true;
            btnAdminConnexion.Click += btnAdminConnexion_Click;
            // 
            // Administrer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 560);
            Controls.Add(btnAdminConnexion);
            Controls.Add(txtMdpAdmin);
            Controls.Add(txtIdAdmin);
            Controls.Add(lblMdpAdmin);
            Controls.Add(lblIdAdmin);
            Controls.Add(lblAccesAdmin);
            Controls.Add(btnRetourAdministrer);
            Controls.Add(picAdmin);
            Margin = new Padding(2);
            MaximumSize = new Size(585, 607);
            MinimumSize = new Size(585, 607);
            Name = "Administrer";
            Text = "Réseau de transport - Administrer";
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAdmin;
        private Button btnRetourAdministrer;
        private Label lblAccesAdmin;
        private Label lblIdAdmin;
        private Label lblMdpAdmin;
        private TextBox txtIdAdmin;
        private TextBox txtMdpAdmin;
        private Button btnAdminConnexion;
    }
}