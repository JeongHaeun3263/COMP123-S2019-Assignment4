using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void CalBMIButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
