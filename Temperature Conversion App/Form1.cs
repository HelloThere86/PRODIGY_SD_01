using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Conversion_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double value;
            double c;
            double f;
            double k;
            if (double.TryParse(textBox1.Text, out value))
            {
                if (kelvinBtn.Checked == true)
                {
                    c = value - 273.15;
                    f = (value - 273.15) * 9 / 5 + 32;
                    MessageBox.Show($"Temperature in Celsius is {c:F1}\u00B0C \n\n Temperature in Fahrenheit is {f:F1}\u00B0F");
                }
                else if (fahrenheitBtn.Checked == true)
                {
                    c = (value - 32) * 5 / 9;
                    k = (value - 32) * 5 / 9 + 273;
                    MessageBox.Show($"Temperature in Celsius is {c:F1}\u00B0C \n\n Temperature in Kelvins is {k:F1}K");
                }
                else if (CelciusBtn.Checked == true)
                {
                    f = (value * 9 / 5) + 32;
                    k = value + 273;
                    MessageBox.Show($"Temperature in Fahrenheit is {f:F1}\u00B0F \n\n Temperature in Kelvins is {k:F1}K");
                }
                else
                {
                    MessageBox.Show("Please select a radio button");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

    }
}
