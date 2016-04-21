/*
  <summary>    
  TITLE              Magic Numbers                     Program.cs
  Basic Level  -  Programming Basics  26 Match 2016 Exam Exercise
  COMMENT
          Objective: Read an integers: n 
                     Print all the 6 digit numbers for which
                     the product of their digits is a equal 
                     to the "magical number" n.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int n = 9;
            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (int third = 1; third <= n; third++)
                    {
                        for (int fourth = 1; fourth <= n; fourth++)
                        {
                            for (int fifth = 1; fifth <= n; fifth++)
                            {
                                for (int sixth = 1; sixth <= n; sixth++)
                                {
                                    if (first * second * third * fourth * fifth * sixth == number)
                                    { 
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", first, second, third, fourth, fifth, sixth);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
