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
            btnCouleur = new Button();
            panel2 = new Panel();
            btnAjouterArret = new Button();
            nudHeuresEcartArret = new NumericUpDown();
            cmbArrets = new ComboBox();
            nudMinEcartArret = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            lstArrets = new ListBox();
            label1 = new Label();
            panel1 = new Panel();
            nudMin1erAjout = new NumericUpDown();
            nudHeure1erAjout = new NumericUpDown();
            lblNbPassageAjout = new Label();
            lblHeurePremierAjout = new Label();
            nudNbPassageAjout = new NumericUpDown();
            lblHeure1er = new Label();
            btnModifierLigne = new Button();
            lblCouleurAjout = new Label();
            lblNomLigne = new Label();
            lblAjouterLigne = new Label();
            colorDialog1 = new ColorDialog();
            cmbNomLigne = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeuresEcartArret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinEcartArret).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNbPassageAjout).BeginInit();
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
            panel2.Controls.Add(btnAjouterArret);
            panel2.Controls.Add(nudHeuresEcartArret);
            panel2.Controls.Add(cmbArrets);
            panel2.Controls.Add(nudMinEcartArret);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(356, 164);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 214);
            panel2.TabIndex = 70;
            // 
            // btnAjouterArret
            // 
            btnAjouterArret.Location = new Point(15, 174);
            btnAjouterArret.Margin = new Padding(3, 2, 3, 2);
            btnAjouterArret.Name = "btnAjouterArret";
            btnAjouterArret.Size = new Size(191, 22);
            btnAjouterArret.TabIndex = 47;
            btnAjouterArret.Text = "Ajouter l'arret";
            btnAjouterArret.UseVisualStyleBackColor = true;
            btnAjouterArret.Click += btnAjouterArret_Click;
            // 
            // nudHeuresEcartArret
            // 
            nudHeuresEcartArret.Location = new Point(20, 129);
            nudHeuresEcartArret.Margin = new Padding(2);
            nudHeuresEcartArret.Name = "nudHeuresEcartArret";
            nudHeuresEcartArret.Size = new Size(80, 23);
            nudHeuresEcartArret.TabIndex = 43;
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
            cmbArrets.SelectedIndexChanged += cmbArrets_SelectedIndexChanged;
            // 
            // nudMinEcartArret
            // 
            nudMinEcartArret.Location = new Point(134, 129);
            nudMinEcartArret.Margin = new Padding(2);
            nudMinEcartArret.Name = "nudMinEcartArret";
            nudMinEcartArret.Size = new Size(77, 23);
            nudMinEcartArret.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(102, 123);
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
            label6.Location = new Point(35, 85);
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
            panel1.Controls.Add(lblHeure1er);
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
            lblNbPassageAjout.Location = new Point(23, 101);
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
            nudNbPassageAjout.Location = new Point(11, 129);
            nudNbPassageAjout.Margin = new Padding(2);
            nudNbPassageAjout.Name = "nudNbPassageAjout";
            nudNbPassageAjout.Size = new Size(190, 23);
            nudNbPassageAjout.TabIndex = 41;
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
            // btnModifierLigne
            // 
            btnModifierLigne.Location = new Point(356, 412);
            btnModifierLigne.Name = "btnModifierLigne";
            btnModifierLigne.Size = new Size(225, 32);
            btnModifierLigne.TabIndex = 64;
            btnModifierLigne.Text = "Modifier la ligne";
            btnModifierLigne.UseVisualStyleBackColor = true;
            btnModifierLigne.Click += btnModifierLigne_Click;
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
            cmbNomLigne.SelectedIndexChanged += cmbNomLigne_SelectedIndexChanged;
            // 
            // AdministrerModifLigne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 482);
            Controls.Add(cmbNomLigne);
            Controls.Add(btnCouleur);
            Controls.Add(panel2);
            Controls.Add(lstArrets);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnModifierLigne);
            Controls.Add(lblCouleurAjout);
            Controls.Add(lblNomLigne);
            Controls.Add(lblAjouterLigne);
            Controls.Add(btnRetourModifLigne);
            Margin = new Padding(2);
            MaximumSize = new Size(929, 521);
            MinimumSize = new Size(929, 521);
            Name = "AdministrerModifLigne";
            Text = "AdministrerModifLigne";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeuresEcartArret).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinEcartArret).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNbPassageAjout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetourModifLigne;
        private Button btnCouleur;
        private Panel panel2;
        private Button btnAjouterArret;
        private NumericUpDown nudHeuresEcartArret;
        private ComboBox cmbArrets;
        private NumericUpDown nudMinEcartArret;
        private Label label5;
        private Label label4;
        private Label label6;
        private ListBox lstArrets;
        private Label label1;
        private Panel panel1;
        private NumericUpDown nudMin1erAjout;
        private NumericUpDown nudHeure1erAjout;
        private Label lblNbPassageAjout;
        private Label lblHeurePremierAjout;
        private NumericUpDown nudNbPassageAjout;
        private Label lblHeure1er;
        private Button btnModifierLigne;
        private Label lblCouleurAjout;
        private Label lblNomLigne;
        private Label lblAjouterLigne;
        private ColorDialog colorDialog1;
        private ComboBox cmbNomLigne;
    }
}