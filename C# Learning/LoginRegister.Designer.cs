namespace C__Learning
{
    partial class LoginRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegister));
            label1 = new Label();
            label2 = new Label();
            btnsignin = new Button();
            chpassword = new CheckBox();
            label3 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 335);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 400);
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
            btnsignin.Location = new Point(38, 580);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(285, 37);
            btnsignin.TabIndex = 4;
            btnsignin.Text = "SING IN";
            btnsignin.UseVisualStyleBackColor = false;
            btnsignin.Click += btnsignin_Click;
            // 
            // chpassword
            // 
            chpassword.AutoSize = true;
            chpassword.Location = new Point(175, 461);
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
            label3.Font = new Font("Segoe UI Semibold", 20.2F, FontStyle.Bold);
            label3.Location = new Point(68, 225);
            label3.Name = "label3";
            label3.Size = new Size(255, 46);
            label3.TabIndex = 6;
            label3.Text = "Welcome Back!";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(68, 358);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(241, 34);
            txtusername.TabIndex = 8;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(68, 421);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(241, 34);
            txtpassword.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(127, 647);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 10;
            label4.Text = "Create Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 277);
            label5.Name = "label5";
            label5.Size = new Size(220, 20);
            label5.TabIndex = 11;
            label5.Text = "Long in to your existing account";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(98, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 162);
            panel1.TabIndex = 12;
            // 
            // LoginRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 697);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(chpassword);
            Controls.Add(btnsignin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginRegister";
            ResumeLayout(false);
            PerformLayout();
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
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}