namespace orizo
{
    partial class ConsulterIti
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
            cmbdepart = new ComboBox();
            cmbarrive = new ComboBox();
            btnretour = new Button();
            lblchercher = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbdepart
            // 
            cmbdepart.FormattingEnabled = true;
            cmbdepart.Location = new Point(216, 124);
            cmbdepart.Name = "cmbdepart";
            cmbdepart.Size = new Size(328, 28);
            cmbdepart.TabIndex = 0;
            // 
            // cmbarrive
            // 
            cmbarrive.FormattingEnabled = true;
            cmbarrive.Location = new Point(216, 232);
            cmbarrive.Name = "cmbarrive";
            cmbarrive.Size = new Size(328, 28);
            cmbarrive.TabIndex = 1;
            // 
            // btnretour
            // 
            btnretour.Location = new Point(12, 12);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(41, 46);
            btnretour.TabIndex = 2;
            btnretour.Text = "<-";
            btnretour.UseVisualStyleBackColor = true;
            btnretour.Click += btnretour_Click;
            // 
            // lblchercher
            // 
            lblchercher.AutoSize = true;
            lblchercher.Font = new Font("Segoe UI", 15F);
            lblchercher.Location = new Point(259, 13);
            lblchercher.Name = "lblchercher";
            lblchercher.Size = new Size(253, 35);
            lblchercher.TabIndex = 3;
            lblchercher.Text = "Chercher un itinéraire";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 81);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // ConsulterIti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblchercher);
            Controls.Add(btnretour);
            Controls.Add(cmbarrive);
            Controls.Add(cmbdepart);
            Name = "ConsulterIti";
            Text = "Réseau de transport - Consultation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbdepart;
        private ComboBox cmbarrive;
        private Button btnretour;
        private Label lblchercher;
        private Label label1;
    }
}