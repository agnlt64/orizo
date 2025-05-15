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
            btnRetourConsulter = new Button();
            SuspendLayout();
            // 
            // btnconsulterligne
            // 
            btnconsulterligne.Location = new Point(110, 594);
            btnconsulterligne.Margin = new Padding(4);
            btnconsulterligne.Name = "btnconsulterligne";
            btnconsulterligne.Size = new Size(242, 36);
            btnconsulterligne.TabIndex = 0;
            btnconsulterligne.Text = "Consulter une ligne";
            btnconsulterligne.UseVisualStyleBackColor = true;
            btnconsulterligne.Click += btnconsulterligne_Click;
            // 
            // btnconsulteriti
            // 
            btnconsulteriti.Location = new Point(670, 594);
            btnconsulteriti.Margin = new Padding(4);
            btnconsulteriti.Name = "btnconsulteriti";
            btnconsulteriti.Size = new Size(242, 36);
            btnconsulteriti.TabIndex = 1;
            btnconsulteriti.Text = "Consulter un itinéraire";
            btnconsulteriti.UseVisualStyleBackColor = true;
            btnconsulteriti.Click += btnconsulteriti_Click;
            // 
            // btnretour
            // 
            btnretour.Location = new Point(78, 80);
            btnretour.Margin = new Padding(4);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(118, 36);
            btnretour.TabIndex = 2;
            btnretour.Text = "Retour";
            btnretour.UseVisualStyleBackColor = true;
            btnretour.Click += btnretour_Click;
            // 
            // lstbxconsultation
            // 
            lstbxconsultation.FormattingEnabled = true;
            lstbxconsultation.ItemHeight = 25;
            lstbxconsultation.Items.AddRange(new object[] { "Carlos ", "Patrick ", "Bob" });
            lstbxconsultation.Location = new Point(336, 170);
            lstbxconsultation.Margin = new Padding(4);
            lstbxconsultation.Name = "lstbxconsultation";
            lstbxconsultation.Size = new Size(330, 329);
            lstbxconsultation.TabIndex = 3;
            // 
            // btnrechercheconsultation
            // 
            btnrechercheconsultation.Location = new Point(336, 550);
            btnrechercheconsultation.Margin = new Padding(4);
            btnrechercheconsultation.Name = "btnrechercheconsultation";
            btnrechercheconsultation.Size = new Size(331, 36);
            btnrechercheconsultation.TabIndex = 4;
            btnrechercheconsultation.Text = "Effectuer une recherche";
            btnrechercheconsultation.UseVisualStyleBackColor = true;
            btnrechercheconsultation.Click += btnrechercheconsultation_Click;
            // 
            // btnRetourConsulter
            // 
            btnRetourConsulter.Location = new Point(12, 12);
            btnRetourConsulter.Name = "btnRetourConsulter";
            btnRetourConsulter.Size = new Size(66, 61);
            btnRetourConsulter.TabIndex = 5;
            btnRetourConsulter.Text = "<-";
            btnRetourConsulter.UseVisualStyleBackColor = true;
            btnRetourConsulter.Click += btnRetourConsulter_Click;
            // 
            // Consulter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 694);
            Controls.Add(btnRetourConsulter);
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
        private Button btnRetourConsulter;
    }
}