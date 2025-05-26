namespace orizo
{
    partial class AdministrerModifLigne
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
            btnRetourModifLigne = new Button();
            SuspendLayout();
            // 
            // btnRetourModifLigne
            // 
            btnRetourModifLigne.Location = new Point(11, 11);
            btnRetourModifLigne.Margin = new Padding(2);
            btnRetourModifLigne.Name = "btnRetourModifLigne";
            btnRetourModifLigne.Size = new Size(60, 58);
            btnRetourModifLigne.TabIndex = 19;
            btnRetourModifLigne.Text = "<-";
            btnRetourModifLigne.UseVisualStyleBackColor = true;
            btnRetourModifLigne.Click += btnRetourModifLigne_Click;
            // 
            // AdministrerModifLigne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 870);
            Controls.Add(btnRetourModifLigne);
            Name = "AdministrerModifLigne";
            Text = "AdministrerModifLigne";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetourModifLigne;
    }
}