/*
   <summary>     
   TITLE              Spiral number matrix    Chapter6Exercise17.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Reads an integer n. Prints a matrix
                      populated with increasing numbers from 1  
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>07.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise18
    {
        /*
            Method: printSpiralMatrix(int n);

            It prints a matrix populated with
            increasing numbers starting from 1,
            in a inward spiral. 
        */
        static void printSpiralMatrix(int n)
        {
            int[,] spiralMatrix = new int[n, n];
            
            // used to initialize matrix elements
            int numbers = 1;

            // starting and ending row and column indexes
            int col1 = 0, col2 = n - 1;
            int row1 = 0, row2 = n - 1;

            // fill in clockwise inward pattern
            int length = n * n;
            while (numbers <= length)
            {
                // fille top row
                for (int i = col1; i <= col2; i++)
                {
                    spiralMatrix[row1, i] = numbers++;
                }

                // fill right column
                for (int j = row1 + 1; j <= row2; j++)
                {
                    spiralMatrix[j, col2] = numbers++;
                }

                // fill bottom row
                for (int k = col2 - 1; k >= col1; k--)
                {
                    spiralMatrix[row2, k] = numbers++;
                }

                // fill left column
                for (int l = row2 - 1; l >= row1 + 1; l--)
                {
                    spiralMatrix[l, col1] = numbers++;
                }

                // adjust start / end indexes
                col1++; col2--;
                row1++; row2--;
            }

            // print matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 4}", spiralMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            Console.WriteLine("Type n x n matrix dimension:");
            int n = int.Parse(Console.ReadLine());

            printSpiralMatrix(n);
        }
    }
}
