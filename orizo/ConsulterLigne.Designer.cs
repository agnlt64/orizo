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
            // ConsulterLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsulterLigne);
            Controls.Add(btnRetour);
            Name = "ConsulterLigne";
            Text = "Réseau de transport - Consultation";
            ((System.ComponentModel.ISupportInitialize)dgvConsulterLigne).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRetour;
        private DataGridView dgvConsulterLigne;
        private DataGridViewTextBoxColumn Arrêt;
        private DataGridViewTextBoxColumn Horaires;
    }
}