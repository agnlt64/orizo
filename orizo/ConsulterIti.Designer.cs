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
            cmbdepart = new ComboBox();
            cmbarrive = new ComboBox();
            btnretour = new Button();
            lblchercher = new Label();
            lbldepart = new Label();
            lblarrive = new Label();
            lblheure = new Label();
            chkdepart = new CheckBox();
            chkarrive = new CheckBox();
            btnrecherche = new Button();
            nudheure = new NumericUpDown();
            nudminute = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudheure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudminute).BeginInit();
            SuspendLayout();
            // 
            // cmbdepart
            // 
            cmbdepart.FormattingEnabled = true;
            cmbdepart.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            cmbdepart.Location = new Point(216, 124);
            cmbdepart.Name = "cmbdepart";
            cmbdepart.Size = new Size(328, 28);
            cmbdepart.TabIndex = 0;
            // 
            // cmbarrive
            // 
            cmbarrive.FormattingEnabled = true;
            cmbarrive.Items.AddRange(new object[] { "Arrêt 1", "Arrêt 2", "Arrêt 3" });
            cmbarrive.Location = new Point(216, 232);
            cmbarrive.Name = "cmbarrive";
            cmbarrive.Size = new Size(328, 28);
            cmbarrive.TabIndex = 1;
            // 
            // btnretour
            // 
            btnretour.Location = new Point(12, 12);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(41, 46);
            btnretour.TabIndex = 2;
            btnretour.Text = "<-";
            btnretour.UseVisualStyleBackColor = true;
            btnretour.Click += btnretour_Click;
            // 
            // lblchercher
            // 
            lblchercher.AutoSize = true;
            lblchercher.Font = new Font("Segoe UI", 15F);
            lblchercher.Location = new Point(259, 13);
            lblchercher.Name = "lblchercher";
            lblchercher.Size = new Size(253, 35);
            lblchercher.TabIndex = 3;
            lblchercher.Text = "Chercher un itinéraire";
            // 
            // lbldepart
            // 
            lbldepart.AutoSize = true;
            lbldepart.Location = new Point(333, 88);
            lbldepart.Name = "lbldepart";
            lbldepart.Size = new Size(111, 20);
            lbldepart.TabIndex = 4;
            lbldepart.Text = "Arrêt de départ";
            // 
            // lblarrive
            // 
            lblarrive.AutoSize = true;
            lblarrive.Location = new Point(341, 209);
            lblarrive.Name = "lblarrive";
            lblarrive.Size = new Size(103, 20);
            lblarrive.TabIndex = 5;
            lblarrive.Text = "Arrêt d'arrivée";
            // 
            // lblheure
            // 
            lblheure.AutoSize = true;
            lblheure.Font = new Font("Segoe UI", 9F);
            lblheure.Location = new Point(371, 312);
            lblheure.Name = "lblheure";
            lblheure.Size = new Size(20, 20);
            lblheure.TabIndex = 8;
            lblheure.Text = "H";
            // 
            // chkdepart
            // 
            chkdepart.AutoSize = true;
            chkdepart.Location = new Point(224, 367);
            chkdepart.Name = "chkdepart";
            chkdepart.Size = new Size(140, 24);
            chkdepart.TabIndex = 9;
            chkdepart.Text = "Heure de départ";
            chkdepart.UseVisualStyleBackColor = true;
            // 
            // chkarrive
            // 
            chkarrive.AutoSize = true;
            chkarrive.Location = new Point(412, 367);
            chkarrive.Name = "chkarrive";
            chkarrive.Size = new Size(132, 24);
            chkarrive.TabIndex = 10;
            chkarrive.Text = "Heure d'arrivée";
            chkarrive.UseVisualStyleBackColor = true;
            // 
            // btnrecherche
            // 
            btnrecherche.Location = new Point(216, 409);
            btnrecherche.Name = "btnrecherche";
            btnrecherche.Size = new Size(328, 29);
            btnrecherche.TabIndex = 11;
            btnrecherche.Text = "Effectuer une recherche";
            btnrecherche.UseVisualStyleBackColor = true;
            btnrecherche.Click += btnrecherche_Click;
            // 
            // nudheure
            // 
            nudheure.Location = new Point(323, 305);
            nudheure.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudheure.Name = "nudheure";
            nudheure.Size = new Size(41, 27);
            nudheure.TabIndex = 12;
            // 
            // nudminute
            // 
            nudminute.Location = new Point(397, 305);
            nudminute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudminute.Name = "nudminute";
            nudminute.Size = new Size(41, 27);
            nudminute.TabIndex = 13;
            // 
            // ConsulterIti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudminute);
            Controls.Add(nudheure);
            Controls.Add(btnrecherche);
            Controls.Add(chkarrive);
            Controls.Add(chkdepart);
            Controls.Add(lblheure);
            Controls.Add(lblarrive);
            Controls.Add(lbldepart);
            Controls.Add(lblchercher);
            Controls.Add(btnretour);
            Controls.Add(cmbarrive);
            Controls.Add(cmbdepart);
            Name = "ConsulterIti";
            Text = "Réseau de transport - Consultation";
            ((System.ComponentModel.ISupportInitialize)nudheure).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudminute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbdepart;
        private ComboBox cmbarrive;
        private Button btnretour;
        private Label lblchercher;
        private Label lbldepart;
        private Label lblarrive;
        private Label lblheure;
        private CheckBox chkdepart;
        private CheckBox chkarrive;
        private Button btnrecherche;
        private NumericUpDown nudheure;
        private NumericUpDown nudminute;
    }
}