namespace DB_Final_Project
{
    partial class director_attendence_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(director_attendence_view));
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button8 = new Button();
            button7 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            button33 = new Button();
            button34 = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            Id = new DataGridViewTextBoxColumn();
            Names = new DataGridViewTextBoxColumn();
            Fathername = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            Present = new DataGridViewCheckBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(152, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1750, 925);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1428, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(317, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Names, Fathername, Class, Present });
            dataGridView1.Location = new Point(3, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1747, 866);
            dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
            label1.TabIndex = 14;
            label1.Text = "Class ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(156, 39);
            label4.Name = "label4";
            label4.Size = new Size(417, 32);
            label4.TabIndex = 23;
            label4.Text = "Allama Iqbal Public High School ";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackgroundImage = Properties.Resources.profile;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(1816, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(81, 63);
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button33);
            panel1.Controls.Add(button34);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1, -3);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 1030);
            panel1.TabIndex = 25;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(-1, 240);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(145, 41);
            button1.TabIndex = 19;
            button1.Text = "Home    ";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.Salary_Logo__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 602);
            button2.Name = "button2";
            button2.Size = new Size(146, 41);
            button2.TabIndex = 18;
            button2.Text = "Finance    ";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.attend;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 565);
            button3.Name = "button3";
            button3.Size = new Size(146, 41);
            button3.TabIndex = 17;
            button3.Text = "Schedule  ";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            // 
            // button8
            // 
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.BackColor = Color.FromArgb(0, 0, 64);
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 522);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(146, 41);
            button8.TabIndex = 15;
            button8.Text = "Result      ";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseMnemonic = false;
            button8.UseVisualStyleBackColor = true;
            button8.UseWaitCursor = true;
            // 
            // button7
            // 
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = Color.FromArgb(0, 0, 64);
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = Properties.Resources.Fee_logo;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-2, 381);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(146, 41);
            button7.TabIndex = 14;
            button7.Text = "Fee Info  ";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseMnemonic = false;
            button7.UseVisualStyleBackColor = true;
            button7.UseWaitCursor = true;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.FromArgb(0, 0, 64);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.Logout__1_;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(-2, 966);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.Yes;
            button4.Size = new Size(146, 41);
            button4.TabIndex = 9;
            button4.Text = "Logout     ";
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = true;
            button4.UseWaitCursor = true;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.FromArgb(0, 0, 64);
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = Properties.Resources.Salary_Logo__1_;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-1, 428);
            button6.Name = "button6";
            button6.Size = new Size(145, 41);
            button6.TabIndex = 13;
            button6.Text = "    Salary";
            button6.UseMnemonic = false;
            button6.UseVisualStyleBackColor = true;
            button6.UseWaitCursor = true;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.FromArgb(0, 0, 64);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-5, 287);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(146, 41);
            button5.TabIndex = 11;
            button5.Text = "Student  ";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseMnemonic = false;
            button5.UseVisualStyleBackColor = true;
            button5.UseWaitCursor = true;
            // 
            // button33
            // 
            button33.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button33.BackColor = Color.FromArgb(0, 0, 64);
            button33.FlatStyle = FlatStyle.Popup;
            button33.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button33.ForeColor = Color.DodgerBlue;
            button33.Image = (Image)resources.GetObject("button33.Image");
            button33.ImageAlign = ContentAlignment.MiddleLeft;
            button33.Location = new Point(1, 475);
            button33.Name = "button33";
            button33.RightToLeft = RightToLeft.No;
            button33.Size = new Size(139, 41);
            button33.TabIndex = 12;
            button33.Text = "  Presence";
            button33.TextAlign = ContentAlignment.MiddleRight;
            button33.UseMnemonic = false;
            button33.UseVisualStyleBackColor = true;
            button33.UseWaitCursor = true;
            // 
            // button34
            // 
            button34.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button34.BackColor = Color.FromArgb(0, 0, 64);
            button34.FlatStyle = FlatStyle.Popup;
            button34.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button34.ForeColor = Color.White;
            button34.Image = (Image)resources.GetObject("button34.Image");
            button34.ImageAlign = ContentAlignment.MiddleLeft;
            button34.Location = new Point(0, 334);
            button34.Name = "button34";
            button34.RightToLeft = RightToLeft.No;
            button34.Size = new Size(141, 41);
            button34.TabIndex = 10;
            button34.Text = "Staff       ";
            button34.TextAlign = ContentAlignment.MiddleRight;
            button34.UseMnemonic = false;
            button34.UseVisualStyleBackColor = true;
            button34.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Elephant", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(12, 158);
            label8.Name = "label8";
            label8.Size = new Size(117, 29);
            label8.TabIndex = 8;
            label8.Text = "Director";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LOGO_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(11, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 122);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 160;
            // 
            // Names
            // 
            Names.Frozen = true;
            Names.HeaderText = "Names";
            Names.MinimumWidth = 8;
            Names.Name = "Names";
            Names.ReadOnly = true;
            Names.Width = 500;
            // 
            // Fathername
            // 
            Fathername.Frozen = true;
            Fathername.HeaderText = "Father's Name";
            Fathername.MinimumWidth = 8;
            Fathername.Name = "Fathername";
            Fathername.ReadOnly = true;
            Fathername.Width = 500;
            // 
            // Class
            // 
            Class.Frozen = true;
            Class.HeaderText = "Class";
            Class.MinimumWidth = 8;
            Class.Name = "Class";
            Class.ReadOnly = true;
            Class.Width = 300;
            // 
            // Present
            // 
            Present.Frozen = true;
            Present.HeaderText = "Present";
            Present.MinimumWidth = 8;
            Present.Name = "Present";
            Present.ReadOnly = true;
            Present.Width = 250;
            // 
            // director_attendence_view
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1924, 1027);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(panel2);
            Name = "director_attendence_view";
            Text = "director_attendence_view";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button8;
        private Button button7;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button33;
        private Button button34;
        private Label label8;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn Fathername;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewCheckBoxColumn Present;
    }
}