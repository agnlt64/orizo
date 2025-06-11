namespace orizo
{
    partial class AdministrerAjouterLigne
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
            btnRetourAjoutLigne = new Button();
            lblAjouterLigne = new Label();
            txtNomAjoutLigne = new TextBox();
            lblNomLigne = new Label();
            lblCouleurAjout = new Label();
            nudHeure1erAjout = new NumericUpDown();
            nudMin1erAjout = new NumericUpDown();
            lblHeurePremierAjout = new Label();
            lblHeure1er = new Label();
            nudNbPassageAjout = new NumericUpDown();
            lblNbPassageAjout = new Label();
            btnAjouter = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lstArrets = new ListBox();
            panel2 = new Panel();
            btnAjouterArret = new Button();
            nudArretHeures = new NumericUpDown();
            cmbArrets = new ComboBox();
            nudArretMinutes = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnCouleur = new Button();
            colorDialog1 = new ColorDialog();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNbPassageAjout).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudArretHeures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudArretMinutes).BeginInit();
            SuspendLayout();
            // 
            // btnRetourAjoutLigne
            // 
            btnRetourAjoutLigne.Location = new Point(8, 7);
            btnRetourAjoutLigne.Margin = new Padding(1);
            btnRetourAjoutLigne.Name = "btnRetourAjoutLigne";
            btnRetourAjoutLigne.Size = new Size(42, 35);
            btnRetourAjoutLigne.TabIndex = 18;
            btnRetourAjoutLigne.Text = "<-";
            btnRetourAjoutLigne.UseVisualStyleBackColor = true;
            btnRetourAjoutLigne.Click += btnRetourAjoutLigne_Click;
            // 
            // lblAjouterLigne
            // 
            lblAjouterLigne.AutoSize = true;
            lblAjouterLigne.Font = new Font("Segoe UI", 15F);
            lblAjouterLigne.Location = new Point(362, 17);
            lblAjouterLigne.Margin = new Padding(1, 0, 1, 0);
            lblAjouterLigne.Name = "lblAjouterLigne";
            lblAjouterLigne.Size = new Size(162, 28);
            lblAjouterLigne.TabIndex = 20;
            lblAjouterLigne.Text = "Ajouter une ligne";
            // 
            // txtNomAjoutLigne
            // 
            txtNomAjoutLigne.Location = new Point(223, 91);
            txtNomAjoutLigne.Margin = new Padding(2);
            txtNomAjoutLigne.Name = "txtNomAjoutLigne";
            txtNomAjoutLigne.Size = new Size(192, 23);
            txtNomAjoutLigne.TabIndex = 25;
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Font = new Font("Segoe UI", 11F);
            lblNomLigne.Location = new Point(256, 70);
            lblNomLigne.Margin = new Padding(1, 0, 1, 0);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(116, 20);
            lblNomLigne.TabIndex = 24;
            lblNomLigne.Text = "Nom de la ligne";
            // 
            // lblCouleurAjout
            // 
            lblCouleurAjout.AutoSize = true;
            lblCouleurAjout.Font = new Font("Segoe UI", 11F);
            lblCouleurAjout.Location = new Point(539, 70);
            lblCouleurAjout.Margin = new Padding(1, 0, 1, 0);
            lblCouleurAjout.Name = "lblCouleurAjout";
            lblCouleurAjout.Size = new Size(60, 20);
            lblCouleurAjout.TabIndex = 26;
            lblCouleurAjout.Text = "Couleur";
            // 
            // nudHeure1erAjout
            // 
            nudHeure1erAjout.Location = new Point(10, 39);
            nudHeure1erAjout.Margin = new Padding(2);
            nudHeure1erAjout.Name = "nudHeure1erAjout";
            nudHeure1erAjout.Size = new Size(80, 23);
            nudHeure1erAjout.TabIndex = 27;
            // 
            // nudMin1erAjout
            // 
            nudMin1erAjout.Location = new Point(124, 39);
            nudMin1erAjout.Margin = new Padding(2);
            nudMin1erAjout.Name = "nudMin1erAjout";
            nudMin1erAjout.Size = new Size(77, 23);
            nudMin1erAjout.TabIndex = 34;
            // 
            // lblHeurePremierAjout
            // 
            lblHeurePremierAjout.AutoSize = true;
            lblHeurePremierAjout.Font = new Font("Segoe UI", 11F);
            lblHeurePremierAjout.Location = new Point(23, 12);
            lblHeurePremierAjout.Margin = new Padding(1, 0, 1, 0);
            lblHeurePremierAjout.Name = "lblHeurePremierAjout";
            lblHeurePremierAjout.Size = new Size(153, 20);
            lblHeurePremierAjout.TabIndex = 35;
            lblHeurePremierAjout.Text = "Heure du 1er passage";
            // 
            // lblHeure1er
            // 
            lblHeure1er.AutoSize = true;
            lblHeure1er.Font = new Font("Segoe UI", 15F);
            lblHeure1er.Location = new Point(93, 33);
            lblHeure1er.Margin = new Padding(1, 0, 1, 0);
            lblHeure1er.Name = "lblHeure1er";
            lblHeure1er.Size = new Size(26, 28);
            lblHeure1er.TabIndex = 40;
            lblHeure1er.Text = "H";
            // 
            // nudNbPassageAjout
            // 
            nudNbPassageAjout.Location = new Point(11, 132);
            nudNbPassageAjout.Margin = new Padding(2);
            nudNbPassageAjout.Name = "nudNbPassageAjout";
            nudNbPassageAjout.Size = new Size(190, 23);
            nudNbPassageAjout.TabIndex = 41;
            // 
            // lblNbPassageAjout
            // 
            lblNbPassageAjout.AutoSize = true;
            lblNbPassageAjout.Font = new Font("Segoe UI", 11F);
            lblNbPassageAjout.Location = new Point(23, 104);
            lblNbPassageAjout.Margin = new Padding(1, 0, 1, 0);
            lblNbPassageAjout.Name = "lblNbPassageAjout";
            lblNbPassageAjout.Size = new Size(149, 20);
            lblNbPassageAjout.TabIndex = 42;
            lblNbPassageAjout.Text = "Nombre de passages";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(358, 401);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(225, 32);
            btnAjouter.TabIndex = 43;
            btnAjouter.Text = "Ajouter la ligne";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(nudMin1erAjout);
            panel1.Controls.Add(nudHeure1erAjout);
            panel1.Controls.Add(lblNbPassageAjout);
            panel1.Controls.Add(lblHeurePremierAjout);
            panel1.Controls.Add(nudNbPassageAjout);
            panel1.Controls.Add(lblHeure1er);
            panel1.Location = new Point(110, 154);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 210);
            panel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 122);
            label1.Name = "label1";
            label1.Size = new Size(657, 15);
            label1.TabIndex = 45;
            label1.Text = "__________________________________________________________________________________________________________________________________";
            // 
            // lstArrets
            // 
            lstArrets.FormattingEnabled = true;
            lstArrets.ItemHeight = 15;
            lstArrets.Location = new Point(599, 152);
            lstArrets.Margin = new Padding(3, 2, 3, 2);
            lstArrets.Name = "lstArrets";
            lstArrets.Size = new Size(202, 214);
            lstArrets.TabIndex = 48;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnAjouterArret);
            panel2.Controls.Add(nudArretHeures);
            panel2.Controls.Add(cmbArrets);
            panel2.Controls.Add(nudArretMinutes);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(358, 152);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 214);
            panel2.TabIndex = 49;
            // 
            // btnAjouterArret
            // 
            btnAjouterArret.Location = new Point(15, 174);
            btnAjouterArret.Margin = new Padding(3, 2, 3, 2);
            btnAjouterArret.Name = "btnAjouterArret";
            btnAjouterArret.Size = new Size(191, 22);
            btnAjouterArret.TabIndex = 47;
            btnAjouterArret.Text = "Ajouter l'arrêt";
            btnAjouterArret.UseVisualStyleBackColor = true;
            btnAjouterArret.Click += btnAjouterArret_Click;
            // 
            // nudArretHeures
            // 
            nudArretHeures.Location = new Point(20, 132);
            nudArretHeures.Margin = new Padding(2);
            nudArretHeures.Name = "nudArretHeures";
            nudArretHeures.Size = new Size(80, 23);
            nudArretHeures.TabIndex = 43;
            // 
            // cmbArrets
            // 
            cmbArrets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArrets.FormattingEnabled = true;
            cmbArrets.Location = new Point(35, 42);
            cmbArrets.Margin = new Padding(3, 2, 3, 2);
            cmbArrets.Name = "cmbArrets";
            cmbArrets.Size = new Size(154, 23);
            cmbArrets.TabIndex = 44;
            // 
            // nudArretMinutes
            // 
            nudArretMinutes.Location = new Point(134, 132);
            nudArretMinutes.Margin = new Padding(2);
            nudArretMinutes.Name = "nudArretMinutes";
            nudArretMinutes.Size = new Size(77, 23);
            nudArretMinutes.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(102, 126);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(26, 28);
            label5.TabIndex = 46;
            label5.Text = "H";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(56, 16);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 43;
            label4.Text = "Arrêt à ajouter";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(35, 88);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 38);
            label6.TabIndex = 45;
            label6.Text = "Temps de trajet depuis \r\nl'arrêt précédent";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCouleur
            // 
            btnCouleur.BackColor = Color.White;
            btnCouleur.Location = new Point(560, 91);
            btnCouleur.Margin = new Padding(3, 2, 3, 2);
            btnCouleur.Name = "btnCouleur";
            btnCouleur.Size = new Size(25, 22);
            btnCouleur.TabIndex = 49;
            btnCouleur.UseVisualStyleBackColor = false;
            btnCouleur.Click += btnCouleur_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // AdministrerAjouterLigne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 482);
            Controls.Add(btnCouleur);
            Controls.Add(panel2);
            Controls.Add(lstArrets);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnAjouter);
            Controls.Add(lblCouleurAjout);
            Controls.Add(txtNomAjoutLigne);
            Controls.Add(lblNomLigne);
            Controls.Add(lblAjouterLigne);
            Controls.Add(btnRetourAjoutLigne);
            Margin = new Padding(2);
            MaximumSize = new Size(929, 521);
            MinimumSize = new Size(929, 521);
            Name = "AdministrerAjouterLigne";
            Text = "AdministrerAjouterLigne";
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNbPassageAjout).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudArretHeures).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudArretMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetourAjoutLigne;
        private Label lblAjouterLigne;
        private TextBox txtNomAjoutLigne;
        private Label lblNomLigne;
        private Label lblCouleurAjout;
        private NumericUpDown nudHeure1erAjout;
        private NumericUpDown nudMin1erAjout;
        private Label lblHeurePremierAjout;
        private Label lblHeure1er;
        private NumericUpDown nudNbPassageAjout;
        private Label lblNbPassageAjout;
        private Button btnAjouter;
        private Panel panel1;
        private Label label1;
        private ListBox lstArrets;
        private Panel panel2;
        private Button btnAjouterArret;
        private NumericUpDown nudArretHeures;
        private ComboBox cmbArrets;
        private NumericUpDown nudArretMinutes;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button btnCouleur;
        private ColorDialog colorDialog1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}