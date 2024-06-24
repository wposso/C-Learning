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
            label1 = new Label();
            label2 = new Label();
            btnsignin = new Button();
            chpassword = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            txtusername1 = new TextBox();
            txtusername2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 204);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 275);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnsignin
            // 
            btnsignin.Location = new Point(134, 467);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(241, 37);
            btnsignin.TabIndex = 4;
            btnsignin.Text = "Sign in";
            btnsignin.UseVisualStyleBackColor = true;
            btnsignin.Click += btnsignin_Click;
            // 
            // chpassword
            // 
            chpassword.AutoSize = true;
            chpassword.Location = new Point(241, 336);
            chpassword.Name = "chpassword";
            chpassword.Size = new Size(134, 24);
            chpassword.TabIndex = 5;
            chpassword.Text = "Show password";
            chpassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 48);
            label3.Name = "label3";
            label3.Size = new Size(129, 50);
            label3.TabIndex = 6;
            label3.Text = "Sign In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 514);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 7;
            label4.Text = "Can you register here";
            // 
            // txtusername1
            // 
            txtusername1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername1.Location = new Point(134, 227);
            txtusername1.Name = "txtusername1";
            txtusername1.Size = new Size(241, 34);
            txtusername1.TabIndex = 8;
            // 
            // txtusername2
            // 
            txtusername2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername2.Location = new Point(134, 296);
            txtusername2.Name = "txtusername2";
            txtusername2.Size = new Size(241, 34);
            txtusername2.TabIndex = 9;
            // 
            // LoginRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 651);
            Controls.Add(txtusername2);
            Controls.Add(txtusername1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chpassword);
            Controls.Add(btnsignin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginRegister";
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
        private Label label4;
        private TextBox txtusername1;
        private TextBox txtusername2;
    }
}