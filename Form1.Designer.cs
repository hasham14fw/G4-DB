﻿namespace DB_Final_Project
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
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.profile;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(39, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 96);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(168, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(1747, 976);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(19, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 952);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(70, 150);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 7;
            label7.Text = "Director";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(28, 118);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 6;
            label6.Text = "Ch. Zafar Iqbal";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(168, 9);
            label4.Name = "label4";
            label4.Size = new Size(327, 25);
            label4.TabIndex = 7;
            label4.Text = "Allama Iqbal Public High School ";
            label4.Click += label4_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox7.BackgroundImage = Properties.Resources.profile;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(1887, 9);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(27, 26);
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LOGO_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(25, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 90);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Elephant", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(22, 107);
            label8.Name = "label8";
            label8.Size = new Size(117, 29);
            label8.TabIndex = 8;
            label8.Text = "Director";
            label8.Click += label8_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 1018);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.FromArgb(0, 0, 64);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-2, 223);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(141, 25);
            button4.TabIndex = 11;
            button4.Text = " Student ";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = true;
            button4.UseWaitCursor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 192);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(136, 25);
            button3.TabIndex = 10;
            button3.Text = "Staff     ";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.Logout__1_;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(12, 988);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(118, 27);
            button2.TabIndex = 9;
            button2.Text = "Logout";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(3, 161);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(136, 25);
            button1.TabIndex = 0;
            button1.Text = "   Home     ";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1924, 1027);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(pictureBox7);
            Controls.Add(panel1);
            HelpButton = true;
            ImeMode = ImeMode.On;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.Manual;
            Text = "XD";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox1;
        private Label label8;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}
