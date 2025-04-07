using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Final_Project
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminInfo adminInfoPage = new adminInfo();
            adminInfoPage.Show();
        }
    }
}
