/*
   <summary>     
   TITLE              Largest area with identical values  Chapter7Exercise27.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: It prints the size (and value) of the largest area
                      composed of adjacent elements with identical values. 

                      It checks all the neighbouring elements similarly to
                      Breadth First Search, however, it start the checks 
                      from each element of the matrix.

                      Possible optimization: all the elements from already
                      covered areas to be collected and excluded from the 
                      search.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>21.03.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise27
    {
        static void Main()
        {
            // target matrix
            int[,] matrix = new int[,] { { 1, 3, 2, 2, 2, 4 },
                                         { 3, 3, 3, 2, 4, 4 },
                                         { 4, 3, 1, 2, 3, 3 },
                                         { 4, 3, 1, 3, 3, 1 },
                                         { 4, 3, 3, 3, 1, 1,}
                                       };
            PrintMatrix(matrix);

            MaxAreaOfIdenticalAdjacentElements(matrix);
        }
        //----------------------------------------------------------------------------

        /*
            Method:  MaxAreaOfIdenticalAdjacentElements (arr2D);

        */
        static void MaxAreaOfIdenticalAdjacentElements(int[,] arr2D)
        {
            int value = 0;
            int largestArea = 0;
            HashSet<Tuple<int, int>> largestAreaElements = new HashSet<Tuple<int, int>>();

            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    // stores all unique matrix elements with the same values
                    HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();

                    // mark start element as visited
                    Tuple<int, int> MatrixElement = new Tuple<int, int>(i, j);
                    visited.Add(MatrixElement);

                    CheckLeft(arr2D, i, j, visited);
                    CheckRight(arr2D, i, j, visited);
                    CheckUp(arr2D, i, j, visited);
                    CheckDown(arr2D, i, j, visited);

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

            PrintMatrix(area);

            // print result
            Console.WriteLine("Value: {0} Area: {1}", value, largestArea);
        }
        //----------------------------------------------------------------------------

        /*
            Method: CheckLeft (arr2D, i, j, visited);

            arr2D - target 2D matrix storing seached elements
            i - row of current element
            j - column of current element
            visited - collection holding the unique adjacent elements with same value

            It recursively checks for elements with identical values to the left, up, and down.
        */
        static void CheckLeft(int[,] arr2D, int i, int j, HashSet<Tuple<int, int>> visited)
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
                    CheckUp(arr2D, i, col, visited);

                    // check down
                    CheckDown(arr2D, i, col, visited);
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
            Method: CheckUp (arr2D, i, j, visited);

            arr2D - target 2D matrix storing seached elements
            i - row of current element
            j - column of current element
            visited - collection holding the unique adjacent elements with same value

            It recursively checks for elements with identical values to the up, left, and right.
        */
        static void CheckUp(int[,] arr2D, int i, int j, HashSet<Tuple<int, int>> visited)
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
                    CheckLeft(arr2D, row, j, visited);

                    // check right
                    CheckRight(arr2D, row, j, visited);
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
            Method: CheckRight (arr2D, i, j, visited);

            arr2D - target 2D matrix storing seached elements
            i - row of current element
            j - column of current element
            visited - collection holding the unique adjacent elements with same value

            It recursively checks for elements with identical values to the right, up, and down.
        */
        static void CheckRight(int[,] arr2D, int i, int j, HashSet<Tuple<int, int>> visited)
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
                    CheckUp(arr2D, i, col, visited);

                    // check down
                    CheckDown(arr2D, i, col, visited);
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
            Method: CheckDown (arr2D, i, j, visited);

            arr2D - target 2D matrix storing seached elements
            i - row of current element
            j - column of current element
            visited - collection holding the unique adjacent elements with same value

            It recursively checks for elements with identical values to the down, left, and right.
        */
        static void CheckDown(int[,] arr2D, int i, int j, HashSet<Tuple<int, int>> visited)
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
                    CheckLeft(arr2D, row, j, visited);

                    // check right
                    CheckRight(arr2D, row, j, visited);
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
            Method: PrintMatrix(arr);

            It prints all the elements of the 2D integer array.
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
        //-----------------------------------------------------------------------------

        /*
            Method: PrintMatrix(arr);

            It prints all the elements of the 2D char array.
        */
        static void PrintMatrix(char[,] arr)
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
