namespace orizo
{
    partial class Administrer
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
            picAdmin = new PictureBox();
            btnRetourAdministrer = new Button();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            SuspendLayout();
            // 
            // picAdmin
            // 
            picAdmin.Image = Properties.Resources.Logo_orizo;
            picAdmin.Location = new Point(400, 11);
            picAdmin.Margin = new Padding(2);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(362, 302);
            picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            picAdmin.TabIndex = 1;
            picAdmin.TabStop = false;
            // 
            // btnRetourAdministrer
            // 
            btnRetourAdministrer.Location = new Point(12, 12);
            btnRetourAdministrer.Name = "btnRetourAdministrer";
            btnRetourAdministrer.Size = new Size(66, 61);
            btnRetourAdministrer.TabIndex = 2;
            btnRetourAdministrer.Text = "<-";
            btnRetourAdministrer.UseVisualStyleBackColor = true;
            btnRetourAdministrer.Click += btnRetourAdministrer_Click;
            // 
            // Administrer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 754);
            Controls.Add(btnRetourAdministrer);
            Controls.Add(picAdmin);
            Name = "Administrer";
            Text = "Réseau de transport - Administrer";
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picAdmin;
        private Button btnRetourAdministrer;
    }
}