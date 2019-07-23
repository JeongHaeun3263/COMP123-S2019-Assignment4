using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Haeun Jeong
 * Student Number: 301004579
 * Date: July 23
 * Description:
 * Revision history: 
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
            double _height;
            double _weight;
            double _bmi;

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
                BMIResulttextBox.Text = Math.Round(_bmi).ToString()+ "UnderWeight";
            }
            else if (_bmi >= 18.5 && _bmi <= 24.9 )
            {
                BMIResulttextBox.Text = Math.Round(_bmi).ToString() + "Nomal";
            }
            else if (_bmi >= 25 && _bmi <= 29.9)
            {
                BMIResulttextBox.Text = Math.Round(_bmi).ToString() + "Overweight";
            }
            else if (_bmi >= 30)
            {
                BMIResulttextBox.Text = Math.Round(_bmi).ToString() + "Obese";
            }
        }
    }
}
