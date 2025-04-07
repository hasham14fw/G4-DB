using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DB_Final_Project
{
    public partial class studentMain : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,      // x-coordinate oef upper-left corner
            int nTopRect,       // y-coordinate of upper-left corner
            int nRightRect,     // x-coordinate of lower-right corner
            int nBottomRect,    // y-coordinate of lower-right corner
            int nWidthEllipse,  // height of ellipse
            int nHeightEllipse  // width of ellipse
        );

        public studentMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void loadform(Form form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(form);
            this.panel2.Tag = form;
            form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Curve the edges of panel1
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
<<<<<<< HEAD:studentMain.cs
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));

=======

            // Curve the edges of panel2
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));

            // Curve the edges of panel3
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));

            // Create a circular region for pictureBox2
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Region = new Region(path);
>>>>>>> 627bbc7f9035e9bd603c1215e7a8de92cafdd5d1:Form1.cs
        }

        private void SetButtonRoundedRegion(Button button, int ellipseWidth, int ellipseHeight)
        {
            button.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, ellipseWidth, ellipseHeight));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD:studentMain.cs
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

=======
>>>>>>> 627bbc7f9035e9bd603c1215e7a8de92cafdd5d1:Form1.cs
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

<<<<<<< HEAD:studentMain.cs
        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new viewResult());
=======
        private void button4_Click(object sender, EventArgs e)
        {

>>>>>>> 627bbc7f9035e9bd603c1215e7a8de92cafdd5d1:Form1.cs
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD:studentMain.cs

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new viewAttendence());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Personel_Information());
        }
=======
>>>>>>> 627bbc7f9035e9bd603c1215e7a8de92cafdd5d1:Form1.cs
    }
}