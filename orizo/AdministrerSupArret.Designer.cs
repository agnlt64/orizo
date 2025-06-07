namespace orizo
{
    partial class AdministrerSupArret
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
            btnRetourSupArret = new Button();
            btnSupArret = new Button();
            lblSupArret = new Label();
            lstSupArret = new ListBox();
            SuspendLayout();
            // 
            // btnRetourSupArret
            // 
            btnRetourSupArret.Location = new Point(9, 9);
            btnRetourSupArret.Margin = new Padding(2);
            btnRetourSupArret.Name = "btnRetourSupArret";
            btnRetourSupArret.Size = new Size(48, 46);
            btnRetourSupArret.TabIndex = 11;
            btnRetourSupArret.Text = "<-";
            btnRetourSupArret.UseVisualStyleBackColor = true;
            btnRetourSupArret.Click += btnRetourSupArret_Click;
            // 
            // btnSupArret
            // 
            btnSupArret.Location = new Point(131, 466);
            btnSupArret.Margin = new Padding(2);
            btnSupArret.Name = "btnSupArret";
            btnSupArret.Size = new Size(309, 43);
            btnSupArret.TabIndex = 12;
            btnSupArret.Text = "Supprimer";
            btnSupArret.UseVisualStyleBackColor = true;
            btnSupArret.Click += btnSupArret_Click;
            // 
            // lblSupArret
            // 
            lblSupArret.AutoSize = true;
            lblSupArret.Font = new Font("Segoe UI", 15F);
            lblSupArret.Location = new Point(171, 71);
            lblSupArret.Margin = new Padding(2, 0, 2, 0);
            lblSupArret.Name = "lblSupArret";
            lblSupArret.Size = new Size(225, 35);
            lblSupArret.TabIndex = 13;
            lblSupArret.Text = "Supprimer un arrêt";
            // 
            // lstSupArret
            // 
            lstSupArret.FormattingEnabled = true;
            lstSupArret.Items.AddRange(new object[] { "arret 1", "Arret 2", "arret 3" });
            lstSupArret.Location = new Point(131, 143);
            lstSupArret.Margin = new Padding(2, 2, 2, 2);
            lstSupArret.Name = "lstSupArret";
            lstSupArret.Size = new Size(309, 304);
            lstSupArret.TabIndex = 14;
            lstSupArret.SelectedIndexChanged += lstSupArret_SelectedIndexChanged;
            // 
            // AdministrerSupArret
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 560);
            Controls.Add(lstSupArret);
            Controls.Add(lblSupArret);
            Controls.Add(btnSupArret);
            Controls.Add(btnRetourSupArret);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(585, 607);
            MinimumSize = new Size(585, 607);
            Name = "AdministrerSupArret";
            Text = "AdministrerSupArret";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetourSupArret;
        private Button btnSupArret;
        private Label lblSupArret;
        private ListBox lstSupArret;
    }
}