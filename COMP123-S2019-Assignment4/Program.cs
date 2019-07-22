using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4
{
    public static class Program
    {
        public static StartForm startForm;
        public static BMICalculatorForm bmiCalculatorForm; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startForm = new StartForm();
            bmiCalculatorForm = new BMICalculatorForm();

            Application.Run(startForm);
        }
    }
}
