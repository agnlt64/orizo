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
            lswTableau = new ListView();
            lblIndication = new Label();
            lblDepart = new Label();
            lblArrivee = new Label();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(10, 9);
            btnRetour.Margin = new Padding(3, 2, 3, 2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(36, 34);
            btnRetour.TabIndex = 3;
            btnRetour.Text = "<-";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnretour_Click;
            // 
            // lblItinéraire
            // 
            lblItinéraire.AutoSize = true;
            lblItinéraire.Font = new Font("Segoe UI", 15F);
            lblItinéraire.Location = new Point(177, 9);
            lblItinéraire.Name = "lblItinéraire";
            lblItinéraire.Size = new Size(89, 28);
            lblItinéraire.TabIndex = 4;
            lblItinéraire.Text = "Itinéraire";
            lblItinéraire.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lswTableau
            // 
            lswTableau.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lswTableau.Location = new Point(581, 72);
            lswTableau.Margin = new Padding(3, 2, 3, 2);
            lswTableau.Name = "lswTableau";
            lswTableau.Size = new Size(353, 444);
            lswTableau.TabIndex = 7;
            lswTableau.UseCompatibleStateImageBehavior = false;
            // 
            // lblIndication
            // 
            lblIndication.AutoSize = true;
            lblIndication.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            lblIndication.Location = new Point(266, 44);
            lblIndication.Name = "lblIndication";
            lblIndication.Size = new Size(0, 21);
            lblIndication.TabIndex = 5;
            lblIndication.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepart.Location = new Point(28, 59);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(118, 20);
            lblDepart.TabIndex = 8;
            lblDepart.Text = "Heure de départ";
            // 
            // lblArrivee
            // 
            lblArrivee.AutoSize = true;
            lblArrivee.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArrivee.Location = new Point(28, 90);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(110, 20);
            lblArrivee.TabIndex = 9;
            lblArrivee.Text = "Heure d'arrivée";
            // 
            // ConsulterIti2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 529);
            Controls.Add(lblArrivee);
            Controls.Add(lblDepart);
            Controls.Add(lswTableau);
            Controls.Add(lblIndication);
            Controls.Add(lblItinéraire);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "ConsulterIti2";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "ConsulterIti2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private Label lblItinéraire;
        private ListView lswTableau;
        private Label lblIndication;
        private Label lblDepart;
        private Label lblArrivee;
    }
}