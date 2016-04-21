/*
  <summary>    
  TITLE              Draw Fort                         Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a "Fort" of size: 2 * n x n. 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // tower
            char leftTower = '/';
            char centralTower = '^';
            char rightTower = '\\';
            char towerConnect = '_';

            Console.Write(leftTower);
            Console.Write(new string(centralTower, n / 2));
            Console.Write(rightTower);

            Console.Write(new string(towerConnect, 2 * (n - (n /2) - 2)));

            Console.Write(leftTower);
            Console.Write(new string(centralTower, n / 2));
            Console.Write(rightTower);
            Console.WriteLine();

            // walls
            char wall = '|';
            char space = ' ';
            char baseConnect = '_';
            int connectLength = 2 * (n - (n / 2) - 2);

            int length = n - 2;
            for (int i = 0; i < length; i++)
            {
                Console.Write(wall);

                if (n > 4 && i == length - 1)
                {
                    Console.Write(new string(space, n / 2 + 1));
                    
                    Console.Write(new string(baseConnect, connectLength));
                    Console.Write(new string(space, n / 2 + 1));
                }
                else
                {
                    Console.Write(new string(space, 2 * n - 2));

                }

                Console.Write(wall);
                Console.WriteLine();
            }

            // base
            char leftBase = '\\';
            char rightBase = '/';
            char centralBase = '_';

            Console.Write(leftBase);
            Console.Write(new string(centralBase, n / 2));
            Console.Write(rightBase);

            Console.Write(new string(space, connectLength));

            Console.Write(leftBase);
            Console.Write(new string(centralBase, n / 2));
            Console.Write(rightBase);
            Console.WriteLine();
        }
    }
}
