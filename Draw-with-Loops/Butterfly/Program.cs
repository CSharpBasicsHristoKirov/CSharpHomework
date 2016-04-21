/*
  <summary>    
  TITLE              Butterfly                         Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. 
                     Print a "Butterfly" of size: (2 * n - 1) x  (2 * (n - 2) + 1). 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char space = ' ';

            // forewing
            char upperLeftBasal = '\\';
            char upperLeftDiscal = '*';
            char upperLeftPostDiscal = '-';

            char upperRightBasal = '/';
            char upperRightDiscal = '*';
            char upperRightpostDiscal = '-';

            int length = n - 2;
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    Console.Write(new string(upperLeftDiscal, n - 2));
                    Console.Write(new string(upperLeftBasal, 1));

                    Console.Write(space);

                    Console.Write(new string(upperRightBasal, 1));
                    Console.Write(new string(upperRightDiscal, n - 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string(upperLeftPostDiscal, n - 2));
                    Console.Write(new string(upperLeftBasal, 1));

                    Console.Write(space);

                    Console.Write(new string(upperRightBasal, 1));
                    Console.Write(new string(upperRightpostDiscal, n - 2));
                    Console.WriteLine();
                }
            }

            // thorax
            char thorax = '@';
            Console.Write(new string(space, n - 1));
            Console.WriteLine(thorax);

            // hindwing
            char lowerLeftBasal = '/';
            char lowerLeftDiscal = '*';
            char lowerLeftPostDiscal = '-';

            char lowerRightBasal = '\\';
            char lowerRightDiscal = '*';
            char lowerRightpostDiscal = '-';

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    Console.Write(new string(lowerLeftDiscal, n - 2));
                    Console.Write(new string(lowerLeftBasal, 1));

                    Console.Write(space);

                    Console.Write(new string(lowerRightBasal, 1));
                    Console.Write(new string(lowerRightDiscal, n - 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string(lowerLeftPostDiscal, n - 2));
                    Console.Write(new string(lowerLeftBasal, 1));

                    Console.Write(space);

                    Console.Write(new string(lowerRightBasal, 1));
                    Console.Write(new string(lowerRightpostDiscal, n - 2));
                    Console.WriteLine();
                }
            }

        }
    }
}
