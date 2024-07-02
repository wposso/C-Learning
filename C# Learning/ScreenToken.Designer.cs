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
            txtToken3 = new TextBox();
            txtToken4 = new TextBox();
            txtToken2 = new TextBox();
            txtToken1 = new TextBox();
            pnlToken.SuspendLayout();
            SuspendLayout();
            // 
            // pnlToken
            // 
            pnlToken.BackColor = Color.White;
            pnlToken.Controls.Add(txtToken3);
            pnlToken.Controls.Add(txtToken4);
            pnlToken.Controls.Add(txtToken2);
            pnlToken.Controls.Add(txtToken1);
            pnlToken.Location = new Point(0, 0);
            pnlToken.Name = "pnlToken";
            pnlToken.Size = new Size(357, 63);
            pnlToken.TabIndex = 24;
            // 
            // txtToken3
            // 
            txtToken3.BorderStyle = BorderStyle.FixedSingle;
            txtToken3.Font = new Font("Segoe UI Semilight", 16.2F);
            txtToken3.Location = new Point(192, 9);
            txtToken3.MaxLength = 1;
            txtToken3.Name = "txtToken3";
            txtToken3.Size = new Size(65, 43);
            txtToken3.TabIndex = 28;
            txtToken3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtToken4
            // 
            txtToken4.BorderStyle = BorderStyle.FixedSingle;
            txtToken4.Font = new Font("Segoe UI Semilight", 16.2F);
            txtToken4.Location = new Point(284, 9);
            txtToken4.MaxLength = 1;
            txtToken4.Name = "txtToken4";
            txtToken4.Size = new Size(65, 43);
            txtToken4.TabIndex = 26;
            txtToken4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtToken2
            // 
            txtToken2.BorderStyle = BorderStyle.FixedSingle;
            txtToken2.Font = new Font("Segoe UI Semilight", 16.2F);
            txtToken2.Location = new Point(102, 9);
            txtToken2.MaxLength = 1;
            txtToken2.Name = "txtToken2";
            txtToken2.Size = new Size(65, 43);
            txtToken2.TabIndex = 27;
            txtToken2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtToken1
            // 
            txtToken1.BorderStyle = BorderStyle.FixedSingle;
            txtToken1.Font = new Font("Segoe UI Semilight", 16.2F);
            txtToken1.Location = new Point(9, 9);
            txtToken1.MaxLength = 1;
            txtToken1.Name = "txtToken1";
            txtToken1.Size = new Size(65, 43);
            txtToken1.TabIndex = 25;
            txtToken1.TextAlign = HorizontalAlignment.Center;
            // 
            // ScreenToken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 64);
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
        private TextBox txtToken1;
        private TextBox txtToken4;
        private TextBox txtToken2;
        private TextBox txtToken3;
    }
}