namespace orizo
{
    partial class ConsulterIti2
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
            lblItinéraire = new Label();
            lblIndication = new Label();
            lswTableau = new ListView();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(41, 46);
            btnRetour.TabIndex = 3;
            btnRetour.Text = "<-";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnretour_Click;
            // 
            // lblItinéraire
            // 
            lblItinéraire.AutoSize = true;
            lblItinéraire.Font = new Font("Segoe UI", 15F);
            lblItinéraire.Location = new Point(321, 9);
            lblItinéraire.Name = "lblItinéraire";
            lblItinéraire.Size = new Size(113, 35);
            lblItinéraire.TabIndex = 4;
            lblItinéraire.Text = "Itinéraire";
            lblItinéraire.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIndication
            // 
            lblIndication.AutoSize = true;
            lblIndication.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            lblIndication.Location = new Point(291, 64);
            lblIndication.Name = "lblIndication";
            lblIndication.Size = new Size(181, 28);
            lblIndication.TabIndex = 5;
            lblIndication.Text = "Arrêt 1 à Arrêt 10";
            lblIndication.TextAlign = ContentAlignment.TopCenter;
            // 
            // lswTableau
            // 
            lswTableau.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lswTableau.Location = new Point(412, 117);
            lswTableau.Name = "lswTableau";
            lswTableau.Size = new Size(376, 321);
            lswTableau.TabIndex = 7;
            lswTableau.UseCompatibleStateImageBehavior = false;
            lswTableau.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // ConsulterIti2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lswTableau);
            Controls.Add(lblIndication);
            Controls.Add(lblItinéraire);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "ConsulterIti2";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "ConsulterIti2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private Label lblItinéraire;
        private Label lblIndication;
        private ListView lswTableau;
    }
}