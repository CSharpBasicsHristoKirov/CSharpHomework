/*
   <summary>     
   TITLE              Traverse 2D Matrix      Chapter7Exercise26.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Go through matrix elements in specific pattern: 
                      in parallel / perpendicularly to the main
                      diagonal starting from the bottom.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>19.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise26
    {
        static void Main()
        {
            Console.Write("N = ");
            int dimension = int.Parse(Console.ReadLine());

            FillParallelToMainDiagonal(dimension);

            FillPerpendicularToMainDiagonal(dimension);
        }
        //-----------------------------------------------------------------------------

        /*
            Method: FillParallelToMainDiagonal(dimension);

            It fills a 2D array of size n x n, n = "dimension" 
            in the format:

            d g i
            b e h
            a c f
        */
        static void FillParallelToMainDiagonal(int dimension)
        {
            int[,] arr = new int[dimension, dimension];

            // array filler
            int element = 0;

            // starting/ ending diagonal coordinates
            // start from bottom to top
            int startingRow = dimension - 1;
            int endingRow = dimension;

            // start from left to right
            int startingColumn = 0;
            int endingColumn = 1;

            while (element < dimension * dimension)
            {
                int row = startingRow;
                int column = startingColumn;

                // fill a diagonal
                while (row < endingRow)
                {
                    arr[row, column] = ++element;

                    // go from bottom right to top left
                    row++;
                    column++;
                }

                // adjust lenght of diagonals
                if (startingRow > 0)
                {
                    --startingRow;
                }
                else
                {
                    --endingRow;
                }

                if (endingColumn < dimension)
                {
                    ++endingColumn;
                }
                else
                {
                    ++startingColumn;
                }
            }
            PrintMatrix(arr);
        }
        //-----------------------------------------------------------------------------

        /*
            Method: FillPerpendicularToMainDiagonal(dimension);

            It fills a 2D array of size n x n, n = "dimension" 
            in the format:

            d g i
            b e h
            a c f
        */
        static void FillPerpendicularToMainDiagonal(int dimension)
        {
            int[,] arr = new int[dimension, dimension];

            // array filler 
            int element = 0;

            // Starting/ ending diagonal coordinates
            // start from bottom to top
            int startingRow = dimension - 1;
            int endingRow = dimension - 2;

            // start from right to left
            int startingColumn = dimension - 1;
            int endingColumn = dimension;

            while (element < dimension * dimension)
            {
                int row = startingRow;
                int column = startingColumn;

                // fill a diagonal
                while (row > endingRow)
                {
                    arr[row, column] = ++element;

                    // go from bottom left to top right
                    row--;
                    column++;
                }

                // adjust length of diagonal 
                if (endingRow >= 0)
                {
                    --endingRow;
                }
                else
                {
                    --startingRow;
                }

                if (startingColumn > 0)
                {
                    --startingColumn;
                }
                else
                {
                    --endingColumn;
                }
            }
            PrintMatrix(arr);
        }
        //-----------------------------------------------------------------------------

        /*
            Method: PrintMatrix(arr);

        */
        static void PrintMatrix(int[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int column = 0; column < arr.GetLength(1); column++)
                {
                    Console.Write("{0,3} ", arr[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
