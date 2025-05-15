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
            lbl1 = new Label();
            lbl2 = new Label();
            btnretourconsulter2 = new Button();
            SuspendLayout();
            // 
            // btnconsulterligne
            // 
            btnconsulterligne.Location = new Point(88, 475);
            btnconsulterligne.Name = "btnconsulterligne";
            btnconsulterligne.Size = new Size(194, 29);
            btnconsulterligne.TabIndex = 0;
            btnconsulterligne.Text = "Consulter une ligne";
            btnconsulterligne.UseVisualStyleBackColor = true;
            btnconsulterligne.Click += btnconsulterligne_Click;
            // 
            // btnconsulteriti
            // 
            btnconsulteriti.Location = new Point(536, 475);
            btnconsulteriti.Name = "btnconsulteriti";
            btnconsulteriti.Size = new Size(194, 29);
            btnconsulteriti.TabIndex = 1;
            btnconsulteriti.Text = "Consulter un itinéraire";
            btnconsulteriti.UseVisualStyleBackColor = true;
            btnconsulteriti.Click += btnconsulteriti_Click;
            // 
            // btnretour
            // 
            btnretour.Location = new Point(10, 10);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(44, 47);
            btnretour.TabIndex = 2;
            btnretour.Text = "<-";
            btnretour.UseVisualStyleBackColor = true;
            btnretour.Click += btnretour_Click;
            // 
            // lstconsultation
            // 
            lstconsultation.FormattingEnabled = true;
            lstconsultation.Items.AddRange(new object[] { "Carlos ", "Patrick ", "Bob" });
            lstconsultation.Location = new Point(269, 136);
            lstconsultation.Name = "lstconsultation";
            lstconsultation.Size = new Size(265, 264);
            lstconsultation.TabIndex = 3;
            // 
            // btnrechercheconsultation
            // 
            btnrechercheconsultation.Location = new Point(269, 440);
            btnrechercheconsultation.Name = "btnrechercheconsultation";
            btnrechercheconsultation.Size = new Size(265, 29);
            btnrechercheconsultation.TabIndex = 4;
            btnrechercheconsultation.Text = "Effectuer une recherche";
            btnrechercheconsultation.UseVisualStyleBackColor = true;
            btnrechercheconsultation.Click += btnrechercheconsultation_Click;
            // 
            // btnRetourConsulter
            // 
            btnRetourConsulter.Location = new Point(13, 10);
            btnRetourConsulter.Margin = new Padding(2);
            btnRetourConsulter.Name = "btnRetourConsulter";
            btnRetourConsulter.Size = new Size(41, 46);
            btnRetourConsulter.TabIndex = 5;
            btnRetourConsulter.Text = "<-";
            btnRetourConsulter.UseVisualStyleBackColor = true;
            btnRetourConsulter.Click += btnRetourConsulter_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(195, 427);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 20);
            lbl1.TabIndex = 6;
            lbl1.Text = "Carlos";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(117, 427);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(52, 20);
            lbl2.TabIndex = 7;
            lbl2.Text = "Patrick";
            // 
            // btnretourconsulter2
            // 
            btnretourconsulter2.Location = new Point(13, 10);
            btnretourconsulter2.Margin = new Padding(2);
            btnretourconsulter2.Name = "btnretourconsulter2";
            btnretourconsulter2.Size = new Size(41, 46);
            btnretourconsulter2.TabIndex = 8;
            btnretourconsulter2.Text = "<-";
            btnretourconsulter2.UseVisualStyleBackColor = true;
            btnretourconsulter2.Click += btnretourconsulter2_Click;
            // 
            // Consulter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 555);
            Controls.Add(btnretourconsulter2);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
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
        private Label lbl1;
        private Label lbl2;
        private Button btnretourconsulter2;
    }
}