/*
   <summary>    
   TITLE   Find every path in labyrinth         Chapter10Exercise10
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: The values of a 2D array indicate accessible and
                      inaccessible cells.
                      Find all possible paths between two given cells 
                      in the 2D array.
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>14.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise10
{
    class EveryLabyrinthPath
    {
        static void Main(string[] args)
        {
            int x0 = 0;
            int y0 = 0;
            char start = 's';
            FindPath(x0, y0, start);
        }
        //-------------------------------------------------------------

        /* 2D array representing a maze */ 
        static char[,] maze =
        {
            {' ', '*', ' '},
            {' ', ' ', ' '},
            {' ', ' ', 'e'},
        };

        static char[] path = new char[maze.GetLength(0) * maze.GetLength(1)];
        static int position = 0;
        //----------------------------------------------------------------------------------

        private static void FindPath(int row, int col, char direction)
        {
            // Check if inside bounds of maze
            if ((row < 0) || (col < 0) || 
                (row >= maze.GetLength(0)) || (col >= maze.GetLength(1)))
            {
                return;
            }
             
            // Save current direction
            path[position] = direction;
            position++;

            // Check if current cell is exit
            if (maze[row, col] == 'e')
            {
                PrintPath(path, 1 , position - 1);
            }

            // Check if current cell is accessible
            if (maze[row, col] == ' ')
            {
                // Mark current cell as visited
                maze[row, col] = 's';

                // Make recursive call to next cells
                FindPath(row - 1, col, 'U');
                FindPath(row , col - 1, 'L');
                FindPath(row + 1, col, 'D');
                FindPath(row, col + 1, 'R');

                // Set current cell as free again (backtracking)
                maze[row, col] = ' ';
            }

            // Remove last direction
            position--;
        }
        //----------------------------------------------------------------------------------

        /*
            Method: PrintPath(char[] path)

        */
        private static void PrintPath(char[] path, int iBegin, int iEnd)
        {
            Console.Write("Path to the exit: ");
            for (int i = iBegin; i <= iEnd; ++i)
            {
                Console.Write(path[i]);
            }
            Console.WriteLine();
        }
    }
}
