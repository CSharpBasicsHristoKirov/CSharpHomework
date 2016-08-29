/*
   <summary>     
   TITLE              Find longest sequence   Chapter7Exercise14.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find longest sequence 
                      (horizontal, vertical and diagonal)
                      of identical string elements within 2D string array.

                      !It could be done by finding identical elements and 
                       then checking the relation of their indexes, i.e. if
                       on same row, column or diagonal!
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise14
    {
        static void Main()
        {
            string[,] strMatrix2D = { { "ha",   "ha1",   "ho", "hi"}, 
                                      { "fo",   "ha1",   "ha", "xx"}, 
                                      {"xxx",   "ha1",  "ha2", "xx"}, 
                                      { "ha",   "ha1", "ha22", "ha3"}
                                    };
           
            Console.WriteLine("Length of longest sequence: {0}", FindLongestSequenceOfIdenticalElements(strMatrix2D));
        }
        //-------------------------------------------------------------------------------------------

        /*
           Method: CheckLeft(arr2D, row, column, currentElement);

           It returns how many identical to "currentElement" are there
           to the left of the current element.
       */
        static int CheckLeft(string[,] arr2D, int row, int column, string currentElement)
        {
            int length = 0;
            do
            {
                if (currentElement == arr2D[row, column])
                {
                    ++length;
                }
                --row;
            } while (row >= 0);
            return length;
        }
        //-------------------------------------------------------------------------------------------

        /*
            Method: CheckTopLeftDiagonal()

        */
        static int CheckTopLeftDiagonal(string[,] arr2D, int row, int column, string currentElement)
        {
            int length = 0;
            do
            {
                if (currentElement == arr2D[row, column])
                {
                    ++length;
                }
                --row;
                --column;
            }
            while (row >= 0 && column >= 0);
            return length;
        }
        //-------------------------------------------------------------------------------------------

        /*
            Method: CheckTop()

        */
        static int CheckTop(string[,] arr2D, int row, int column, string currentElement)
        {
            int length = 0;
            do
            {
                if (currentElement == arr2D[row, column])
                {
                    ++length;
                }
                --row;
            }
            while (row >= 0);
            return length;
        }
        //-------------------------------------------------------------------------------------------

        /*
            Method: CheckTopRightDiagonal()

        */
        static int CheckTopRightDiagonal(string[,] arr2D, int row, int column, string currentElement)
        {
            int length = 0;
            do
            {
                if (currentElement == arr2D[row, column])
                {
                    ++length;
                }
                --row;
                ++column;
            }
            while (row >= 0 && column < arr2D.GetLength(1));
            return length;
        }
        //-------------------------------------------------------------------------------------------

        /*
            Method: CheckRight()

        */
        static int CheckRight(string[,] arr2D, int row, int column, string currentElement)
        {
            int length = 0;
            do
            {
                if (currentElement == arr2D[row, column])
                {
                    ++length;
                }
                ++column;
            }
            while (column < arr2D.GetLength(1));
            return length;
        }
        //-------------------------------------------------------------------------------------------

        /*
            Method: CheckBottomRightDiagonal()

        */
        static int CheckBottomRightDiagonal(string[,] arr2D, int row, int column, string currentElement)
        {
            int length = 0;
            do
            {
                if (currentElement == arr2D[row, column])
                {
                    ++length;
                }
                ++column;
                ++row;
            }
            while (row < arr2D.GetLength(0) && column < arr2D.GetLength(1));
            return length;
        }
        //-------------------------------------------------------------------------------------------

        /*
            Method: CheckBottom()

        */
        static int CheckBottom(string[,] arr2D, int row, int column, string currentElement)
        {
            int length = 0;
            do
            {
                if (currentElement == arr2D[row, column])
                {
                    ++length;
                }
                ++row;
            }
            while (row < arr2D.GetLength(0));
            return length;
        }
        //-------------------------------------------------------------------------------------------

        /*
            Method: CheckBottomLeftDiagonal()

        */
        static int CheckBottomLeftDiagonal(string[,] arr2D, int row, int column, string currentElement)
        {
            int length = 0;
            do
            {
                if (currentElement == arr2D[row, column])
                {
                    ++length;
                }
                ++row;
                --column;
            }
            while (row < arr2D.GetLength(0) && column >= 0);
            return length;
        }
        //---------------------------------------------------------------------------

        /*
            Method: findLongestSequenceOfIdenticalElements(arr2D);

            It returns the length of the longest sequence of identical
            elements.

            Complexity: O(n^2)
        */
        static int FindLongestSequenceOfIdenticalElements(string[,] strMatrix2D)
        {
            int maxLength = 1;

            // start the sequence from each element of the matrix
            for (int row = 0; row < strMatrix2D.GetLength(0); row++)
            {
                for (int column = 0; column < strMatrix2D.GetLength(1); column++)
                {
                    // get current element
                    string currentElement = strMatrix2D[row, column];
                    Console.WriteLine("Current Element: {0}", currentElement);

                    // check left
                    maxLength = Math.Max(maxLength, CheckLeft(strMatrix2D, row, column, currentElement));
                    // check top left diagonal
                    maxLength = Math.Max(maxLength, CheckTopLeftDiagonal(strMatrix2D, row, column, currentElement));
                    // check top
                    maxLength = Math.Max(maxLength, CheckTop(strMatrix2D, row, column, currentElement));
                    // check top right diagonal
                    maxLength = Math.Max(maxLength, CheckTopRightDiagonal(strMatrix2D, row, column, currentElement));
                    // check right 
                    maxLength = Math.Max(maxLength, CheckRight(strMatrix2D, row, column, currentElement));
                    // check right bottom diagonal
                    maxLength = Math.Max(maxLength, CheckBottomRightDiagonal(strMatrix2D, row, column, currentElement));
                    // check bottom
                    maxLength = Math.Max(maxLength, CheckBottom(strMatrix2D, row, column, currentElement));
                    // check left bottom diagonal
                    maxLength = Math.Max(maxLength, CheckBottomLeftDiagonal(strMatrix2D, row, column, currentElement));
                }
            }
            return maxLength;
        }
    }
}
