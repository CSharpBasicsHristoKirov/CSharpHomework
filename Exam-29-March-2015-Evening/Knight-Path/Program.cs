/*
  <summary>    
  TITLE              Knight Path                       Program.cs
  Basic Level  -  Programming Basics - Exam_29_March_2015_Evening
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>21.04.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace Knight_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[8, 8];

            // coordinates[0] - row; coordinates[1] - column
            int[] coordinates = new int[2];
            coordinates[1] = 7;

            // mark the initial position
            board[coordinates[0], coordinates[1]] = 1;

            while (true)
            {
                string input = Console.ReadLine();

                // check for exit
                if (input == "stop")
                {
                    break;
                }

                // directions[0] - vertical; directions[1] - horizontal
                string[] directions = input.Split(' ');

                // movement: 2 position in first direction and 1 in second
                int row = 0;
                int col = 0;

                for (int i = 0; i < directions.Length; i++)
                {

                    if (directions[i] == "left")
                    {
                        if (coordinates[1] - 2 + i < 0)
                        {
                            break;
                        }
                        col -= (2 - i);
                    }
                    else if (directions[i] == "right")
                    {
                        if (coordinates[1] + 2 - i >= 8)
                        {
                            break;
                        }
                        col += (2 - i);
                    }
                    else if (directions[i] == "up")
                    {
                        if (coordinates[0] - 2 + i < 0)
                        {
                            break;
                        }
                        row -= (2 - i);
                    }
                    else if (directions[i] == "down")
                    {
                        if (coordinates[0] + 2 - i >= 8)
                        {
                            break;
                        }
                        row += (2 - i);
                    }
                }

                if (row != 0 && col != 0) // no cyclic moves:  && board[coordinates[0] + row, coordinates[1] + col] != 1
                {
                    coordinates[0] += row;
                    coordinates[1] += col;
                }

                if (board[coordinates[0], coordinates[1]] == 0)
                {
                    board[coordinates[0], coordinates[1]] = 1;
                }
                else
                {
                    board[coordinates[0], coordinates[1]] = 0;
                }
            }

            // print the numbers != 0 resulting from the board values
            List<string> rowsToPrint = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                string line = string.Empty;
                bool notZero = false;
                for (int j = 0; j < 8; j++)
                {
                    line += board[i, j];

                    if (board[i, j] != 0)
                    {
                        notZero = true;
                    }
                }

                if (notZero)
                {
                    rowsToPrint.Add(line);
                }
            }

            if (rowsToPrint.Count == 0)
            {
                Console.WriteLine("[Board is empty]");
            }
            else
            {
                for (int i = 0; i < rowsToPrint.Count; i++)
                {
                    Console.WriteLine(Convert.ToInt32(rowsToPrint[i], 2));
                }
            }
        }
    }
}