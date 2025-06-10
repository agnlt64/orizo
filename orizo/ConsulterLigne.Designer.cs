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
            ListViewItem listViewItem1 = new ListViewItem("Ligne");
            ListViewItem listViewItem2 = new ListViewItem("Départ");
            ListViewItem listViewItem3 = new ListViewItem("Arrivée");
            btnRetour = new Button();
            lblConsulterLigne = new Label();
            lblIndication = new Label();
            lswTableau = new ListView();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(10, 9);
            btnRetour.Margin = new Padding(3, 2, 3, 2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(36, 34);
            btnRetour.TabIndex = 2;
            btnRetour.Text = "<-";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnretour_Click;
            // 
            // lblConsulterLigne
            // 
            lblConsulterLigne.AutoSize = true;
            lblConsulterLigne.Font = new Font("Segoe UI", 15F);
            lblConsulterLigne.Location = new Point(133, 26);
            lblConsulterLigne.Name = "lblConsulterLigne";
            lblConsulterLigne.Size = new Size(180, 28);
            lblConsulterLigne.TabIndex = 10;
            lblConsulterLigne.Text = "Consulter une ligne";
            // 
            // lblIndication
            // 
            lblIndication.AutoSize = true;
            lblIndication.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            lblIndication.Location = new Point(142, 63);
            lblIndication.Name = "lblIndication";
            lblIndication.Size = new Size(65, 21);
            lblIndication.TabIndex = 11;
            lblIndication.Text = "Ligne 1";
            lblIndication.TextAlign = ContentAlignment.TopCenter;
            // 
            // lswTableau
            // 
            lswTableau.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lswTableau.Location = new Point(83, 101);
            lswTableau.Margin = new Padding(3, 2, 3, 2);
            lswTableau.Name = "lswTableau";
            lswTableau.Size = new Size(306, 256);
            lswTableau.TabIndex = 12;
            lswTableau.UseCompatibleStateImageBehavior = false;
            // 
            // ConsulterLigne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 386);
            Controls.Add(lswTableau);
            Controls.Add(lblIndication);
            Controls.Add(lblConsulterLigne);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(500, 425);
            MinimizeBox = false;
            MinimumSize = new Size(500, 425);
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