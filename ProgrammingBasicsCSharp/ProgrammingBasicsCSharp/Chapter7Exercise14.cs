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
        /*
            Method: checkLeft(arr2D, row, column, currentElement);

            It returns how many identical to "currentElement" are there
            to the left of the current element.
        */
        static int checkLeft(string[,] arr2D, int row, int column ,string currentElement)
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
        static int checkTopLeftDiagonal(string[,] arr2D, int row, int column, string currentElement)
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
        static int checkTop(string[,] arr2D, int row, int column, string currentElement)
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
        static int checkTopRightDiagonal(string[,] arr2D, int row, int column, string currentElement)
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
        static int checkRight(string[,] arr2D, int row, int column, string currentElement)
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
        static int checkBottomRightDiagonal(string[,] arr2D, int row, int column, string currentElement)
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
        static int checkBottom(string[,] arr2D, int row, int column, string currentElement)
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
        static int checkBottomLeftDiagonal(string[,] arr2D, int row, int column, string currentElement)
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
        */
        static int findLongestSequenceOfIdenticalElements(string[,] strMatrix2D)
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
                    maxLength = Math.Max(maxLength, checkLeft(strMatrix2D, row, column, currentElement));
                    // check top left diagonal
                    maxLength = Math.Max(maxLength, checkTopLeftDiagonal(strMatrix2D, row, column, currentElement));
                    // check top
                    maxLength = Math.Max(maxLength, checkTop(strMatrix2D, row, column, currentElement));
                    // check top right diagonal
                    maxLength = Math.Max(maxLength, checkTopRightDiagonal(strMatrix2D, row, column, currentElement));
                    // check right 
                    maxLength = Math.Max(maxLength, checkRight(strMatrix2D, row, column, currentElement));
                    // check right bottom diagonal
                    maxLength = Math.Max(maxLength, checkBottomRightDiagonal(strMatrix2D, row, column, currentElement));
                    // check bottom
                    maxLength = Math.Max(maxLength, checkBottom(strMatrix2D, row, column, currentElement));
                    // check left bottom diagonal
                    maxLength = Math.Max(maxLength, checkBottomLeftDiagonal(strMatrix2D, row, column, currentElement));
                }
            }

            return maxLength;
        }

        //===========================================================================
        static void Main()
        {
            string[,] strMatrix2D = { { "ha",   "ha1",   "ho", "hi"}, 
                                      { "fo",   "ha1",   "ha", "xx"}, 
                                      {"xxx",   "ha1",  "ha2", "xx"}, 
                                      { "ha",   "ha1", "ha22", "ha3"}
                                    };
           
            // print result
            Console.WriteLine("Length of longest sequence: {0}", findLongestSequenceOfIdenticalElements(strMatrix2D));
        }
    }
}
