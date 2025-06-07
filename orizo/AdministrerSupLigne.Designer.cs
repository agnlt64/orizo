namespace orizo
{
    partial class AdministrerSupLigne
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
            lstSupLigne = new ListBox();
            lblSupLigne = new Label();
            btnSupLigne = new Button();
            btnRetourSupLigne = new Button();
            SuspendLayout();
            // 
            // lstSupLigne
            // 
            lstSupLigne.FormattingEnabled = true;
            lstSupLigne.Items.AddRange(new object[] { "Ligne 1", "Ligne 2", "Ligne 3" });
            lstSupLigne.Location = new Point(133, 131);
            lstSupLigne.Margin = new Padding(2, 2, 2, 2);
            lstSupLigne.Name = "lstSupLigne";
            lstSupLigne.RightToLeft = RightToLeft.No;
            lstSupLigne.Size = new Size(309, 324);
            lstSupLigne.TabIndex = 18;
            lstSupLigne.SelectedIndexChanged += lstSupLigne_SelectedIndexChanged;
            // 
            // lblSupLigne
            // 
            lblSupLigne.AutoSize = true;
            lblSupLigne.Font = new Font("Segoe UI", 15F);
            lblSupLigne.Location = new Point(166, 58);
            lblSupLigne.Margin = new Padding(2, 0, 2, 0);
            lblSupLigne.Name = "lblSupLigne";
            lblSupLigne.Size = new Size(240, 35);
            lblSupLigne.TabIndex = 17;
            lblSupLigne.Text = "Supprimer une ligne";
            // 
            // btnSupLigne
            // 
            btnSupLigne.Location = new Point(133, 476);
            btnSupLigne.Margin = new Padding(2);
            btnSupLigne.Name = "btnSupLigne";
            btnSupLigne.Size = new Size(309, 44);
            btnSupLigne.TabIndex = 16;
            btnSupLigne.Text = "Supprimer";
            btnSupLigne.UseVisualStyleBackColor = true;
            btnSupLigne.Click += btnSupLigne_Click;
            // 
            // btnRetourSupLigne
            // 
            btnRetourSupLigne.Location = new Point(9, 9);
            btnRetourSupLigne.Margin = new Padding(2);
            btnRetourSupLigne.Name = "btnRetourSupLigne";
            btnRetourSupLigne.Size = new Size(48, 46);
            btnRetourSupLigne.TabIndex = 15;
            btnRetourSupLigne.Text = "<-";
            btnRetourSupLigne.UseVisualStyleBackColor = true;
            btnRetourSupLigne.Click += btnRetourSupLigne_Click;
            // 
            // AdministrerSupLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 560);
            Controls.Add(lstSupLigne);
            Controls.Add(lblSupLigne);
            Controls.Add(btnSupLigne);
            Controls.Add(btnRetourSupLigne);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(585, 607);
            MinimumSize = new Size(585, 607);
            Name = "AdministrerSupLigne";
            Text = "AdministrerSupLigne";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSupLigne;
        private Label lblSupLigne;
        private Button btnSupLigne;
        private Button btnRetourSupLigne;
    }
}