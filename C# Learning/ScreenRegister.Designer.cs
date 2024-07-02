namespace C__Learning
{
    partial class ScreenRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenRegister));
            pnlLoad = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            lblalready = new Label();
            label3 = new Label();
            btnsave = new Button();
            lblShowPass = new Label();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            pnlLoad.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoad
            // 
            pnlLoad.Controls.Add(label4);
            pnlLoad.Controls.Add(textBox1);
            pnlLoad.Controls.Add(textBox2);
            pnlLoad.Controls.Add(label6);
            pnlLoad.Controls.Add(label7);
            pnlLoad.Controls.Add(lblShowPass);
            pnlLoad.Controls.Add(label5);
            pnlLoad.Controls.Add(txtpassword);
            pnlLoad.Controls.Add(panel1);
            pnlLoad.Controls.Add(txtusername);
            pnlLoad.Controls.Add(lblalready);
            pnlLoad.Controls.Add(label2);
            pnlLoad.Controls.Add(label3);
            pnlLoad.Controls.Add(label1);
            pnlLoad.Controls.Add(btnsave);
            pnlLoad.Location = new Point(12, 12);
            pnlLoad.Name = "pnlLoad";
            pnlLoad.Size = new Size(387, 803);
            pnlLoad.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 270);
            label5.Name = "label5";
            label5.Size = new Size(172, 20);
            label5.TabIndex = 11;
            label5.Text = "Create your user account";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(79, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 162);
            panel1.TabIndex = 12;
            // 
            // lblalready
            // 
            lblalready.AutoSize = true;
            lblalready.Cursor = Cursors.Hand;
            lblalready.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblalready.ForeColor = SystemColors.Highlight;
            lblalready.Location = new Point(130, 775);
            lblalready.Name = "lblalready";
            lblalready.Size = new Size(142, 20);
            lblalready.TabIndex = 10;
            lblalready.Text = "Already registered?";
            lblalready.Click += lblLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.2F, FontStyle.Bold);
            label3.Location = new Point(34, 224);
            label3.Name = "label3";
            label3.Size = new Size(256, 46);
            label3.TabIndex = 6;
            label3.Text = "Create Account";
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.Highlight;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(56, 705);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(285, 37);
            btnsave.TabIndex = 4;
            btnsave.Text = "SAVE";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsignin_Click;
            // 
            // lblShowPass
            // 
            lblShowPass.AutoSize = true;
            lblShowPass.Cursor = Cursors.Hand;
            lblShowPass.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowPass.ForeColor = SystemColors.ControlDarkDark;
            lblShowPass.Location = new Point(323, 524);
            lblShowPass.Name = "lblShowPass";
            lblShowPass.Size = new Size(37, 25);
            lblShowPass.TabIndex = 27;
            lblShowPass.Text = "👁‍🗨";
            lblShowPass.Visible = false;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Segoe UI", 13.8F);
            txtpassword.ForeColor = Color.Black;
            txtpassword.Location = new Point(26, 445);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(340, 38);
            txtpassword.TabIndex = 26;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Segoe UI", 13.8F);
            txtusername.ForeColor = Color.Black;
            txtusername.Location = new Point(26, 378);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(340, 38);
            txtusername.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 422);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 24;
            label2.Text = "Documment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 355);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 23;
            label1.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(323, 591);
            label4.Name = "label4";
            label4.Size = new Size(37, 25);
            label4.TabIndex = 32;
            label4.Text = "👁‍🗨";
            label4.Visible = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13.8F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(26, 584);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '•';
            textBox1.Size = new Size(340, 38);
            textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 13.8F);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(26, 517);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 38);
            textBox2.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 562);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 29;
            label6.Text = "Comfirm Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 494);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 28;
            label7.Text = "Password";
            // 
            // ScreenRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 853);
            Controls.Add(pnlLoad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreenRegister";
            Text = "ScreenRegister";
            Load += ScreenRegister_Load;
            pnlLoad.ResumeLayout(false);
            pnlLoad.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Panel panel1;
        private Label lblalready;
        private Label label3;
        private Button btnsave;
        public Panel pnlLoad;
        private Label lblShowPass;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
    }
}