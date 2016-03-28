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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*
            Event handler: button1_Click(object sender, EventArgs e);

            When button "OK" pushed, it hides form2. 
        */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
