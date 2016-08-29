/*
   <summary>  
   TITLE             Output formatting         Chapter4Exercise4.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print three left aligned columns of width=10.
                      First prints integers in hex represnetation.
                      Second and third, positive and negative
                      floating-points up to the second digit after
                      the decimal point
               Input: -
              Output:                   !-------V
                        0         0.00      +0.00  
                        1         0.10      -0.10
                        3         0.30      -0.30
                        4         0.40      -0.40
                        5         0.50      -0.50
                        6         0.60      -0.60
                        7         0.70      -0.70
                        8         0.80      -0.80
                        9         0.90      -0.90
                        A         0.10      -0.10
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise4
    {
        static void Main()
        {
            // column width: 10 characters; alignment: left  

            // number format: hex,
            string firstColumnFormat = "{0,-10:X}";

            // number format: positive floating-point; precision: 2 digits after the decimal point 
            string secondColumnFormat = "{1,-10:F2}";

            // number format: negative floating-point; precision: 2 digits after the decimal point; display zero with sign
            string thirdColumnFormat = "{2,-10:+0.00;-0.00}";

            // number of columns: 3
            const int size = 10;
            int[ ] firstColumn = new int[size] {0, 1, 3, 4, 5, 6, 7 , 8 , 9 , 10};
            double[ ] secondColumn = new double[size] { 0.0, 0.1, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 0.10};
            double[] thirdColumn = new double[size] { -0.0, -0.1, -0.3, -0.4, -0.5, -0.6, -0.7, -0.8, -0.9, -0.10 };

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(firstColumnFormat + secondColumnFormat + thirdColumnFormat, firstColumn[i], secondColumn[i], thirdColumn[i]);
            }
        }
    }
}
