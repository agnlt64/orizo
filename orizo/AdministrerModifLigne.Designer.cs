namespace orizo
{
    partial class AdministrerModifLigne
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
            btnRetourModifLigne = new Button();
            label8 = new Label();
            label7 = new Label();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            btnCouleur = new Button();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            lstArrets = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            nudMin1erAjout = new NumericUpDown();
            nudHeure1erAjout = new NumericUpDown();
            lblNbPassageAjout = new Label();
            lblHeurePremierAjout = new Label();
            nudNbPassageAjout = new NumericUpDown();
            nudFreqHeureAjout = new NumericUpDown();
            lblHeure1er = new Label();
            nudFreqAjoutMin = new NumericUpDown();
            lblHeureFreq = new Label();
            lblFrequenceAjout = new Label();
            btnAjouter = new Button();
            lblCouleurAjout = new Label();
            lblNomLigne = new Label();
            lblAjouterLigne = new Label();
            colorDialog1 = new ColorDialog();
            cmbNomLigne = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNbPassageAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqHeureAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqAjoutMin).BeginInit();
            SuspendLayout();
            // 
            // btnRetourModifLigne
            // 
            btnRetourModifLigne.Location = new Point(8, 7);
            btnRetourModifLigne.Margin = new Padding(2);
            btnRetourModifLigne.Name = "btnRetourModifLigne";
            btnRetourModifLigne.Size = new Size(42, 34);
            btnRetourModifLigne.TabIndex = 19;
            btnRetourModifLigne.Text = "<-";
            btnRetourModifLigne.UseVisualStyleBackColor = true;
            btnRetourModifLigne.Click += btnRetourModifLigne_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(360, 546);
            label8.Name = "label8";
            label8.Size = new Size(171, 60);
            label8.TabIndex = 82;
            label8.Text = "Nombre d'arrêts : // \r\nTemps de trajet (Ligne) : // \r\nTemps de trajet (Journée) : // \r\nBus nécessaires (minimum) : //";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(382, 413);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 72;
            label7.Text = "Jours de passage";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(593, 447);
            checkBox10.Margin = new Padding(3, 2, 3, 2);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(48, 19);
            checkBox10.TabIndex = 81;
            checkBox10.Text = "Dim";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(536, 447);
            checkBox9.Margin = new Padding(3, 2, 3, 2);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(49, 19);
            checkBox9.TabIndex = 80;
            checkBox9.Text = "Sam";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(508, 489);
            checkBox8.Margin = new Padding(3, 2, 3, 2);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(122, 19);
            checkBox8.TabIndex = 79;
            checkBox8.Text = "Vacances scolaires";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(268, 489);
            checkBox7.Margin = new Padding(3, 2, 3, 2);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(84, 19);
            checkBox7.TabIndex = 78;
            checkBox7.Text = "Jours fériés";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(482, 447);
            checkBox6.Margin = new Padding(3, 2, 3, 2);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(45, 19);
            checkBox6.TabIndex = 77;
            checkBox6.Text = "Ven";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(431, 447);
            checkBox5.Margin = new Padding(3, 2, 3, 2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(43, 19);
            checkBox5.TabIndex = 76;
            checkBox5.Text = "Jeu";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(376, 447);
            checkBox4.Margin = new Padding(3, 2, 3, 2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(47, 19);
            checkBox4.TabIndex = 75;
            checkBox4.Text = "Mer";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(320, 447);
            checkBox3.Margin = new Padding(3, 2, 3, 2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(47, 19);
            checkBox3.TabIndex = 74;
            checkBox3.Text = "Mar";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(268, 447);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(46, 19);
            checkBox2.TabIndex = 73;
            checkBox2.Text = "Lun";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnCouleur
            // 
            btnCouleur.BackColor = Color.White;
            btnCouleur.Location = new Point(558, 103);
            btnCouleur.Margin = new Padding(3, 2, 3, 2);
            btnCouleur.Name = "btnCouleur";
            btnCouleur.Size = new Size(25, 22);
            btnCouleur.TabIndex = 71;
            btnCouleur.UseVisualStyleBackColor = false;
            btnCouleur.Click += btnCouleur_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(356, 164);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 214);
            panel2.TabIndex = 70;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(43, 146);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 19);
            checkBox1.TabIndex = 48;
            checkBox1.Text = "Calcul automatique";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(15, 174);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(191, 22);
            button1.TabIndex = 47;
            button1.Text = "Ajouter l'arret";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(15, 118);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(80, 23);
            numericUpDown1.TabIndex = 43;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 42);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 44;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(129, 118);
            numericUpDown2.Margin = new Padding(2);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(77, 23);
            numericUpDown2.TabIndex = 44;
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
            // lstArrets
            // 
            lstArrets.FormattingEnabled = true;
            lstArrets.ItemHeight = 15;
            lstArrets.Location = new Point(598, 164);
            lstArrets.Margin = new Padding(3, 2, 3, 2);
            lstArrets.Name = "lstArrets";
            lstArrets.Size = new Size(202, 214);
            lstArrets.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 512);
            label3.Name = "label3";
            label3.Size = new Size(657, 15);
            label3.TabIndex = 68;
            label3.Text = "__________________________________________________________________________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 387);
            label2.Name = "label2";
            label2.Size = new Size(657, 15);
            label2.TabIndex = 67;
            label2.Text = "__________________________________________________________________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 134);
            label1.Name = "label1";
            label1.Size = new Size(657, 15);
            label1.TabIndex = 66;
            label1.Text = "__________________________________________________________________________________________________________________________________";
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
            panel1.Location = new Point(108, 166);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 210);
            panel1.TabIndex = 65;
            // 
            // nudMin1erAjout
            // 
            nudMin1erAjout.Location = new Point(124, 39);
            nudMin1erAjout.Margin = new Padding(2);
            nudMin1erAjout.Name = "nudMin1erAjout";
            nudMin1erAjout.Size = new Size(77, 23);
            nudMin1erAjout.TabIndex = 34;
            // 
            // nudHeure1erAjout
            // 
            nudHeure1erAjout.Location = new Point(10, 39);
            nudHeure1erAjout.Margin = new Padding(2);
            nudHeure1erAjout.Name = "nudHeure1erAjout";
            nudHeure1erAjout.Size = new Size(80, 23);
            nudHeure1erAjout.TabIndex = 27;
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
            // nudNbPassageAjout
            // 
            nudNbPassageAjout.Location = new Point(11, 171);
            nudNbPassageAjout.Margin = new Padding(2);
            nudNbPassageAjout.Name = "nudNbPassageAjout";
            nudNbPassageAjout.Size = new Size(190, 23);
            nudNbPassageAjout.TabIndex = 41;
            // 
            // nudFreqHeureAjout
            // 
            nudFreqHeureAjout.Location = new Point(10, 106);
            nudFreqHeureAjout.Margin = new Padding(2);
            nudFreqHeureAjout.Name = "nudFreqHeureAjout";
            nudFreqHeureAjout.Size = new Size(80, 23);
            nudFreqHeureAjout.TabIndex = 36;
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
            // nudFreqAjoutMin
            // 
            nudFreqAjoutMin.Location = new Point(124, 106);
            nudFreqAjoutMin.Margin = new Padding(2);
            nudFreqAjoutMin.Name = "nudFreqAjoutMin";
            nudFreqAjoutMin.Size = new Size(77, 23);
            nudFreqAjoutMin.TabIndex = 37;
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
            // btnAjouter
            // 
            btnAjouter.Location = new Point(356, 626);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(194, 32);
            btnAjouter.TabIndex = 64;
            btnAjouter.Text = "Modifier la ligne";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // lblCouleurAjout
            // 
            lblCouleurAjout.AutoSize = true;
            lblCouleurAjout.Font = new Font("Segoe UI", 11F);
            lblCouleurAjout.Location = new Point(537, 82);
            lblCouleurAjout.Margin = new Padding(1, 0, 1, 0);
            lblCouleurAjout.Name = "lblCouleurAjout";
            lblCouleurAjout.Size = new Size(60, 20);
            lblCouleurAjout.TabIndex = 63;
            lblCouleurAjout.Text = "Couleur";
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Font = new Font("Segoe UI", 11F);
            lblNomLigne.Location = new Point(254, 82);
            lblNomLigne.Margin = new Padding(1, 0, 1, 0);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(116, 20);
            lblNomLigne.TabIndex = 61;
            lblNomLigne.Text = "Nom de la ligne";
            // 
            // lblAjouterLigne
            // 
            lblAjouterLigne.AutoSize = true;
            lblAjouterLigne.Font = new Font("Segoe UI", 15F);
            lblAjouterLigne.Location = new Point(360, 29);
            lblAjouterLigne.Margin = new Padding(1, 0, 1, 0);
            lblAjouterLigne.Name = "lblAjouterLigne";
            lblAjouterLigne.Size = new Size(172, 28);
            lblAjouterLigne.TabIndex = 60;
            lblAjouterLigne.Text = "Modifier une ligne";
            // 
            // cmbNomLigne
            // 
            cmbNomLigne.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNomLigne.FormattingEnabled = true;
            cmbNomLigne.Location = new Point(233, 105);
            cmbNomLigne.Name = "cmbNomLigne";
            cmbNomLigne.Size = new Size(168, 23);
            cmbNomLigne.TabIndex = 83;
            // 
            // AdministrerModifLigne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 682);
            Controls.Add(cmbNomLigne);
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
            Controls.Add(lblNomLigne);
            Controls.Add(lblAjouterLigne);
            Controls.Add(btnRetourModifLigne);
            Margin = new Padding(2);
            MaximumSize = new Size(929, 721);
            MinimumSize = new Size(929, 721);
            Name = "AdministrerModifLigne";
            Text = "AdministrerModifLigne";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNbPassageAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqHeureAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqAjoutMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetourModifLigne;
        private Label label8;
        private Label label7;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Button btnCouleur;
        private Panel panel2;
        private CheckBox checkBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Label label4;
        private Label label6;
        private ListBox lstArrets;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private NumericUpDown nudMin1erAjout;
        private NumericUpDown nudHeure1erAjout;
        private Label lblNbPassageAjout;
        private Label lblHeurePremierAjout;
        private NumericUpDown nudNbPassageAjout;
        private NumericUpDown nudFreqHeureAjout;
        private Label lblHeure1er;
        private NumericUpDown nudFreqAjoutMin;
        private Label lblHeureFreq;
        private Label lblFrequenceAjout;
        private Button btnAjouter;
        private Label lblCouleurAjout;
        private Label lblNomLigne;
        private Label lblAjouterLigne;
        private ColorDialog colorDialog1;
        private ComboBox cmbNomLigne;
    }
}