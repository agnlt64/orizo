namespace orizo
{
    partial class ConsulterLigne
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
            ListViewItem listViewItem4 = new ListViewItem("Ligne");
            ListViewItem listViewItem5 = new ListViewItem("Départ");
            ListViewItem listViewItem6 = new ListViewItem("Arrivée");
            btnRetour = new Button();
            lblConsulterLigne = new Label();
            lblIndication = new Label();
            lswTableau = new ListView();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(41, 46);
            btnRetour.TabIndex = 2;
            btnRetour.Text = "<-";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnretour_Click;
            // 
            // lblConsulterLigne
            // 
            lblConsulterLigne.AutoSize = true;
            lblConsulterLigne.Font = new Font("Segoe UI", 15F);
            lblConsulterLigne.Location = new Point(278, 23);
            lblConsulterLigne.Name = "lblConsulterLigne";
            lblConsulterLigne.Size = new Size(229, 35);
            lblConsulterLigne.TabIndex = 10;
            lblConsulterLigne.Text = "Consulter une ligne";
            // 
            // lblIndication
            // 
            lblIndication.AutoSize = true;
            lblIndication.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            lblIndication.Location = new Point(351, 79);
            lblIndication.Name = "lblIndication";
            lblIndication.Size = new Size(81, 28);
            lblIndication.TabIndex = 11;
            lblIndication.Text = "Ligne 1";
            lblIndication.TextAlign = ContentAlignment.TopCenter;
            // 
            // lswTableau
            // 
            lswTableau.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            lswTableau.Location = new Point(158, 117);
            lswTableau.Name = "lswTableau";
            lswTableau.Size = new Size(506, 321);
            lswTableau.TabIndex = 12;
            lswTableau.UseCompatibleStateImageBehavior = false;
            // 
            // ConsulterLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lswTableau);
            Controls.Add(lblIndication);
            Controls.Add(lblConsulterLigne);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "ConsulterLigne";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Réseau de transport - Consultation";
            Load += ConsulterLigne_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRetour;
        private Label lblConsulterLigne;
        private Label lblIndication;
        private ListView lswTableau;
    }
}