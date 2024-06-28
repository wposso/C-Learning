namespace C__Learning
{
    partial class ScreenLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenLogin));
            label1 = new Label();
            label2 = new Label();
            btnsignin = new Button();
            chpassword = new CheckBox();
            label3 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            pnlContainer = new Panel();
            lblLogin = new Label();
            label4 = new Label();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 332);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 395);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnsignin
            // 
            btnsignin.BackColor = SystemColors.Highlight;
            btnsignin.FlatAppearance.BorderSize = 0;
            btnsignin.FlatStyle = FlatStyle.Flat;
            btnsignin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsignin.ForeColor = Color.White;
            btnsignin.Location = new Point(41, 561);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(299, 54);
            btnsignin.TabIndex = 4;
            btnsignin.Text = "Log in";
            btnsignin.UseVisualStyleBackColor = false;
            btnsignin.Click += btnsignin_Click;
            // 
            // chpassword
            // 
            chpassword.AutoSize = true;
            chpassword.Location = new Point(206, 458);
            chpassword.Name = "chpassword";
            chpassword.Size = new Size(134, 24);
            chpassword.TabIndex = 5;
            chpassword.Text = "Show password";
            chpassword.UseVisualStyleBackColor = true;
            chpassword.CheckedChanged += chpassword_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(41, 231);
            label3.Name = "label3";
            label3.Size = new Size(308, 38);
            label3.TabIndex = 6;
            label3.Text = "Log in to your Account";
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.ForeColor = Color.Black;
            txtusername.Location = new Point(41, 355);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(299, 34);
            txtusername.TabIndex = 8;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.Black;
            txtpassword.Location = new Point(41, 418);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(299, 34);
            txtpassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 269);
            label5.Name = "label5";
            label5.Size = new Size(306, 20);
            label5.TabIndex = 11;
            label5.Text = "Welcome back, please enter your credentials.";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(103, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 162);
            panel1.TabIndex = 12;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(label4);
            pnlContainer.Controls.Add(label5);
            pnlContainer.Controls.Add(panel1);
            pnlContainer.Controls.Add(lblLogin);
            pnlContainer.Controls.Add(txtpassword);
            pnlContainer.Controls.Add(txtusername);
            pnlContainer.Controls.Add(label3);
            pnlContainer.Controls.Add(chpassword);
            pnlContainer.Controls.Add(btnsignin);
            pnlContainer.Controls.Add(label2);
            pnlContainer.Controls.Add(label1);
            pnlContainer.Location = new Point(26, 43);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(387, 715);
            pnlContainer.TabIndex = 13;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(80, 644);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(163, 20);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "Don't have an account?";
            lblLogin.Click += lblLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(238, 644);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 13;
            label4.Text = "Sign Up";
            // 
            // ScreenLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(443, 784);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ScreenLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Register";
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        //private TextBox txtusername;
        //private TextBox txtpassword;
        private Label label1;
        private Label label2;
        private Button btnsignin;
        private CheckBox chpassword;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label5;
        private Panel panel1;
        public Panel pnlContainer;
        private Label lblLogin;
        private Label label4;
    }
}