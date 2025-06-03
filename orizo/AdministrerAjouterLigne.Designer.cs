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
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqAjoutMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqHeureAjout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNbPassageAjout).BeginInit();
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
            txtNomAjoutLigne.Location = new Point(102, 98);
            txtNomAjoutLigne.Margin = new Padding(2);
            txtNomAjoutLigne.Name = "txtNomAjoutLigne";
            txtNomAjoutLigne.Size = new Size(192, 23);
            txtNomAjoutLigne.TabIndex = 25;
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Font = new Font("Segoe UI", 15F);
            lblNomLigne.Location = new Point(122, 67);
            lblNomLigne.Margin = new Padding(1, 0, 1, 0);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(147, 28);
            lblNomLigne.TabIndex = 24;
            lblNomLigne.Text = "nom de la ligne";
            // 
            // lblCouleurAjout
            // 
            lblCouleurAjout.AutoSize = true;
            lblCouleurAjout.Font = new Font("Segoe UI", 15F);
            lblCouleurAjout.Location = new Point(633, 67);
            lblCouleurAjout.Margin = new Padding(1, 0, 1, 0);
            lblCouleurAjout.Name = "lblCouleurAjout";
            lblCouleurAjout.Size = new Size(77, 28);
            lblCouleurAjout.TabIndex = 26;
            lblCouleurAjout.Text = "couleur";
            // 
            // nudHeure1erAjout
            // 
            nudHeure1erAjout.Location = new Point(102, 169);
            nudHeure1erAjout.Margin = new Padding(2);
            nudHeure1erAjout.Name = "nudHeure1erAjout";
            nudHeure1erAjout.Size = new Size(61, 23);
            nudHeure1erAjout.TabIndex = 27;
            // 
            // nudMin1erAjout
            // 
            nudMin1erAjout.Location = new Point(232, 169);
            nudMin1erAjout.Margin = new Padding(2);
            nudMin1erAjout.Name = "nudMin1erAjout";
            nudMin1erAjout.Size = new Size(61, 23);
            nudMin1erAjout.TabIndex = 34;
            // 
            // lblHeurePremierAjout
            // 
            lblHeurePremierAjout.AutoSize = true;
            lblHeurePremierAjout.Font = new Font("Segoe UI", 15F);
            lblHeurePremierAjout.Location = new Point(92, 134);
            lblHeurePremierAjout.Margin = new Padding(1, 0, 1, 0);
            lblHeurePremierAjout.Name = "lblHeurePremierAjout";
            lblHeurePremierAjout.Size = new Size(200, 28);
            lblHeurePremierAjout.TabIndex = 35;
            lblHeurePremierAjout.Text = "Heure du 1er passage";
            // 
            // lblFrequenceAjout
            // 
            lblFrequenceAjout.AutoSize = true;
            lblFrequenceAjout.Font = new Font("Segoe UI", 15F);
            lblFrequenceAjout.Location = new Point(92, 222);
            lblFrequenceAjout.Margin = new Padding(1, 0, 1, 0);
            lblFrequenceAjout.Name = "lblFrequenceAjout";
            lblFrequenceAjout.Size = new Size(204, 28);
            lblFrequenceAjout.TabIndex = 38;
            lblFrequenceAjout.Text = "Fréquence de passage";
            // 
            // nudFreqAjoutMin
            // 
            nudFreqAjoutMin.Location = new Point(232, 257);
            nudFreqAjoutMin.Margin = new Padding(2);
            nudFreqAjoutMin.Name = "nudFreqAjoutMin";
            nudFreqAjoutMin.Size = new Size(61, 23);
            nudFreqAjoutMin.TabIndex = 37;
            // 
            // nudFreqHeureAjout
            // 
            nudFreqHeureAjout.Location = new Point(102, 257);
            nudFreqHeureAjout.Margin = new Padding(2);
            nudFreqHeureAjout.Name = "nudFreqHeureAjout";
            nudFreqHeureAjout.Size = new Size(61, 23);
            nudFreqHeureAjout.TabIndex = 36;
            // 
            // lblHeureFreq
            // 
            lblHeureFreq.AutoSize = true;
            lblHeureFreq.Font = new Font("Segoe UI", 15F);
            lblHeureFreq.Location = new Point(185, 251);
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
            lblHeure1er.Location = new Point(185, 163);
            lblHeure1er.Margin = new Padding(1, 0, 1, 0);
            lblHeure1er.Name = "lblHeure1er";
            lblHeure1er.Size = new Size(26, 28);
            lblHeure1er.TabIndex = 40;
            lblHeure1er.Text = "H";
            // 
            // nudNbPassageAjout
            // 
            nudNbPassageAjout.Location = new Point(102, 328);
            nudNbPassageAjout.Margin = new Padding(2);
            nudNbPassageAjout.Name = "nudNbPassageAjout";
            nudNbPassageAjout.Size = new Size(190, 23);
            nudNbPassageAjout.TabIndex = 41;
            // 
            // lblNbPassageAjout
            // 
            lblNbPassageAjout.AutoSize = true;
            lblNbPassageAjout.Font = new Font("Segoe UI", 15F);
            lblNbPassageAjout.Location = new Point(102, 289);
            lblNbPassageAjout.Margin = new Padding(1, 0, 1, 0);
            lblNbPassageAjout.Name = "lblNbPassageAjout";
            lblNbPassageAjout.Size = new Size(187, 28);
            lblNbPassageAjout.TabIndex = 42;
            lblNbPassageAjout.Text = "Nombre de passage";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(102, 383);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(194, 32);
            btnAjouter.TabIndex = 43;
            btnAjouter.Text = "Ajouter la ligne";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // AdministrerAjouterLigne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 521);
            Controls.Add(btnAjouter);
            Controls.Add(lblNbPassageAjout);
            Controls.Add(nudNbPassageAjout);
            Controls.Add(lblHeure1er);
            Controls.Add(lblHeureFreq);
            Controls.Add(lblFrequenceAjout);
            Controls.Add(nudFreqAjoutMin);
            Controls.Add(nudFreqHeureAjout);
            Controls.Add(lblHeurePremierAjout);
            Controls.Add(nudMin1erAjout);
            Controls.Add(nudHeure1erAjout);
            Controls.Add(lblCouleurAjout);
            Controls.Add(txtNomAjoutLigne);
            Controls.Add(lblNomLigne);
            Controls.Add(lblAjouterLigne);
            Controls.Add(btnRetourAjoutLigne);
            Margin = new Padding(2);
            Name = "AdministrerAjouterLigne";
            Text = "AdministrerAjouterLigne";
            ((System.ComponentModel.ISupportInitialize)nudHeure1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMin1erAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqAjoutMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFreqHeureAjout).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNbPassageAjout).EndInit();
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
    }
}