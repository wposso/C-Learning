namespace C__Learning
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnco01 = new Button();
            button4 = new Button();
            btnco02 = new Button();
            btnco03 = new Button();
            SuspendLayout();
            // 
            // btnco01
            // 
            btnco01.BackgroundImage = (Image)resources.GetObject("btnco01.BackgroundImage");
            btnco01.BackgroundImageLayout = ImageLayout.Stretch;
            btnco01.FlatAppearance.BorderSize = 0;
            btnco01.FlatStyle = FlatStyle.Flat;
            btnco01.Location = new Point(113, 95);
            btnco01.Name = "btnco01";
            btnco01.Size = new Size(79, 78);
            btnco01.TabIndex = 0;
            btnco01.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(469, 12);
            button4.Name = "button4";
            button4.Size = new Size(44, 45);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnco02
            // 
            btnco02.BackgroundImage = (Image)resources.GetObject("btnco02.BackgroundImage");
            btnco02.BackgroundImageLayout = ImageLayout.Stretch;
            btnco02.FlatAppearance.BorderSize = 0;
            btnco02.FlatStyle = FlatStyle.Flat;
            btnco02.Location = new Point(198, 95);
            btnco02.Name = "btnco02";
            btnco02.Size = new Size(79, 78);
            btnco02.TabIndex = 4;
            btnco02.UseVisualStyleBackColor = true;
            // 
            // btnco03
            // 
            btnco03.BackgroundImage = (Image)resources.GetObject("btnco03.BackgroundImage");
            btnco03.BackgroundImageLayout = ImageLayout.Stretch;
            btnco03.FlatAppearance.BorderSize = 0;
            btnco03.FlatStyle = FlatStyle.Flat;
            btnco03.Location = new Point(283, 95);
            btnco03.Name = "btnco03";
            btnco03.Size = new Size(79, 78);
            btnco03.TabIndex = 5;
            btnco03.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
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
    }
}
