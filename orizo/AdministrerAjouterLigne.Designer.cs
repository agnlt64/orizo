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
            lblFrequenceAjout = new Label();
            nudFreqAjoutMin = new NumericUpDown();
            nudFreqHeureAjout = new NumericUpDown();
            lblHeureFreq = new Label();
            lblHeure1er = new Label();
            nudNbPassageAjout = new NumericUpDown();
            lblNbPassageAjout = new Label();
            btnAjouter = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqAjoutMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqHeureAjout).BeginInit();
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
            // lblFrequenceAjout
            // 
            lblFrequenceAjout.AutoSize = true;
            lblFrequenceAjout.Font = new Font("Segoe UI", 11F);
            lblFrequenceAjout.Location = new Point(18, 78);
            lblFrequenceAjout.Margin = new Padding(1, 0, 1, 0);
            lblFrequenceAjout.Name = "lblFrequenceAjout";
            lblFrequenceAjout.Size = new Size(156, 20);
            lblFrequenceAjout.TabIndex = 38;
            lblFrequenceAjout.Text = "Fréquence de passage";
            // 
            // nudFreqAjoutMin
            // 
            nudFreqAjoutMin.Location = new Point(124, 106);
            nudFreqAjoutMin.Margin = new Padding(2);
            nudFreqAjoutMin.Name = "nudFreqAjoutMin";
            nudFreqAjoutMin.Size = new Size(77, 23);
            nudFreqAjoutMin.TabIndex = 37;
            // 
            // nudFreqHeureAjout
            // 
            nudFreqHeureAjout.Location = new Point(10, 106);
            nudFreqHeureAjout.Margin = new Padding(2);
            nudFreqHeureAjout.Name = "nudFreqHeureAjout";
            nudFreqHeureAjout.Size = new Size(80, 23);
            nudFreqHeureAjout.TabIndex = 36;
            // 
            // lblHeureFreq
            // 
            lblHeureFreq.AutoSize = true;
            lblHeureFreq.Font = new Font("Segoe UI", 15F);
            lblHeureFreq.Location = new Point(93, 100);
            lblHeureFreq.Margin = new Padding(1, 0, 1, 0);
            lblHeureFreq.Name = "lblHeureFreq";
            lblHeureFreq.Size = new Size(26, 28);
            lblHeureFreq.TabIndex = 39;
            lblHeureFreq.Text = "H";
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
            nudNbPassageAjout.Location = new Point(11, 171);
            nudNbPassageAjout.Margin = new Padding(2);
            nudNbPassageAjout.Name = "nudNbPassageAjout";
            nudNbPassageAjout.Size = new Size(190, 23);
            nudNbPassageAjout.TabIndex = 41;
            // 
            // lblNbPassageAjout
            // 
            lblNbPassageAjout.AutoSize = true;
            lblNbPassageAjout.Font = new Font("Segoe UI", 11F);
            lblNbPassageAjout.Location = new Point(23, 143);
            lblNbPassageAjout.Margin = new Padding(1, 0, 1, 0);
            lblNbPassageAjout.Name = "lblNbPassageAjout";
            lblNbPassageAjout.Size = new Size(149, 20);
            lblNbPassageAjout.TabIndex = 42;
            lblNbPassageAjout.Text = "Nombre de passages";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(358, 614);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(194, 32);
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
            panel1.Controls.Add(nudFreqHeureAjout);
            panel1.Controls.Add(lblHeure1er);
            panel1.Controls.Add(nudFreqAjoutMin);
            panel1.Controls.Add(lblHeureFreq);
            panel1.Controls.Add(lblFrequenceAjout);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 375);
            label2.Name = "label2";
            label2.Size = new Size(657, 15);
            label2.TabIndex = 46;
            label2.Text = "__________________________________________________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 500);
            label3.Name = "label3";
            label3.Size = new Size(657, 15);
            label3.TabIndex = 47;
            label3.Text = "__________________________________________________________________________________________________________________________________";
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
            nudArretHeures.Location = new Point(15, 118);
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
            nudArretMinutes.Location = new Point(129, 118);
            nudArretMinutes.Margin = new Padding(2);
            nudArretMinutes.Name = "nudArretMinutes";
            nudArretMinutes.Size = new Size(77, 23);
            nudArretMinutes.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(97, 112);
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
            label6.Location = new Point(30, 74);
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
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(270, 435);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(46, 19);
            checkBox2.TabIndex = 50;
            checkBox2.Text = "Lun";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(322, 435);
            checkBox3.Margin = new Padding(3, 2, 3, 2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(47, 19);
            checkBox3.TabIndex = 51;
            checkBox3.Text = "Mar";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(378, 435);
            checkBox4.Margin = new Padding(3, 2, 3, 2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(47, 19);
            checkBox4.TabIndex = 52;
            checkBox4.Text = "Mer";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(433, 435);
            checkBox5.Margin = new Padding(3, 2, 3, 2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(43, 19);
            checkBox5.TabIndex = 53;
            checkBox5.Text = "Jeu";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(484, 435);
            checkBox6.Margin = new Padding(3, 2, 3, 2);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(45, 19);
            checkBox6.TabIndex = 54;
            checkBox6.Text = "Ven";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(270, 477);
            checkBox7.Margin = new Padding(3, 2, 3, 2);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(84, 19);
            checkBox7.TabIndex = 55;
            checkBox7.Text = "Jours fériés";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(510, 477);
            checkBox8.Margin = new Padding(3, 2, 3, 2);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(122, 19);
            checkBox8.TabIndex = 56;
            checkBox8.Text = "Vacances scolaires";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(537, 435);
            checkBox9.Margin = new Padding(3, 2, 3, 2);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(49, 19);
            checkBox9.TabIndex = 57;
            checkBox9.Text = "Sam";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(595, 435);
            checkBox10.Margin = new Padding(3, 2, 3, 2);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(48, 19);
            checkBox10.TabIndex = 58;
            checkBox10.Text = "Dim";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(383, 401);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 49;
            label7.Text = "Jours de passage";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(362, 534);
            label8.Name = "label8";
            label8.Size = new Size(171, 60);
            label8.TabIndex = 59;
            label8.Text = "Nombre d'arrêts : // \r\nTemps de trajet (Ligne) : // \r\nTemps de trajet (Journée) : // \r\nBus nécessaires (minimum) : //";
            label8.TextAlign = ContentAlignment.MiddleCenter;
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
            ClientSize = new Size(913, 682);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkBox10);
            Controls.Add(checkBox9);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(btnCouleur);
            Controls.Add(panel2);
            Controls.Add(lstArrets);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnAjouter);
            Controls.Add(lblCouleurAjout);
            Controls.Add(txtNomAjoutLigne);
            Controls.Add(lblNomLigne);
            Controls.Add(lblAjouterLigne);
            Controls.Add(btnRetourAjoutLigne);
            Margin = new Padding(2);
            MaximumSize = new Size(929, 721);
            MinimumSize = new Size(929, 721);
            Name = "AdministrerAjouterLigne";
            Text = "AdministrerAjouterLigne";
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqAjoutMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqHeureAjout).EndInit();
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
        private Label lblFrequenceAjout;
        private NumericUpDown nudFreqAjoutMin;
        private NumericUpDown nudFreqHeureAjout;
        private Label lblHeureFreq;
        private Label lblHeure1er;
        private NumericUpDown nudNbPassageAjout;
        private Label lblNbPassageAjout;
        private Button btnAjouter;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
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
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private Label label7;
        private Label label8;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}