using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Haeun Jeong
 * Student Number: 301004579
 * Date: July 26
 * Description: This program allows the user to calculate the BMI value and 
 *              gives the user the result based on BMI value.   
 * Revision history: 
 * Jul 23 - Calculate BMI, write code for result based on BMI value.
 * Jul 22 - Create Radio button, event listener, and start form.
 * Jul 17 - Create GUI based on calculateTableLayoutPanel
 */
namespace COMP123_S2019_Assignment4
{
    public partial class BMICalculatorForm : Form
    {
        
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void ImperialradioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightTextBox.Text = "inches";
            WeightTextBox.Text = "pounds";
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightTextBox.Text = "metres";
            WeightTextBox.Text = "kilograms";
        }

    
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void BMIResulttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeightTextBox_Enter(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
        }

        private void WeightTextBox_Enter(object sender, EventArgs e)
        {
            WeightTextBox.Text = "";
        }

        private void CalBMIButton_Click(object sender, EventArgs e)
        {
            BMIResulttextBox.Enabled = true;
            BMIScaleResulttextBox.Enabled = true;
            BMIlabel.Enabled = true;
            BMIScaleLabel.Enabled = true;

            double _height;
            double _weight;
            double _bmi;
            BMIProgressBar.Value = 10;
            BMIProgressBar.ForeColor = Color.Transparent;

            Double.TryParse(HeightTextBox.Text, out _height);
            Double.TryParse(WeightTextBox.Text, out _weight);

            if (ImperialradioButton.Checked)
            {
                _bmi = (_weight * 703) / Math.Pow(_height, 2);
            }
            else
            {
                _bmi = (_weight) / Math.Pow(_height, 2);
            }

            if (_bmi < 18.5)
            {
                BMIResulttextBox.Text = Math.Round(_bmi).ToString();
                BMIScaleResulttextBox.Text = "UnderWeight";
                BMIScaleResulttextBox.BackColor = Color.LightGreen;
                BMIProgressBar.ForeColor = Color.LightGreen;
                for (int i = 10; i < Math.Round(_bmi); i++)
                {
                    this.BMIProgressBar.Increment(1);
                }
            }
            else if (_bmi >= 18.5 && _bmi <= 24.9 )
            {
                BMIResulttextBox.Text = Math.Round(_bmi).ToString();
                BMIScaleResulttextBox.Text = "Nomal";
                BMIScaleResulttextBox.BackColor = Color.Green;
                BMIProgressBar.ForeColor = Color.Green;
                for (int i = 10; i < Math.Round(_bmi); i++)
                {
                    this.BMIProgressBar.Increment(1);
                }
            }
            else if (_bmi >= 25 && _bmi <= 29.9)
            {
                BMIResulttextBox.Text = Math.Round(_bmi).ToString();
                BMIScaleResulttextBox.Text = "Overweight";
                BMIScaleResulttextBox.BackColor = Color.Yellow;
                BMIProgressBar.ForeColor = Color.Yellow;
                for (int i = 10; i < Math.Round(_bmi); i++)
                {
                    this.BMIProgressBar.Increment(1);
                }
            }
            else if (_bmi >= 30)
            {
                BMIResulttextBox.Text = Math.Round(_bmi).ToString();
                BMIScaleResulttextBox.Text = "Obese";
                BMIScaleResulttextBox.BackColor = Color.Red;
                this.BMIProgressBar.ForeColor = Color.Red;
                for (int i = 10; i < Math.Round(_bmi); i++)
                {
                    this.BMIProgressBar.Increment(1);
                }
            }

        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            BMIProgressBar.Style = ProgressBarStyle.Continuous;
            BMIResulttextBox.Enabled = false;
            BMIScaleResulttextBox.Enabled = false;
            BMIlabel.Enabled = false;
            BMIScaleLabel.Enabled = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BMIResulttextBox.Text = " ";
            BMIScaleResulttextBox.Text = " ";
            BMIScaleResulttextBox.BackColor = Color.White;
            HeightTextBox.Text = " ";
            WeightTextBox.Text = " ";
            BMIProgressBar.ForeColor = Color.White;
            this.BMIProgressBar.Value = 10;
          
        }
    }
}
