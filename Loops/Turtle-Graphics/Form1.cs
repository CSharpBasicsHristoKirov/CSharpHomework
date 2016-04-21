using System;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace Turtle_Graphics
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        /*
            Method: buttonDraw_Click(object sender, EventArgs e)

            It draws the coded picture.
        */
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // Rotation is positive in the counterclockwise direction

            // 1. Draw a single equilateral triangle
            // Turtle.Rotate(30);
            // Turtle.Forward(200);
            // Turtle.Rotate(120);
            // Turtle.Forward(200);
            // Turtle.Rotate(120);
            // Turtle.Forward(200);

            // 2. Draw composite shapes
            int defaultDelay = Turtle.Delay;

            // Assign a delay to visualize the drawing process
            Turtle.Delay = 200;

            // Draw an equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);

            // reset delay
            Turtle.Delay = defaultDelay;
        }
        //---------------------------------------------------------------------

        /*
           Method:  buttonReset_Click(object sender, EventArgs e)

           It deletes the currently drawn picture leaving the screen
           empty and ready for another drawing.
        */
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }
        //---------------------------------------------------------------------

        /*
           Method: buttonShowHideTurtle_Click(object sender, EventArgs e)

           It shows / hides the cursor if it is hidden/ shown; 
           matches the button text depending on its current action.
        */
        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }
        //---------------------------------------------------------------------

        /*
           Method:  buttonDrawHexagon_Click(object sender, EventArgs e)

           It draws a hexagon.
        */
        private void buttonDrawHexagon_Click(object sender, EventArgs e)
        {
            int sides = 6;
            int centralAngle = 60;
            int edgeLength = 100;

            for (int i = 0; i < sides; i++)
            {
                Turtle.Rotate(centralAngle);
                Turtle.Forward(edgeLength);
            }
        }
        //---------------------------------------------------------------------

        /*
           Method: buttonDrawStar_Click(object sender, EventArgs e)

           It draws a pentagram.
        */
        private void buttonDrawStar_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = System.Drawing.Color.Green;

            int vertices = 5;
            // clockwise Rotation by 36 == counterclockwise Rotation by 144
            int interiorAngle = 180 - (180 / vertices);
            int sideLength = 200;

            for (int i = 0; i < vertices; i++)
            {
                Turtle.Forward(sideLength);
                Turtle.Rotate(interiorAngle);
            }

            // reset pen color
            Turtle.PenColor = System.Drawing.Color.Blue;
        }
        //---------------------------------------------------------------------

        /*
            Method: nthFibonacci(int n)

            It returns the n-th Fibonacci number.
        */
        double nthFibonacci(int n)
        {
            const double goldenRatio = 1.618034d;

            return ( Math.Pow(goldenRatio, n) - Math.Pow((1d - goldenRatio), n) ) / Math.Sqrt(5d);
        }
        //---------------------------------------------------------------------

        /*
           Method: buttonDrawSpiral_Click(object sender, EventArgs e)

           It draws a spiral. (using the golden ratio (Fibonacci numbers) as increasing length.)
        */
        private void buttonDrawSpiral_Click(object sender, EventArgs e)
        {
            // double lengthScaleFactor = 0.1;
            int verticesNumber = 20;
            int angle = 60;
            float sideLength = 5f;

            for (int i = 0; i < verticesNumber; i++)
            {
                // double side = nthFibonacci(i) * lengthScaleFactor;
                Turtle.Forward(sideLength);
                Turtle.Rotate(angle);

                sideLength += 10;
                // sideLength *= 1.618034f;
            }
        }
        //---------------------------------------------------------------------

        /*
           Method: buttonDrawSun_Click(object sender, EventArgs e)

           It draws a sun.  
        */
        private void buttonDrawSun_Click(object sender, EventArgs e)
        {
            Turtle.PenSize = 6;
           
            int verticesNumber = 36;
            int sideLength = 50;
            int angle = 10;

            // draw a thick circle ...

            // draw 32 triangles each rotated by 10 deg.
            for (int i = 0; i < verticesNumber; i++)
            {
                Turtle.Rotate(angle);
                Turtle.Forward(sideLength);
                Turtle.Rotate(180 - 2 * angle);
                Turtle.Forward(sideLength);
                Turtle.Rotate(-180);
            }

            // reset pensize
            Turtle.PenSize = Turtle.DefaultPenSize;
        }
        //---------------------------------------------------------------------

        /*
           Method: buttonSpiralTriangleDraw_Click(object sender, EventArgs e)

           It draws a spiral triangle.  
        */
        private void buttonSpiralTriangleDraw_Click (object sender, EventArgs e)
        {
            int verticesNumber = 22;
            int angle = 120;
            float sideLength = 5f;
           
            for (int j = 0; j < verticesNumber; j++)
            {
                Turtle.Forward(sideLength);
                Turtle.Rotate(angle);

                sideLength += 10;
            }
        }
    }
}
