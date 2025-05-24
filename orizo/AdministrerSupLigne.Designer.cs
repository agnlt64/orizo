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
            lstSupLigne.ItemHeight = 25;
            lstSupLigne.Items.AddRange(new object[] { "Ligne 1", "Ligne 2", "Ligne 3" });
            lstSupLigne.Location = new Point(320, 117);
            lstSupLigne.Name = "lstSupLigne";
            lstSupLigne.RightToLeft = RightToLeft.No;
            lstSupLigne.Size = new Size(385, 379);
            lstSupLigne.TabIndex = 18;
            lstSupLigne.SelectedIndexChanged += lstSupLigne_SelectedIndexChanged;
            // 
            // lblSupLigne
            // 
            lblSupLigne.AutoSize = true;
            lblSupLigne.Font = new Font("Segoe UI", 15F);
            lblSupLigne.Location = new Point(386, 73);
            lblSupLigne.Margin = new Padding(2, 0, 2, 0);
            lblSupLigne.Name = "lblSupLigne";
            lblSupLigne.Size = new Size(287, 41);
            lblSupLigne.TabIndex = 17;
            lblSupLigne.Text = "Supprimer une ligne";
            // 
            // btnSupLigne
            // 
            btnSupLigne.Location = new Point(370, 541);
            btnSupLigne.Margin = new Padding(2);
            btnSupLigne.Name = "btnSupLigne";
            btnSupLigne.Size = new Size(272, 71);
            btnSupLigne.TabIndex = 16;
            btnSupLigne.Text = "Supprimer";
            btnSupLigne.UseVisualStyleBackColor = true;
            btnSupLigne.Click += btnSupLigne_Click;
            // 
            // btnRetourSupLigne
            // 
            btnRetourSupLigne.Location = new Point(11, 11);
            btnRetourSupLigne.Margin = new Padding(2);
            btnRetourSupLigne.Name = "btnRetourSupLigne";
            btnRetourSupLigne.Size = new Size(60, 58);
            btnRetourSupLigne.TabIndex = 15;
            btnRetourSupLigne.Text = "<-";
            btnRetourSupLigne.UseVisualStyleBackColor = true;
            btnRetourSupLigne.Click += btnRetourSupLigne_Click;
            // 
            // AdministrerSupLigne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 678);
            Controls.Add(lstSupLigne);
            Controls.Add(lblSupLigne);
            Controls.Add(btnSupLigne);
            Controls.Add(btnRetourSupLigne);
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