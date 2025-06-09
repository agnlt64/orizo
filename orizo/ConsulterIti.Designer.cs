namespace orizo
{
    partial class ConsulterIti
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
            cmbDepart = new ComboBox();
            cmbArrive = new ComboBox();
            btnRetour = new Button();
            lblChercher = new Label();
            lblDepart = new Label();
            lblArrive = new Label();
            lblHeure = new Label();
            btnRecherche = new Button();
            nudHeure = new NumericUpDown();
            nudMinute = new NumericUpDown();
            panel1 = new Panel();
            panel2 = new Panel();
            this.chkArrivee = new RadioButton();
            chkDepart = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nudHeure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinute).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbDepart
            // 
            cmbDepart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepart.FormattingEnabled = true;
            cmbDepart.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            cmbDepart.Location = new Point(17, 34);
            cmbDepart.Margin = new Padding(3, 2, 3, 2);
            cmbDepart.Name = "cmbDepart";
            cmbDepart.Size = new Size(321, 23);
            cmbDepart.TabIndex = 0;
            // 
            // cmbArrive
            // 
            cmbArrive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArrive.FormattingEnabled = true;
            cmbArrive.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            cmbArrive.Location = new Point(17, 92);
            cmbArrive.Margin = new Padding(3, 2, 3, 2);
            cmbArrive.Name = "cmbArrive";
            cmbArrive.Size = new Size(321, 23);
            cmbArrive.TabIndex = 1;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(10, 9);
            btnRetour.Margin = new Padding(3, 2, 3, 2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(36, 34);
            btnRetour.TabIndex = 2;
            btnRetour.Text = "<-";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnretour_Click;
            // 
            // lblChercher
            // 
            lblChercher.AutoSize = true;
            lblChercher.Font = new Font("Segoe UI", 15F);
            lblChercher.Location = new Point(135, 32);
            lblChercher.Name = "lblChercher";
            lblChercher.Size = new Size(198, 28);
            lblChercher.TabIndex = 3;
            lblChercher.Text = "Chercher un itinéraire";
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Segoe UI", 11F);
            lblDepart.Location = new Point(17, 13);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(111, 20);
            lblDepart.TabIndex = 4;
            lblDepart.Text = "Arrêt de départ";
            // 
            // lblArrive
            // 
            lblArrive.AutoSize = true;
            lblArrive.Font = new Font("Segoe UI", 11F);
            lblArrive.Location = new Point(17, 71);
            lblArrive.Name = "lblArrive";
            lblArrive.Size = new Size(141, 20);
            lblArrive.TabIndex = 5;
            lblArrive.Text = "Arrêt de destination";
            // 
            // lblHeure
            // 
            lblHeure.AutoSize = true;
            lblHeure.Font = new Font("Segoe UI", 11F);
            lblHeure.Location = new Point(239, 240);
            lblHeure.Name = "lblHeure";
            lblHeure.Size = new Size(20, 20);
            lblHeure.TabIndex = 8;
            lblHeure.Text = "H";
            // 
            // btnRecherche
            // 
            btnRecherche.Location = new Point(69, 324);
            btnRecherche.Margin = new Padding(3, 2, 3, 2);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(356, 34);
            btnRecherche.TabIndex = 11;
            btnRecherche.Text = "Effectuer une recherche";
            btnRecherche.UseVisualStyleBackColor = true;
            btnRecherche.Click += btnrecherche_Click;
            // 
            // nudHeure
            // 
            nudHeure.Location = new Point(177, 240);
            nudHeure.Margin = new Padding(3, 2, 3, 2);
            nudHeure.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHeure.Name = "nudHeure";
            nudHeure.Size = new Size(57, 23);
            nudHeure.TabIndex = 12;
            // 
            // nudMinute
            // 
            nudMinute.Location = new Point(266, 240);
            nudMinute.Margin = new Padding(3, 2, 3, 2);
            nudMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinute.Name = "nudMinute";
            nudMinute.Size = new Size(56, 23);
            nudMinute.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblArrive);
            panel1.Controls.Add(cmbDepart);
            panel1.Controls.Add(cmbArrive);
            panel1.Controls.Add(lblDepart);
            panel1.Location = new Point(69, 85);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 128);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(this.chkArrivee);
            panel2.Controls.Add(chkDepart);
            panel2.Location = new Point(69, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 38);
            panel2.TabIndex = 15;
            // 
            // chkArrivee
            // 
            this.chkArrivee.AutoSize = true;
            this.chkArrivee.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkArrivee.Location = new Point(226, 8);
            this.chkArrivee.Name = "chkArrivee";
            this.chkArrivee.Size = new Size(128, 24);
            this.chkArrivee.TabIndex = 1;
            this.chkArrivee.TabStop = true;
            this.chkArrivee.Text = "Heure d'arrivée";
            this.chkArrivee.UseVisualStyleBackColor = true;
            // 
            // chkDepart
            // 
            chkDepart.AutoSize = true;
            chkDepart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDepart.Location = new Point(4, 8);
            chkDepart.Name = "chkDepart";
            chkDepart.Size = new Size(136, 24);
            chkDepart.TabIndex = 0;
            chkDepart.TabStop = true;
            chkDepart.Text = "Heure de départ";
            chkDepart.UseVisualStyleBackColor = true;
            // 
            // ConsulterIti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 386);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(nudMinute);
            Controls.Add(nudHeure);
            Controls.Add(btnRecherche);
            Controls.Add(lblHeure);
            Controls.Add(lblChercher);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(500, 425);
            MinimizeBox = false;
            MinimumSize = new Size(500, 425);
            Name = "ConsulterIti";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Réseau de transport - Consultation";
            ((System.ComponentModel.ISupportInitialize)nudHeure).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinute).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDepart;
        private ComboBox cmbArrive;
        private Button btnRetour;
        private Label lblChercher;
        private Label lblDepart;
        private Label lblArrive;
        private Label lblHeure;
        private Button btnRecherche;
        private NumericUpDown nudHeure;
        private NumericUpDown nudMinute;
        private Panel panel1;
        private Panel panel2;
        private RadioButton chkArrivee;
        private RadioButton chkDepart;
    }
}