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
            lbl10 = new Label();
            lbl11 = new Label();
            btnretour = new Button();
            SuspendLayout();
            // 
            // lbl10
            // 
            lbl10.AutoSize = true;
            lbl10.Location = new Point(376, 178);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(25, 20);
            lbl10.TabIndex = 0;
            lbl10.Text = "10";
            lbl10.Click += label1_Click;
            // 
            // lbl11
            // 
            lbl11.AutoSize = true;
            lbl11.Location = new Point(388, 215);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(25, 20);
            lbl11.TabIndex = 1;
            lbl11.Text = "11";
            // 
            // btnretour
            // 
            btnretour.Location = new Point(23, 12);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(56, 52);
            btnretour.TabIndex = 2;
            btnretour.Text = "<-";
            btnretour.UseVisualStyleBackColor = true;
            btnretour.Click += btnretour_Click;
            // 
            // ConsulterLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnretour);
            Controls.Add(lbl11);
            Controls.Add(lbl10);
            Name = "ConsulterLigne";
            Text = "ConsulterLigne";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl10;
        private Label lbl11;
        private Button btnretour;
    }
}