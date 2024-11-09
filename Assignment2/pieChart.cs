using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class pieChart : UserControl
    {
        private List<float> sectionAngles = new List<float>();
        private List<Color> sectionColors = new List<Color>();
        public pieChart()
        {
            InitializeComponent();
            this.Paint += PieChartControl_Paint;
        }

        // Method to set data for the pie chart
        public void SetData(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("The list of numbers cannot be null or empty.");

            double total = numbers.Sum();
            float startAngle = 0f;

            // Clear previous data
            sectionAngles.Clear();
            sectionColors.Clear();

            Random rand = new Random();
            foreach (var number in numbers)
            {
                double percentage = number / total;
                float angle = (float)(percentage * 360);

                sectionAngles.Add(angle);
                sectionColors.Add(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));

                startAngle += angle;
            }

            // Redraw the control with the new data
            this.Invalidate();
        }

        // Paint event handler for drawing the pie chart and legend
        private void PieChartControl_Paint(object sender, PaintEventArgs e)
        {
            if (sectionAngles.Count == 0) return; // No data to draw

            Graphics g = e.Graphics;
            float startAngle = 0f;

            int legendX = this.Width - 100;
            int legendY = 10;

            for (int i = 0; i < sectionAngles.Count; i++)
            {
                using (Brush brush = new SolidBrush(sectionColors[i]))
                {
                    g.FillPie(brush, 10, 10, this.Width - 120, this.Height - 20, startAngle, sectionAngles[i]);
                }
                startAngle += sectionAngles[i];

                // Draw legend
                using (Brush brush = new SolidBrush(sectionColors[i]))
                {
                    g.FillRectangle(brush, legendX, legendY, 15, 15);
                }

                string labelText = $"Slice {i + 1} ({Math.Round(sectionAngles[i] / 360 * 100, 2)}%)";
                using (Brush textBrush = new SolidBrush(Color.Black))
                {
                    g.DrawString(labelText, this.Font, textBrush, legendX +15, legendY);
                }

                legendY += 25;
            }
        }

        private void graph_Click(object sender, EventArgs e)
        {

        }
    }
}
