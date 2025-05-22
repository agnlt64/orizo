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
            ((System.ComponentModel.ISupportInitialize)nudHeure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinute).BeginInit();
            SuspendLayout();
            // 
            // cmbDepart
            // 
            cmbDepart.FormattingEnabled = true;
            cmbDepart.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            cmbDepart.Location = new Point(216, 124);
            cmbDepart.Name = "cmbDepart";
            cmbDepart.Size = new Size(328, 28);
            cmbDepart.TabIndex = 0;
            // 
            // cmbArrive
            // 
            cmbArrive.FormattingEnabled = true;
            cmbArrive.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            cmbArrive.Location = new Point(216, 232);
            cmbArrive.Name = "cmbArrive";
            cmbArrive.Size = new Size(328, 28);
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
            lblChercher.Location = new Point(259, 13);
            lblChercher.Name = "lblChercher";
            lblChercher.Size = new Size(253, 35);
            lblChercher.TabIndex = 3;
            lblChercher.Text = "Chercher un itinéraire";
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Location = new Point(333, 88);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(111, 20);
            lblDepart.TabIndex = 4;
            lblDepart.Text = "Arrêt de départ";
            // 
            // lblArrive
            // 
            lblArrive.AutoSize = true;
            lblArrive.Location = new Point(341, 209);
            lblArrive.Name = "lblArrive";
            lblArrive.Size = new Size(103, 20);
            lblArrive.TabIndex = 5;
            lblArrive.Text = "Arrêt d'arrivée";
            // 
            // lblHeure
            // 
            lblHeure.AutoSize = true;
            lblHeure.Font = new Font("Segoe UI", 9F);
            lblHeure.Location = new Point(371, 312);
            lblHeure.Name = "lblHeure";
            lblHeure.Size = new Size(20, 20);
            lblHeure.TabIndex = 8;
            lblHeure.Text = "H";
            // 
            // chkDepart
            // 
            chkDepart.AutoSize = true;
            chkDepart.Location = new Point(224, 367);
            chkDepart.Name = "chkDepart";
            chkDepart.Size = new Size(140, 24);
            chkDepart.TabIndex = 9;
            chkDepart.Text = "Heure de départ";
            chkDepart.UseVisualStyleBackColor = true;
            // 
            // chkArrive
            // 
            chkArrive.AutoSize = true;
            chkArrive.Location = new Point(412, 367);
            chkArrive.Name = "chkArrive";
            chkArrive.Size = new Size(132, 24);
            chkArrive.TabIndex = 10;
            chkArrive.Text = "Heure d'arrivée";
            chkArrive.UseVisualStyleBackColor = true;
            // 
            // btnRecherche
            // 
            btnRecherche.Location = new Point(216, 409);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(328, 29);
            btnRecherche.TabIndex = 11;
            btnRecherche.Text = "Effectuer une recherche";
            btnRecherche.UseVisualStyleBackColor = true;
            btnRecherche.Click += btnrecherche_Click;
            // 
            // nudHeure
            // 
            nudHeure.Location = new Point(323, 305);
            nudHeure.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHeure.Name = "nudHeure";
            nudHeure.Size = new Size(41, 27);
            nudHeure.TabIndex = 12;
            // 
            // nudMinute
            // 
            nudMinute.Location = new Point(397, 305);
            nudMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinute.Name = "nudMinute";
            nudMinute.Size = new Size(41, 27);
            nudMinute.TabIndex = 13;
            // 
            // ConsulterIti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudMinute);
            Controls.Add(nudHeure);
            Controls.Add(btnRecherche);
            Controls.Add(chkArrive);
            Controls.Add(chkDepart);
            Controls.Add(lblHeure);
            Controls.Add(lblArrive);
            Controls.Add(lblDepart);
            Controls.Add(lblChercher);
            Controls.Add(btnRetour);
            Controls.Add(cmbArrive);
            Controls.Add(cmbDepart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "ConsulterIti";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Réseau de transport - Consultation";
            ((System.ComponentModel.ISupportInitialize)nudHeure).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinute).EndInit();
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
    }
}