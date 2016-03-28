using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_the_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
            Event handler: button1_MouseEnter(object sender, EventArgs e);

            When the mouse is within the button,
            it relocates the button within the form.
        */
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // generate a random number
            Random rand = new Random();

            // get the dimensions of the form
            var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;

            // relocate the button to new, upper bounded random coordinates
            this.buttonCatchMe.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));
        }
        


        /*
            Event handler: buttonCatchMe_MouseClick(object sender, MouseEventArgs e);

            When there is a mouse click and cursor within the button,
            display form (Title "Congratulations"),
            containing label ("You win!").
        */
        private void buttonCatchMe_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 secondForm = new Form2();

            secondForm.Show();
        }
    }
}
