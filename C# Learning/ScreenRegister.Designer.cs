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
            label4 = new Label();
            txtConfirmPass = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            lblalready = new Label();
            txtNewPass = new TextBox();
            txtNewUser = new TextBox();
            label3 = new Label();
            chpassword = new CheckBox();
            btnsave = new Button();
            label2 = new Label();
            label1 = new Label();
            pnlLoad.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoad
            // 
            pnlLoad.Controls.Add(label4);
            pnlLoad.Controls.Add(txtConfirmPass);
            pnlLoad.Controls.Add(label5);
            pnlLoad.Controls.Add(panel1);
            pnlLoad.Controls.Add(lblalready);
            pnlLoad.Controls.Add(txtNewPass);
            pnlLoad.Controls.Add(txtNewUser);
            pnlLoad.Controls.Add(label3);
            pnlLoad.Controls.Add(chpassword);
            pnlLoad.Controls.Add(btnsave);
            pnlLoad.Controls.Add(label2);
            pnlLoad.Controls.Add(label1);
            pnlLoad.Location = new Point(1, 1);
            pnlLoad.Name = "pnlLoad";
            pnlLoad.Size = new Size(326, 683);
            pnlLoad.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 446);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 14;
            label4.Text = "Confirmation password";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPass.Location = new Point(49, 469);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '•';
            txtConfirmPass.Size = new Size(241, 34);
            txtConfirmPass.TabIndex = 13;
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
            lblalready.Location = new Point(91, 649);
            lblalready.Name = "lblalready";
            lblalready.Size = new Size(142, 20);
            lblalready.TabIndex = 10;
            lblalready.Text = "Already registered?";
            lblalready.Click += lblLogin_Click;
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPass.Location = new Point(47, 400);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '•';
            txtNewPass.Size = new Size(241, 34);
            txtNewPass.TabIndex = 9;
            // 
            // txtNewUser
            // 
            txtNewUser.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewUser.Location = new Point(47, 337);
            txtNewUser.Name = "txtNewUser";
            txtNewUser.Size = new Size(241, 34);
            txtNewUser.TabIndex = 8;
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
            // chpassword
            // 
            chpassword.AutoSize = true;
            chpassword.Location = new Point(156, 509);
            chpassword.Name = "chpassword";
            chpassword.Size = new Size(134, 24);
            chpassword.TabIndex = 5;
            chpassword.Text = "Show password";
            chpassword.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.Highlight;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(17, 579);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(285, 37);
            btnsave.TabIndex = 4;
            btnsave.Text = "SAVE";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsignin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 379);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 3;
            label2.Text = "New password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 314);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "New user";
            // 
            // ScreenRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 686);
            Controls.Add(pnlLoad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreenRegister";
            Text = "ScreenRegister";
            pnlLoad.ResumeLayout(false);
            pnlLoad.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Panel panel1;
        private Label lblalready;
        private TextBox txtNewPass;
        private TextBox txtNewUser;
        private Label label3;
        private CheckBox chpassword;
        private Button btnsave;
        private Label label2;
        private Label label1;
        public Panel pnlLoad;
        private Label label4;
        private TextBox txtConfirmPass;
    }
}