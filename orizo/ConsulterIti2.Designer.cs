namespace orizo
{
    partial class ConsulterIti2
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
            lbliti = new Label();
            lblindication = new Label();
            dataGridView1 = new DataGridView();
            Ligne = new DataGridViewTextBoxColumn();
            Départ = new DataGridViewTextBoxColumn();
            Arrivée = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnretour
            // 
            btnretour.Location = new Point(12, 12);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(41, 46);
            btnretour.TabIndex = 3;
            btnretour.Text = "<-";
            btnretour.UseVisualStyleBackColor = true;
            btnretour.Click += btnretour_Click;
            // 
            // lbliti
            // 
            lbliti.AutoSize = true;
            lbliti.Font = new Font("Segoe UI", 15F);
            lbliti.Location = new Point(321, 9);
            lbliti.Name = "lbliti";
            lbliti.Size = new Size(113, 35);
            lbliti.TabIndex = 4;
            lbliti.Text = "Itinéraire";
            // 
            // lblindication
            // 
            lblindication.AutoSize = true;
            lblindication.Location = new Point(361, 57);
            lblindication.Name = "lblindication";
            lblindication.Size = new Size(17, 20);
            lblindication.TabIndex = 5;
            lblindication.Text = "a";
            lblindication.Click += lblindication_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ligne, Départ, Arrivée });
            dataGridView1.Location = new Point(412, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(376, 321);
            dataGridView1.TabIndex = 6;
            // 
            // Ligne
            // 
            Ligne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ligne.HeaderText = "Ligne";
            Ligne.MinimumWidth = 6;
            Ligne.Name = "Ligne";
            // 
            // Départ
            // 
            Départ.HeaderText = "Départ";
            Départ.MinimumWidth = 6;
            Départ.Name = "Départ";
            Départ.Width = 125;
            // 
            // Arrivée
            // 
            Arrivée.HeaderText = "Arrivée";
            Arrivée.MinimumWidth = 6;
            Arrivée.Name = "Arrivée";
            Arrivée.Width = 125;
            // 
            // ConsulterIti2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(lblindication);
            Controls.Add(lbliti);
            Controls.Add(btnretour);
            Name = "ConsulterIti2";
            Text = "ConsulterIti2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnretour;
        private Label lbliti;
        private Label lblindication;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Ligne;
        private DataGridViewTextBoxColumn Départ;
        private DataGridViewTextBoxColumn Arrivée;
    }
}