namespace orizo
{
    partial class ConsulterLigne
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
            btnRetour = new Button();
            dgvConsulterLigne = new DataGridView();
            Arrêt = new DataGridViewTextBoxColumn();
            Horaires = new DataGridViewTextBoxColumn();
            lblConsulterLigne = new Label();
            lblIndication = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConsulterLigne).BeginInit();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(41, 46);
            btnRetour.TabIndex = 2;
            btnRetour.Text = "<-";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnretour_Click;
            // 
            // dgvConsulterLigne
            // 
            dgvConsulterLigne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulterLigne.Columns.AddRange(new DataGridViewColumn[] { Arrêt, Horaires });
            dgvConsulterLigne.Location = new Point(80, 123);
            dgvConsulterLigne.Name = "dgvConsulterLigne";
            dgvConsulterLigne.RowHeadersWidth = 51;
            dgvConsulterLigne.Size = new Size(613, 315);
            dgvConsulterLigne.TabIndex = 3;
            // 
            // Arrêt
            // 
            Arrêt.HeaderText = "Arrêt";
            Arrêt.MinimumWidth = 6;
            Arrêt.Name = "Arrêt";
            Arrêt.Width = 125;
            // 
            // Horaires
            // 
            Horaires.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Horaires.HeaderText = "Horaires";
            Horaires.MinimumWidth = 6;
            Horaires.Name = "Horaires";
            // 
            // lblConsulterLigne
            // 
            lblConsulterLigne.AutoSize = true;
            lblConsulterLigne.Font = new Font("Segoe UI", 15F);
            lblConsulterLigne.Location = new Point(278, 23);
            lblConsulterLigne.Name = "lblConsulterLigne";
            lblConsulterLigne.Size = new Size(229, 35);
            lblConsulterLigne.TabIndex = 10;
            lblConsulterLigne.Text = "Consulter une ligne";
            // 
            // lblIndication
            // 
            lblIndication.AutoSize = true;
            lblIndication.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            lblIndication.Location = new Point(351, 79);
            lblIndication.Name = "lblIndication";
            lblIndication.Size = new Size(81, 28);
            lblIndication.TabIndex = 11;
            lblIndication.Text = "Ligne 1";
            lblIndication.TextAlign = ContentAlignment.TopCenter;
            // 
            // ConsulterLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndication);
            Controls.Add(lblConsulterLigne);
            Controls.Add(dgvConsulterLigne);
            Controls.Add(btnRetour);
            Name = "ConsulterLigne";
            Text = "Réseau de transport - Consultation";
            ((System.ComponentModel.ISupportInitialize)dgvConsulterLigne).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRetour;
        private DataGridView dgvConsulterLigne;
        private DataGridViewTextBoxColumn Arrêt;
        private DataGridViewTextBoxColumn Horaires;
        private Label lblConsulterLigne;
        private Label lblIndication;
    }
}