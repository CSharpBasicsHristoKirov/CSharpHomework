/*
   <summary>     
   TITLE              Subarray with max sum    Chapter7Exercise13.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read 2D matrix dimensions m and n.
                      Populate the m x n matrix.
                      Find the 3 x 3 submatrix with max sum.  
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise13
    {
        /*
            Method: populate2Darray(arr2D);

            It prompts the user to fill in the 
            elements of predefined 2D array.
        */
        static void populate2Darray(int[, ] arr2D)
        {
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                for (int column = 0; column < arr2D.GetLength(1); column++)
                {
                    Console.Write("arr[{0},{1}] = ", row, column);
                    arr2D[row,column] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("All array values assigned.");
        }

        //----------------------------------------------------------------------------
        /*
            Method: findSubMatrixMaxSum(arr2D, submatrixDimension);

            It returns the submatrix with the max sum of the values of
            its elements.
        */
        static void findSubMatrixMaxSum(int[,] arr2D, int submatrixDimension)
        {
            int maxSum = int.MinValue;
            int startRow = 0;
            int startColumn = 0;

            // traverse the 2D array with the subarray
            for (int i = 0; i <= arr2D.GetLength(0) - submatrixDimension; i++)
            {
                for (int j = 0; j <= arr2D.GetLength(1) - submatrixDimension; j++)
                {
                    // Console.WriteLine("\n[i, j] = {0}, {1}", i, j);
                    // sum all the elements of the subarray
                    int currentSum = 0;
                    for (int row = i; row < submatrixDimension + i; row++)
                    {
                        for (int column = j; column < submatrixDimension + j; column++)
                        {
                            currentSum += arr2D[row, column];
                            // Console.Write("sum: {0}. ", currentSum);
                        }
                    }

                    // check if sum max
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startRow = i;
                        startColumn = j;
                    }
                }
            }

            // print submatrix with the max sum and its value
            Console.WriteLine("The left- and top- most {0} x {1} subarray with max sum = {2}, is:",
                               submatrixDimension, submatrixDimension, maxSum);
            for (int i = startRow; i < startRow + submatrixDimension; i++)
            {
                for (int j = startColumn; j < startColumn + submatrixDimension; j++)
                {
                    Console.Write("{0,3}", arr2D[i, j]);
                }
                Console.WriteLine();
            }    
        }

        //-----------------------------------------------------------------------------
        /*
            Method: printMatrix(arr);

            It prints all the elements of the 2D array
        */
        static void printMatrix(int[,] arr)
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

        //=============================================================================
        static void Main()
        {
            // read input
            Console.WriteLine("Type number of rows: " );
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Type number of columns: ");
            int m = int.Parse(Console.ReadLine());

            // define the matrix 
            int[,] matrix2D = new int[n, m];

            populate2Darray(matrix2D);

            printMatrix(matrix2D);

            // find submatrix with max sum of elements
            int submatrixsize = 3;
            findSubMatrixMaxSum(matrix2D, submatrixsize);
        }
    }
}
