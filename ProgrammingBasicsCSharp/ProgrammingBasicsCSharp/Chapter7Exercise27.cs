/*
   <summary>     
   TITLE              Largest area with identical values  Chapter7Exercise27.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: It prints the size (and value) of the largest area
                      composed of adjacent elements with identical values. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>19.03.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise27
    {
        /*
            Method: largestAreaOfIdenticalAdjacentElements (arr2D);

            It prints the area (number of adjacent elements) of
            elements with identical value, within the 2D matrix
            passed as paremeter.
        */
        static void largestAreaOfIdenticalAdjacentElements(int[,] arr2D)
        {
            int value = 0;
            int largestArea = 0;
            HashSet<Tuple<int, int>> largestAreaElements = new HashSet<Tuple<int, int>>();

            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    // stores all unique matrix elements with the same values
                    HashSet<Tuple<int,int>> visited = new HashSet<Tuple<int, int>>();

                    // mark start element as visited
                    Tuple<int, int> MatrixElement = new Tuple<int, int>(i,j);
                    visited.Add(MatrixElement);

                    checkLeft(arr2D, i, j, visited);
                    checkRight(arr2D, i, j, visited);
                    checkUp(arr2D, i, j, visited);
                    checkDown(arr2D, i, j, visited);

                    // check if area with current value is largest
                    if (visited.Count > largestArea)
                    {
                        value = arr2D[i, j];
                        largestArea = visited.Count;
                        largestAreaElements = visited;
                    }
                }
            }

            // mark the area
            char[,] area = new char[arr2D.GetLength(0), arr2D.GetLength(1)];
            foreach (var item in largestAreaElements)
            {
                area[item.Item1, item.Item2] = '*';
            }

            printMatrix(area);

            // print result
            Console.WriteLine("Value: {0} Area: {1}", value, largestArea);
        }

        //----------------------------------------------------------------------------
        /*
            Method: checkLeft (arr2D, i, j, visited);

            arr2D - target 2D matrix storing seached elements
            i - row of current element
            j - column of current element
            visited - collection holding the unique adjacent elements with same value

            It recursively checks for elements with identical values to the left, up, and down.
        */
        static void checkLeft(int[,] arr2D, int i, int j, HashSet<Tuple<int, int>> visited)
        {
            int currentValue = arr2D[i, j];
            int col = j - 1;

            if (col < 0)
            {
                return;
            }

            while (col >= 0)
            {
                Tuple<int, int> nextElement = new Tuple<int, int>(i, col);
                if (arr2D[i, col] == currentValue && !visited.Contains(nextElement))
                {
                    visited.Add(nextElement);

                    // check up
                    checkUp(arr2D, i, col, visited);

                    // check down
                    checkDown(arr2D, i, col, visited);
                }
                else
                {
                    break;
                }
                --col;
            }
        }

        //----------------------------------------------------------------------------
        /*
            Method: checkUp (arr2D, i, j, visited);

            arr2D - target 2D matrix storing seached elements
            i - row of current element
            j - column of current element
            visited - collection holding the unique adjacent elements with same value

            It recursively checks for elements with identical values to the up, left, and right.
        */
        static void checkUp(int[,] arr2D, int i, int j, HashSet<Tuple<int, int>> visited)
        {
            int currentValue = arr2D[i, j];
            int row = i - 1;

            if (row < 0)
            {
                return;
            }

            while (row >= 0)
            {
                Tuple<int, int> nextElement = new Tuple<int, int>(row, j);
                if (arr2D[row, j] == currentValue && !visited.Contains(nextElement))
                {
                    visited.Add(nextElement);

                    // check left 
                    checkLeft(arr2D, row, j, visited);

                    // check right
                    checkRight(arr2D, row, j, visited);
                }
                else
                {
                    break;
                }
                --row;
            }
        }

        //----------------------------------------------------------------------------
        /*
            Method: checkRight (arr2D, i, j, visited);

            arr2D - target 2D matrix storing seached elements
            i - row of current element
            j - column of current element
            visited - collection holding the unique adjacent elements with same value

            It recursively checks for elements with identical values to the right, up, and down.
        */
        static void checkRight(int[,] arr2D, int i, int j, HashSet<Tuple<int, int>> visited)
        {
            int currentValue = arr2D[i, j];
            int col = j + 1;

            if (col >= arr2D.GetLength(1))
            {
                return;
            }

            while (col < arr2D.GetLength(1))
            {
                Tuple<int, int> nextElement = new Tuple<int, int>(i, col);
                if (arr2D[i, col] == currentValue && !visited.Contains(nextElement))
                {
                    visited.Add(nextElement);

                    // check up
                    checkUp(arr2D, i, col, visited);

                    // check down
                    checkDown(arr2D, i, col, visited);
                }
                else
                {
                    break;
                }
                ++col;
            }
        }

        //----------------------------------------------------------------------------
        /*
            Method: checkDown (arr2D, i, j, visited);

            arr2D - target 2D matrix storing seached elements
            i - row of current element
            j - column of current element
            visited - collection holding the unique adjacent elements with same value

            It recursively checks for elements with identical values to the down, left, and right.
        */
        static void checkDown(int[, ] arr2D, int i, int j, HashSet<Tuple<int, int>> visited)
        {
            int currentValue = arr2D[i, j];
            int row = i + 1;

            if (row >= arr2D.GetLength(0))
            {
                return;
            }

            while (row < arr2D.GetLength(0))
            {
                Tuple<int, int> nextElement = new Tuple<int, int>(row, j);
                if (arr2D[row, j] == currentValue && !visited.Contains(nextElement))
                {
                    visited.Add(nextElement);

                    // check left
                    checkLeft(arr2D, row, j, visited);

                    // check right
                    checkRight(arr2D, row, j, visited);
                }
                else
                {
                    break;
                }
                ++row;
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

        //-----------------------------------------------------------------------------
        /*
            Method: printMatrix(arr);

            It prints all the elements of the 2D array
        */
        static void printMatrix(char[,] arr)
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

        //============================================================================

        static void Main()
        {
            // target matrix
            int[,] matrix = new int[,] { { 1, 3, 2, 2, 2, 4 },
                                         { 3, 3, 3, 2, 4, 4 },
                                         { 4, 3, 1, 2, 3, 3 },
                                         { 4, 3, 1, 3, 3, 1 },
                                         { 4, 3, 3, 3, 1, 1,}
                                       };
            printMatrix(matrix);

            // find largest area of identical adjacent elements
            largestAreaOfIdenticalAdjacentElements(matrix);
        }
    }
}
