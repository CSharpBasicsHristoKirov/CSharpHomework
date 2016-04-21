using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_And_Rectangle
{
    public partial class FormPointAndRectangle : Form
    {
        public FormPointAndRectangle()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------------

        /*
            Method: buttonDraw_Click(object sender, EventArgs e);

            It draws a rectangle and a point using the available
            coordinates.
        */
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Draw();
        }
        //--------------------------------------------------------------------

        /*
            Method: numericUpDownX1_ValueChanged(object sender, EventArgs e);

            It handles modification of the upper left
            edge abscissa of the rectangle.
        */
        private void numericUpDownX1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }
        //--------------------------------------------------------------------

        /*
             Method: numericUpDownX1_ValueChanged(object sender, EventArgs e);

             It handles modification of the upper left
             edge ordinate of the rectangle.
        */
        private void numericUpDownY1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }
        //--------------------------------------------------------------------

        /*
            Method: numericUpDownX2_ValueChanged(object sender, EventArgs e);

            It handles modification of the bottom right
            edge abscissa of the rectangle.
        */
        private void numericUpDownX2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }
        //--------------------------------------------------------------------

        /*
            Method: numericUpDownY2_ValueChanged(object sender, EventArgs e);

            It handles modification of the bottom right
            edge ordinate of the rectangle.
        */
        private void numericUpDownY2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }
        //--------------------------------------------------------------------

        /*
            Method: numericUpDownX_ValueChanged(object sender, EventArgs e);

            It handles modification of the  
            abscissa of the point.
        */
        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }
        //--------------------------------------------------------------------

        /*
            Method: numericUpDownY_ValueChanged(object sender, EventArgs e)

            It handles modification of the  
            ordinate of the point.
        */
        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }
        //--------------------------------------------------------------------

        /*
            Method: FormPointAndRectangle_Load(object sender, EventArgs e);

            Default form appearance.
        */
        private void FormPointAndRectangle_Load(object sender, EventArgs e)
        {
            Draw();
        }
        //--------------------------------------------------------------------

        /*
            Method: FormPointAndRectangle_Load(object sender, EventArgs e);

            Default form appearance.
        */
        private void FormPointAndRectangle_Resize(object sender, EventArgs e)
        {
            Draw();
        }
        //====================================================================

        /*
            Method: FormPointAndRectangle_Load(object sender, EventArgs e);

            Action function: called when any of the above functions are called.
        */
        private void Draw()
        {
            // read and store the coordinates
            var x1 = this.numericUpDownX1.Value;
            var y1 = this.numericUpDownY1.Value;

            var x2 = this.numericUpDownX2.Value;
            var y2 = this.numericUpDownY2.Value;

            var x = this.numericUpDownX.Value;
            var y = this.numericUpDownY.Value;

            DisplayPointLocation(x1, y1, x2, y2, x, y);

            // Draw rectangle and point scaled and within the pictureBox

            // Determine Min and Max value of the coordinates
            var minX = Min(x1, x2, x);
            var maxX = Max(x1, x2, x);
            var minY = Min(y1, y2, y);
            var maxY = Max(y1, y2, y);

            // Determine the size of the drawn objects 
            var diagramWidth = maxX - minX;
            var diagramHeight = maxY - minY;

            var ratio = 1.0m;
            var offset = 10;

            // Calculate scale factors accounting for drawn objects offset from pictureBox edges
            if (diagramWidth != 0 && diagramHeight != 0)
            {
                var ratioX = (pictureBox.Width - 2 * offset - 1) / diagramWidth;
                var ratioY = (pictureBox.Height - 2 * offset - 1) / diagramHeight;
                ratio = Math.Min(ratioX, ratioY);
            }

            // Scale drawn object size and location so that they match with the pictureBox size and centered
            var rectLeft = offset + (int)Math.Round((Math.Min(x1, x2) - minX) * ratio);
            var rectTop = offset + (int)Math.Round((Math.Min(y1, y2) - minY) * ratio);
            var rectWidth = (int)Math.Round(Math.Abs(x2 - x1) * ratio);
            var rectHeight = (int)Math.Round(Math.Abs(y2 - y1) * ratio);

            // Define a rectange by top left coordinates, with and height
            var rect = new Rectangle(rectLeft, rectTop, rectWidth, rectHeight);

            // Do the same for the point 
            var pointX = (int)Math.Round(offset + (x - minX) * ratio);
            var pointY = (int)Math.Round(offset + (y - minY) * ratio);

            // Define an inscribed cirle within 5 X 5 rectangle ? (translated to the left and up by the "radius")
            var pointRect = new Rectangle(pointX - 2, pointY - 2, 5, 5);

            // Draw the rectangle and point
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                // Draw diagram background (white area)
                g.Clear(Color.White);

                // Draw the rectangle (scalled to the picture box size)
                var pen = new Pen(Color.Blue, 3);
                g.DrawRectangle(pen, rect);

                // Draw the point (scalled to the picture box size)
                pen = new Pen(Color.DarkBlue, 5);
                g.DrawEllipse(pen, pointRect);
            }
        }
        //--------------------------------------------------------------------

        /*
            Method:  DisplayPointLocation(decimal x1, decimal y1, decimal x2,
                                          decimal y2, decimal x, decimal y);

            It calculates whether the point is in the rectangle and 
            displays it in the "label7".
        */
        private void DisplayPointLocation(decimal x1, decimal y1, decimal x2,
                                          decimal y2, decimal x, decimal y)
        {
            // determine relative edges of the rectangle
            var left = Math.Min(x1, x2);
            var right = Math.Max(x1, x2);
            var top = Math.Min(y1, y2);
            var bottom = Math.Max(y1, y2);

            // discern point location and print it in: label7
            if (x > left && x < right && y > top && y < bottom)
            {
                this.labelLocation.Text = "Inside";
                this.labelLocation.BackColor = Color.LightGreen;
            }
            else if (x < left || x > right || y < top || y > bottom)
            {
                this.labelLocation.Text = "Outside";
                this.labelLocation.BackColor = Color.LightGreen;
            }
            else
            {
                this.labelLocation.Text = "Border";
                this.labelLocation.BackColor = Color.Gold;

            }
        }

        //====================================================================
        // Helper Functions

        /*
            Method: 

        */
        private decimal Min(decimal val1, decimal val2, decimal val3)
        {
            return Math.Min(val1, Math.Min(val2, val3));
        }
        //--------------------------------------------------------------------

        /*
            Method: 

        */
        private decimal Max(decimal val1, decimal val2, decimal val3)
        {
            return Math.Max(val1, Math.Max(val2, val3));
        }

    }
}
