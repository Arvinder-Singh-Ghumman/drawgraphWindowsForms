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
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
        }

        private void drawButton_Click(object sender, EventArgs e)
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

                // Pass data to the PieChartControl
                pieChart1.SetData(numbers);
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
    }

    }


