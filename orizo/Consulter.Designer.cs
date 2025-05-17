namespace orizo
{
    partial class Consulter
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
            btnconsulterligne = new Button();
            btnconsulteriti = new Button();
            btnretour = new Button();
            lstconsultation = new ListBox();
            btnrechercheconsultation = new Button();
            btnRetourConsulter = new Button();
            btnretourconsulter2 = new Button();
            lblconsulterligne = new Label();
            SuspendLayout();
            // 
            // btnconsulterligne
            // 
            btnconsulterligne.BackColor = Color.Silver;
            btnconsulterligne.Location = new Point(88, 475);
            btnconsulterligne.Name = "btnconsulterligne";
            btnconsulterligne.Size = new Size(194, 29);
            btnconsulterligne.TabIndex = 0;
            btnconsulterligne.Text = "Consulter une ligne";
            btnconsulterligne.UseVisualStyleBackColor = false;
            btnconsulterligne.Click += btnconsulterligne_Click;
            // 
            // btnconsulteriti
            // 
            btnconsulteriti.BackColor = Color.Silver;
            btnconsulteriti.Location = new Point(536, 475);
            btnconsulteriti.Name = "btnconsulteriti";
            btnconsulteriti.Size = new Size(194, 29);
            btnconsulteriti.TabIndex = 1;
            btnconsulteriti.Text = "Consulter un itinéraire";
            btnconsulteriti.UseVisualStyleBackColor = false;
            btnconsulteriti.Click += btnconsulteriti_Click;
            // 
            // btnretour
            // 
            btnretour.BackColor = Color.Silver;
            btnretour.Location = new Point(12, 12);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(41, 46);
            btnretour.TabIndex = 2;
            btnretour.Text = "<-";
            btnretour.UseVisualStyleBackColor = false;
            btnretour.Click += btnretour_Click;
            // 
            // lstconsultation
            // 
            lstconsultation.FormattingEnabled = true;
            lstconsultation.Items.AddRange(new object[] { "Ligne1 ", "Ligne 2", "Ligne 3" });
            lstconsultation.Location = new Point(269, 136);
            lstconsultation.Name = "lstconsultation";
            lstconsultation.Size = new Size(265, 264);
            lstconsultation.TabIndex = 3;
            lstconsultation.SelectedIndexChanged += lstconsultation_SelectedIndexChanged;
            // 
            // btnrechercheconsultation
            // 
            btnrechercheconsultation.BackColor = Color.Silver;
            btnrechercheconsultation.Location = new Point(269, 440);
            btnrechercheconsultation.Name = "btnrechercheconsultation";
            btnrechercheconsultation.Size = new Size(265, 29);
            btnrechercheconsultation.TabIndex = 4;
            btnrechercheconsultation.Text = "Effectuer une recherche";
            btnrechercheconsultation.UseVisualStyleBackColor = false;
            btnrechercheconsultation.Click += btnrechercheconsultation_Click;
            // 
            // btnRetourConsulter
            // 
            btnRetourConsulter.BackColor = Color.Silver;
            btnRetourConsulter.Location = new Point(11, 11);
            btnRetourConsulter.Margin = new Padding(2);
            btnRetourConsulter.Name = "btnRetourConsulter";
            btnRetourConsulter.Size = new Size(41, 46);
            btnRetourConsulter.TabIndex = 5;
            btnRetourConsulter.Text = "<-";
            btnRetourConsulter.UseVisualStyleBackColor = false;
            btnRetourConsulter.Click += btnRetourConsulter_Click;
            // 
            // btnretourconsulter2
            // 
            btnretourconsulter2.BackColor = Color.Silver;
            btnretourconsulter2.Location = new Point(11, 11);
            btnretourconsulter2.Margin = new Padding(2);
            btnretourconsulter2.Name = "btnretourconsulter2";
            btnretourconsulter2.Size = new Size(41, 46);
            btnretourconsulter2.TabIndex = 8;
            btnretourconsulter2.Text = "<-";
            btnretourconsulter2.UseVisualStyleBackColor = false;
            btnretourconsulter2.Click += btnretourconsulter2_Click;
            // 
            // lblconsulterligne
            // 
            lblconsulterligne.AutoSize = true;
            lblconsulterligne.Font = new Font("Segoe UI", 15F);
            lblconsulterligne.Location = new Point(284, 86);
            lblconsulterligne.Name = "lblconsulterligne";
            lblconsulterligne.Size = new Size(229, 35);
            lblconsulterligne.TabIndex = 9;
            lblconsulterligne.Text = "Consulter une ligne";
            // 
            // Consulter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 555);
            Controls.Add(lblconsulterligne);
            Controls.Add(btnretourconsulter2);
            Controls.Add(btnRetourConsulter);
            Controls.Add(btnrechercheconsultation);
            Controls.Add(lstconsultation);
            Controls.Add(btnretour);
            Controls.Add(btnconsulteriti);
            Controls.Add(btnconsulterligne);
            Margin = new Padding(2);
            Name = "Consulter";
            Text = "Réseau de transport - Consultation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconsulterligne;
        private Button btnconsulteriti;
        private Button btnretour;
        private ListBox lstconsultation;
        private Button btnrechercheconsultation;
        private Button btnRetourConsulter;
        private Button btnretourconsulter2;
        private Label lblconsulterligne;
    }
}