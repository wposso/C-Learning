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
            label3 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            pnlContainer = new Panel();
            lblShowPass = new Label();
            btnIconToken = new Button();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnToken = new Button();
            label4 = new Label();
            lblLogin = new Label();
            btnClose = new Button();
            button1 = new Button();
            button2 = new Button();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 363);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 426);
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
            btnsignin.Location = new Point(21, 613);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(340, 54);
            btnsignin.TabIndex = 4;
            btnsignin.Text = "Log in";
            btnsignin.UseVisualStyleBackColor = false;
            btnsignin.Click += btnsignin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 179);
            label3.Name = "label3";
            label3.Size = new Size(308, 38);
            label3.TabIndex = 6;
            label3.Text = "Log in to your Account";
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Segoe UI", 13.8F);
            txtusername.ForeColor = Color.Black;
            txtusername.Location = new Point(21, 386);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(340, 38);
            txtusername.TabIndex = 8;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Segoe UI", 13.8F);
            txtpassword.ForeColor = Color.Black;
            txtpassword.Location = new Point(21, 449);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(340, 38);
            txtpassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 217);
            label5.Name = "label5";
            label5.Size = new Size(278, 20);
            label5.TabIndex = 11;
            label5.Text = "Welcome back, please enter your details.";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(103, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 162);
            panel1.TabIndex = 12;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(lblShowPass);
            pnlContainer.Controls.Add(btnIconToken);
            pnlContainer.Controls.Add(label6);
            pnlContainer.Controls.Add(label9);
            pnlContainer.Controls.Add(label8);
            pnlContainer.Controls.Add(label7);
            pnlContainer.Controls.Add(btnToken);
            pnlContainer.Controls.Add(label4);
            pnlContainer.Controls.Add(label5);
            pnlContainer.Controls.Add(panel1);
            pnlContainer.Controls.Add(lblLogin);
            pnlContainer.Controls.Add(txtpassword);
            pnlContainer.Controls.Add(txtusername);
            pnlContainer.Controls.Add(label3);
            pnlContainer.Controls.Add(btnsignin);
            pnlContainer.Controls.Add(label2);
            pnlContainer.Controls.Add(label1);
            pnlContainer.Location = new Point(26, 43);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(387, 756);
            pnlContainer.TabIndex = 13;
            // 
            // lblShowPass
            // 
            lblShowPass.AutoSize = true;
            lblShowPass.Cursor = Cursors.Hand;
            lblShowPass.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowPass.Location = new Point(317, 454);
            lblShowPass.Name = "lblShowPass";
            lblShowPass.Size = new Size(39, 28);
            lblShowPass.TabIndex = 22;
            lblShowPass.Text = "👁️";
            lblShowPass.Visible = false;
            lblShowPass.Click += lblShowPass_Click;
            // 
            // btnIconToken
            // 
            btnIconToken.BackColor = Color.White;
            btnIconToken.BackgroundImageLayout = ImageLayout.Stretch;
            btnIconToken.FlatAppearance.BorderSize = 0;
            btnIconToken.FlatAppearance.MouseDownBackColor = Color.White;
            btnIconToken.FlatAppearance.MouseOverBackColor = Color.White;
            btnIconToken.FlatStyle = FlatStyle.Flat;
            btnIconToken.Image = (Image)resources.GetObject("btnIconToken.Image");
            btnIconToken.ImageAlign = ContentAlignment.MiddleLeft;
            btnIconToken.Location = new Point(65, 270);
            btnIconToken.Name = "btnIconToken";
            btnIconToken.Size = new Size(42, 31);
            btnIconToken.TabIndex = 20;
            btnIconToken.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 308);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 19;
            label6.Text = "________________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(236, 499);
            label9.Name = "label9";
            label9.Size = new Size(125, 20);
            label9.TabIndex = 18;
            label9.Text = "Forgot Password?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 308);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 17;
            label8.Text = "________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 315);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 16;
            label7.Text = "OR";
            // 
            // btnToken
            // 
            btnToken.BackgroundImageLayout = ImageLayout.Stretch;
            btnToken.Cursor = Cursors.Hand;
            btnToken.FlatAppearance.BorderColor = Color.Black;
            btnToken.FlatAppearance.MouseDownBackColor = Color.White;
            btnToken.FlatAppearance.MouseOverBackColor = Color.White;
            btnToken.FlatStyle = FlatStyle.Flat;
            btnToken.ImageAlign = ContentAlignment.MiddleLeft;
            btnToken.Location = new Point(21, 263);
            btnToken.Name = "btnToken";
            btnToken.Size = new Size(340, 44);
            btnToken.TabIndex = 14;
            btnToken.Text = "Continue with Token";
            btnToken.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(238, 702);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 13;
            label4.Text = "Sign Up";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(80, 702);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(163, 20);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "Don't have an account?";
            lblLogin.Click += lblLogin_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.White;
            btnClose.FlatAppearance.MouseOverBackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(350, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 25);
            btnClose.TabIndex = 14;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(379, 12);
            button1.Name = "button1";
            button1.Size = new Size(23, 25);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(408, 12);
            button2.Name = "button2";
            button2.Size = new Size(23, 25);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            // 
            // ScreenLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(443, 824);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnClose);
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
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label5;
        private Panel panel1;
        public Panel pnlContainer;
        private Label lblLogin;
        private Label label4;
        private Button btnClose;
        private Button btnToken;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnIconToken;
        private Button button1;
        private Button button2;
        private Label lblShowPass;
    }
}