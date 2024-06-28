namespace C__Learning
{
    partial class ScreenReserve
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnco01 = new Button();
            button4 = new Button();
            btnco02 = new Button();
            btnco03 = new Button();
            btnrelease = new Button();
            SuspendLayout();
            // 
            // btnco01
            // 
            btnco01.BackgroundImageLayout = ImageLayout.Stretch;
            btnco01.FlatStyle = FlatStyle.Flat;
            btnco01.Location = new Point(153, 89);
            btnco01.Name = "btnco01";
            btnco01.Size = new Size(64, 56);
            btnco01.TabIndex = 0;
            btnco01.Text = "CO01";
            btnco01.UseVisualStyleBackColor = true;
            btnco01.Click += btnco01_Click;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.Location = new Point(471, 12);
            button4.Name = "button4";
            button4.Size = new Size(42, 30);
            button4.TabIndex = 3;
            button4.Text = "○";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnco02
            // 
            btnco02.BackgroundImageLayout = ImageLayout.Stretch;
            btnco02.FlatStyle = FlatStyle.Flat;
            btnco02.Location = new Point(223, 89);
            btnco02.Name = "btnco02";
            btnco02.Size = new Size(64, 56);
            btnco02.TabIndex = 4;
            btnco02.Text = "CO02";
            btnco02.UseVisualStyleBackColor = true;
            btnco02.Click += btnco02_Click;
            // 
            // btnco03
            // 
            btnco03.BackgroundImageLayout = ImageLayout.Stretch;
            btnco03.FlatStyle = FlatStyle.Flat;
            btnco03.Location = new Point(293, 89);
            btnco03.Name = "btnco03";
            btnco03.Size = new Size(64, 56);
            btnco03.TabIndex = 5;
            btnco03.Text = "CO03";
            btnco03.UseVisualStyleBackColor = true;
            btnco03.Click += btnco03_Click;
            // 
            // btnrelease
            // 
            btnrelease.Location = new Point(145, 403);
            btnrelease.Name = "btnrelease";
            btnrelease.Size = new Size(212, 35);
            btnrelease.TabIndex = 6;
            btnrelease.Text = "Release";
            btnrelease.UseVisualStyleBackColor = true;
            btnrelease.Click += btnrelease_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(btnrelease);
            Controls.Add(btnco03);
            Controls.Add(btnco02);
            Controls.Add(button4);
            Controls.Add(btnco01);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnco01;
        private Button button4;
        private Button btnco02;
        private Button btnco03;
        private Button btnrelease;
    }
}
