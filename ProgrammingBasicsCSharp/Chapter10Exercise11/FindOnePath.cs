/*
   <summary>    
   TITLE         Find a path in labyrinth          Chapter10Exercise10
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: The values of a 2D array indicate accessible and
                      inaccessible cells.
                      Find one possible path between two given cells 
                      in the 2D array.
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise11
{
    class FindOnePath
    {
        static void Main(string[] args)
        {
            int width = 100;
            int depth = 100;
            int exitX = 99;
            int exitY = 99;
            InitializeMaze(width, depth, exitX, exitY);
            
            int startX = 0;
            int startY = 0;
            FindPath(startX, startY, 's');
        }
        //----------------------------------------------------------------

        /* Data members: maze, path, position */
        static char[,] maze;
        static char[] path;
        static int position = 0;
        //----------------------------------------------------------------

        /*
            Method: FindPath()

        */
        private static void FindPath(int row, int col, char direction)
        {
            // Check maze bounds
            if (row < 0 || col < 0 ||
                row >= maze.GetLength(0) || col >= maze.GetLength(1))
            {
                return;
            }

            path[position] = direction;
            position++;

            // Print Path if exit found
            if (maze[row, col] == 'e')
            {
                Console.WriteLine("Path length = {0}", position - 1);
                PrintPath(path, 0, position - 1);
                
                Console.ReadLine();
            }

            // Check cell accessibility
            if (maze[row, col] == ' ')
            {
                maze[row, col] = 's';
                
                FindPath(row - 1, col, 'U');
                FindPath(row, col - 1, 'L');
                FindPath(row + 1, col, 'D');
                FindPath(row, col + 1, 'R');
            }

            // Remove last direction
            position--;
        }
        //----------------------------------------------------------------

        /*
            Method: PrintPath(char[] path, int iBegin, int iEnd)

        */
        private static void PrintPath(char[] path, int iBegin, int iEnd)
        {
            Console.Write("Path found: ");
            for (int i = iBegin; i < iEnd; i++)
            {
                Console.Write(path[i]);
            }
            Console.WriteLine();
        }
        //----------------------------------------------------------------

        /*
            Method: InitializeMaze();

            
        */
        private static void InitializeMaze(int width, int depth, int exitX, int exitY)
        {
            maze = new char [width, depth];
            path = new char[maze.GetLength(0) * maze.GetLength(1)];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < depth; j++)
                {
                    maze[i, j] = ' ';
                }
            }
            maze[exitX, exitY] = 'e';
        }
    }
}
