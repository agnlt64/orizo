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
            chkDepart = new CheckBox();
            chkArrive = new CheckBox();
            btnRecherche = new Button();
            nudHeure = new NumericUpDown();
            nudMinute = new NumericUpDown();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudHeure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinute).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbDepart
            // 
            cmbDepart.FormattingEnabled = true;
            cmbDepart.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            cmbDepart.Location = new Point(19, 45);
            cmbDepart.Name = "cmbDepart";
            cmbDepart.Size = new Size(366, 28);
            cmbDepart.TabIndex = 0;
            // 
            // cmbArrive
            // 
            cmbArrive.FormattingEnabled = true;
            cmbArrive.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            cmbArrive.Location = new Point(19, 123);
            cmbArrive.Name = "cmbArrive";
            cmbArrive.Size = new Size(366, 28);
            cmbArrive.TabIndex = 1;
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
            // lblChercher
            // 
            lblChercher.AutoSize = true;
            lblChercher.Font = new Font("Segoe UI", 15F);
            lblChercher.Location = new Point(154, 42);
            lblChercher.Name = "lblChercher";
            lblChercher.Size = new Size(253, 35);
            lblChercher.TabIndex = 3;
            lblChercher.Text = "Chercher un itinéraire";
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Segoe UI", 11F);
            lblDepart.Location = new Point(19, 17);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(140, 25);
            lblDepart.TabIndex = 4;
            lblDepart.Text = "Arrêt de départ";
            // 
            // lblArrive
            // 
            lblArrive.AutoSize = true;
            lblArrive.Font = new Font("Segoe UI", 11F);
            lblArrive.Location = new Point(19, 95);
            lblArrive.Name = "lblArrive";
            lblArrive.Size = new Size(179, 25);
            lblArrive.TabIndex = 5;
            lblArrive.Text = "Arrêt de destination";
            // 
            // lblHeure
            // 
            lblHeure.AutoSize = true;
            lblHeure.Font = new Font("Segoe UI", 11F);
            lblHeure.Location = new Point(273, 320);
            lblHeure.Name = "lblHeure";
            lblHeure.Size = new Size(25, 25);
            lblHeure.TabIndex = 8;
            lblHeure.Text = "H";
            // 
            // chkDepart
            // 
            chkDepart.AutoSize = true;
            chkDepart.Font = new Font("Segoe UI", 11F);
            chkDepart.Location = new Point(88, 384);
            chkDepart.Name = "chkDepart";
            chkDepart.Size = new Size(171, 29);
            chkDepart.TabIndex = 9;
            chkDepart.Text = "Heure de départ";
            chkDepart.UseVisualStyleBackColor = true;
            // 
            // chkArrive
            // 
            chkArrive.AutoSize = true;
            chkArrive.Font = new Font("Segoe UI", 11F);
            chkArrive.Location = new Point(322, 384);
            chkArrive.Name = "chkArrive";
            chkArrive.Size = new Size(163, 29);
            chkArrive.TabIndex = 10;
            chkArrive.Text = "Heure d'arrivée";
            chkArrive.UseVisualStyleBackColor = true;
            // 
            // btnRecherche
            // 
            btnRecherche.Location = new Point(79, 432);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(406, 45);
            btnRecherche.TabIndex = 11;
            btnRecherche.Text = "Effectuer une recherche";
            btnRecherche.UseVisualStyleBackColor = true;
            btnRecherche.Click += btnrecherche_Click;
            // 
            // nudHeure
            // 
            nudHeure.Location = new Point(202, 320);
            nudHeure.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHeure.Name = "nudHeure";
            nudHeure.Size = new Size(65, 27);
            nudHeure.TabIndex = 12;
            // 
            // nudMinute
            // 
            nudMinute.Location = new Point(304, 320);
            nudMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinute.Name = "nudMinute";
            nudMinute.Size = new Size(64, 27);
            nudMinute.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblArrive);
            panel1.Controls.Add(cmbDepart);
            panel1.Controls.Add(cmbArrive);
            panel1.Controls.Add(lblDepart);
            panel1.Location = new Point(79, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 170);
            panel1.TabIndex = 14;
            // 
            // ConsulterIti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 506);
            Controls.Add(panel1);
            Controls.Add(nudMinute);
            Controls.Add(nudHeure);
            Controls.Add(btnRecherche);
            Controls.Add(chkArrive);
            Controls.Add(chkDepart);
            Controls.Add(lblHeure);
            Controls.Add(lblChercher);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(569, 553);
            MinimizeBox = false;
            MinimumSize = new Size(569, 553);
            Name = "ConsulterIti";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Réseau de transport - Consultation";
            ((System.ComponentModel.ISupportInitialize)nudHeure).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinute).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private CheckBox chkDepart;
        private CheckBox chkArrive;
        private Button btnRecherche;
        private NumericUpDown nudHeure;
        private NumericUpDown nudMinute;
        private Panel panel1;
    }
}