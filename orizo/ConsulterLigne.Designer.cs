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
            btnretour = new Button();
            dgvconsulterligne = new DataGridView();
            Arrêt = new DataGridViewTextBoxColumn();
            Horaires = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvconsulterligne).BeginInit();
            SuspendLayout();
            // 
            // btnretour
            // 
            btnretour.Location = new Point(23, 12);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(56, 52);
            btnretour.TabIndex = 2;
            btnretour.Text = "<-";
            btnretour.UseVisualStyleBackColor = true;
            btnretour.Click += btnretour_Click;
            // 
            // dgvconsulterligne
            // 
            dgvconsulterligne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvconsulterligne.Columns.AddRange(new DataGridViewColumn[] { Arrêt, Horaires });
            dgvconsulterligne.Location = new Point(80, 123);
            dgvconsulterligne.Name = "dgvconsulterligne";
            dgvconsulterligne.RowHeadersWidth = 51;
            dgvconsulterligne.Size = new Size(613, 315);
            dgvconsulterligne.TabIndex = 3;
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
            Controls.Add(dgvconsulterligne);
            Controls.Add(btnretour);
            Name = "ConsulterLigne";
            Text = "Réseau de transport - Consultation";
            ((System.ComponentModel.ISupportInitialize)dgvconsulterligne).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnretour;
        private DataGridView dgvconsulterligne;
        private DataGridViewTextBoxColumn Arrêt;
        private DataGridViewTextBoxColumn Horaires;
    }
}