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
    public partial class Form1 : Form
    {
        private List<float> section = new List<float>();
        private List<Color> secColor = new List<Color>();

        public Form1()
        {
            InitializeComponent();
            graph.Paint += graphPaint;
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
        }

        private void DrawGraph()
        {
            try
            {
                string input = inputData.Text;

                var numbers = input.Split(',')
                                   .Select(num => num.Trim())
                                   .Where(num => !string.IsNullOrEmpty(num))
                                   .Select(num => Convert.ToDouble(num))
                                   .ToList();

                if (numbers.Count == 0)
                {
                    MessageBox.Show("Please enter valid numbers separated by commas.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //reset
                double total = numbers.Sum();
                float startAngle = 0f;
                section.Clear();
                secColor.Clear();

                //getting and sotring angle and color for each
                Random rand = new Random();
                foreach (var number in numbers)
                {
                    double percentage = number / total;
                    float angle = (float)(percentage * 360);

                    section.Add(angle);
                    secColor.Add(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));

                    startAngle += angle;
                }

                // repaint
                graph.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numbers separated by commas.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void graphPaint(object sender, PaintEventArgs e)
        {
            //no data
            if (section.Count == 0) return; 

            Graphics g = e.Graphics;
            float startAngle = 0f;

            //legend pos
            int legendX = graph.Width - 100; 
            int legendY = 10; 

            for (int i = 0; i < section.Count; i++)
            {
                // Draw section
                using (Brush brush = new SolidBrush(secColor[i]))
                {
                    g.FillPie(brush, 10, 10, graph.Width - 120, graph.Height - 20, startAngle, section[i]);
                }
                startAngle += section[i];

                // Draw the legend
                using (Brush brush = new SolidBrush(secColor[i]))
                {
                    g.FillRectangle(brush, legendX, legendY, 15, 15);
                }
                string labelText = $"Slice {i + 1} ({Math.Round(section[i] / 360 * 100, 2)}%)";
                using (Brush textBrush = new SolidBrush(Color.Black))
                {
                    g.DrawString(labelText, this.Font, textBrush, legendX + 20, legendY);
                }
                legendY += 25;
            }
        }


        private void drawButton_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }
    }

    }


