/*
  <summary>    
  TITLE              Stupid Password Generator         Program.cs
  Basic Level  -  Programming Basics   6 Match 2016 Exam Exercise
  COMMENT
          Objective: Read integers: n and: l; in the interval [0, 9].
                     Print all the 5 symbol possible passwords 
                     composed of:
                     1 symbol: digit from 1 to n.
                     2 symbol: digit from 1 to n.
                     3 symbol: lower case letter from a to l.
                     4 symbol: lower case letter from a to l.
                     5 symbol: digit from 1 to n, larger than the first two symbols.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int first = 1; first < n; first++)
            {
                for (int second = 1; second < n; second++)
                {
                    for (char third = 'a';  third < 'a' + l;  third++)
                    {
                        for (char fourth = 'a'; fourth < 'a' + l; fourth++)
                        {
                            for (int fifth = Math.Max(first,second) + 1; fifth <= n; fifth++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", first, second, third, fourth, fifth);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
