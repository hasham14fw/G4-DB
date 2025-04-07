using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DB_Final_Project
{
    public partial class viewAttendence : Form
    {
        public viewAttendence()
        {
            InitializeComponent();

            // Add a title to the chart
            chart1.Titles.Add("View Attendance");

            // Create and configure the series
            Series series = new Series("Attendence");  // Ensure the correct spelling
            series.ChartType = SeriesChartType.Pie;  // Set chart type to Pie

            // Add data points
            series.Points.AddXY("Present", 90);
            series.Points.AddXY("Absent", 10);

            // Add the series to the chart
            chart1.Series.Add(series);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void viewAttendence_Load(object sender, EventArgs e)
        {

        }
    }
}
