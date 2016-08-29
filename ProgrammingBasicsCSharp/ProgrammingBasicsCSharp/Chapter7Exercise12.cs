/*
   <summary>     
   TITLE              Fill in matrix pattern  Chapter7Exercise12.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Fill in all the elements of n x n array 
                      with increasing seqeunce of values [1, n^2]. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>14.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise12
    {
        static void Main()
        {
            Console.WriteLine("Type 2D matrix dimension:");
            int dimension = int.Parse(Console.ReadLine());

            FillVertically(dimension);

            FillVerticallyEvenColumnReversed(dimension);

            FillParallelToMainDiagonal(dimension);

            FillCounterClockwiseInwardSpiral(dimension);
        }
        //-----------------------------------------------------------------------------

        /*
            Method: FillVertically(dimension);

            It fills a 2D array of n x n, n = "dimension" 
            in the format:

            a d g
            b e h 
            c f i
        */
        static void FillVertically(int dimension)
        {
            int[,] arr = new int[dimension, dimension];
            // fill array
            int element = 0;
            for (int column = 0; column < dimension; column++)
            {
                for (int row = 0; row < dimension; row++)
                {
                    arr[row, column] = ++element;
                }
            }
            PrintMatrix(arr);
        }
        //-----------------------------------------------------------------------------

        /*
                Method: FillVerticallyEvenColumnReversed(dimension);

                It fills a 2D array of n x n, n = "dimension" 
                in the format:

                a f g
                b e h 
                c d i
            */
        static void FillVerticallyEvenColumnReversed(int dimension)
        {
            int[,] arr = new int[dimension, dimension];
            // fill array
            int element = 0;
            for (int column = 0; column < dimension; column++)
            {
                if (column != 0 && column % 2 != 0)  // fill odd columns in reversed order
                {
                    for (int row = dimension - 1; row >= 0; row--)
                    {
                        arr[row, column] = ++element;
                    }
                }
                else
                {
                    for (int row = 0; row < dimension; row++)
                    {
                        arr[row, column] = ++element;
                    }
                }
            }
            PrintMatrix(arr);
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
            // fill array
            int element = 0;

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

                    row++;
                    column++;
                }
                // adjust row start / end indexes
                if (startingRow > 0)
                {
                    --startingRow;
                }
                else
                {
                    --endingRow;
                }
                // adjust column start / end indexes
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
           Method: FillCounterClockwiseInwardSpiral(dimension);

            It fills a 2D array of size n x n, n = "dimension" 
            in the format:

            a h g
            b i f
            c d e
       */
        static void FillCounterClockwiseInwardSpiral(int dimension)
        {
            int[,] spiralMatrix = new int[dimension, dimension];
            // fill array
            int element = 1;

            // starting and ending row and column indexes
            int col1 = 0, col2 = dimension - 1;
            int row1 = 0, row2 = dimension - 1;

            // run loop till all elements populated in inner counter clockwise pattrern
            int length = dimension * dimension;
            while (element <= length)
            {
                // fill left column
                for (int i = row1; i <= row2; i++)
                {
                    spiralMatrix[i, col1] = element++;
                }

                // fill bottom row
                for (int j = col1 + 1; j <= col2; j++)
                {
                    spiralMatrix[row2, j] = element++;
                }

                // fill right column
                for (int k = row2 - 1; k >= row1; k--)
                {
                    spiralMatrix[k, col2] = element++;
                }

                // fill top row
                for (int l = col2 - 1; l >= col1 + 1; l--)
                {
                    spiralMatrix[row1, l] = element++;
                }

                // adjust start / end indexes
                col1++; col2--;
                row1++; row2--;
            }
            PrintMatrix(spiralMatrix);
        }
        //-----------------------------------------------------------------------------

        /*
            Method: PrintMatrix(arr);

            It prints all the elements of the 2D array
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
