namespace C__Learning
{
    partial class ScreenToken
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
            pnlToken = new Panel();
            txtToken1 = new TextBox();
            txtToken2 = new TextBox();
            txtToken3 = new TextBox();
            txtToken4 = new TextBox();
            pnlToken.SuspendLayout();
            SuspendLayout();
            // 
            // pnlToken
            // 
            pnlToken.Controls.Add(txtToken4);
            pnlToken.Controls.Add(txtToken3);
            pnlToken.Controls.Add(txtToken1);
            pnlToken.Controls.Add(txtToken2);
            pnlToken.Location = new Point(0, 0);
            pnlToken.Name = "pnlToken";
            pnlToken.Size = new Size(357, 63);
            pnlToken.TabIndex = 24;
            // 
            // txtToken1
            // 
            txtToken1.Font = new Font("Segoe UI", 11F);
            txtToken1.Location = new Point(61, 17);
            txtToken1.MaxLength = 1;
            txtToken1.Name = "txtToken1";
            txtToken1.Size = new Size(42, 32);
            txtToken1.TabIndex = 0;
            // 
            // txtToken2
            // 
            txtToken2.Font = new Font("Segoe UI", 11F);
            txtToken2.Location = new Point(119, 17);
            txtToken2.MaxLength = 1;
            txtToken2.Name = "txtToken2";
            txtToken2.Size = new Size(42, 32);
            txtToken2.TabIndex = 25;
            // 
            // txtToken3
            // 
            txtToken3.Font = new Font("Segoe UI", 11F);
            txtToken3.Location = new Point(182, 17);
            txtToken3.MaxLength = 1;
            txtToken3.Name = "txtToken3";
            txtToken3.Size = new Size(42, 32);
            txtToken3.TabIndex = 26;
            // 
            // txtToken4
            // 
            txtToken4.Font = new Font("Segoe UI", 11F);
            txtToken4.Location = new Point(241, 17);
            txtToken4.MaxLength = 1;
            txtToken4.Name = "txtToken4";
            txtToken4.Size = new Size(42, 32);
            txtToken4.TabIndex = 27;
            // 
            // ScreenToken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 64);
            Controls.Add(pnlToken);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreenToken";
            Text = "ScreenToken";
            pnlToken.ResumeLayout(false);
            pnlToken.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlToken;
        private TextBox txtToken4;
        private TextBox txtToken3;
        private TextBox txtToken1;
        private TextBox txtToken2;
    }
}