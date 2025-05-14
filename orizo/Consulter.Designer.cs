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
            lstbxconsultation = new ListBox();
            btnrechercheconsultation = new Button();
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
            btnretour.Location = new Point(57, 59);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(94, 29);
            btnretour.TabIndex = 2;
            btnretour.Text = "Retour";
            btnretour.UseVisualStyleBackColor = true;
            btnretour.Click += btnretour_Click;
            // 
            // lstbxconsultation
            // 
            lstbxconsultation.FormattingEnabled = true;
            lstbxconsultation.Items.AddRange(new object[] { "Carlos ", "Patrick ", "Bob" });
            lstbxconsultation.Location = new Point(269, 136);
            lstbxconsultation.Name = "lstbxconsultation";
            lstbxconsultation.Size = new Size(265, 264);
            lstbxconsultation.TabIndex = 3;
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
            // Consulter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 555);
            Controls.Add(btnrechercheconsultation);
            Controls.Add(lstbxconsultation);
            Controls.Add(btnretour);
            Controls.Add(btnconsulteriti);
            Controls.Add(btnconsulterligne);
            Margin = new Padding(2);
            Name = "Consulter";
            Text = "Réseau de transport - Consultation";
            ResumeLayout(false);
        }

        #endregion

        private Button btnconsulterligne;
        private Button btnconsulteriti;
        private Button btnretour;
        private ListBox lstbxconsultation;
        private Button btnrechercheconsultation;
    }
}