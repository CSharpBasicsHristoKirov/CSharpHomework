using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summator
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        /*
            action function: 

            When button pushed read input from
            textBox1 and textBox2, calculate it
            and display it in textBoxSum.
        */
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // read input from the first two text boxes
                var num1 = decimal.Parse(this.textBox1.Text);
                var num2 = decimal.Parse(this.textBox2.Text);

                // perform calculation
                var sum = num1 + num2;

                // write output to the third text box
                textBoxSum.Text = sum.ToString();
            }
            catch (Exception) // check input validity
            {
                // indicate invalid input
                textBoxSum.Text = "Error";
            }
        }
    }
}
