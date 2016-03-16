/*
   <summary>     
   TITLE              Compare char arrays       Chapter7Exercise3.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Compare lexicographically each element
                      of two arrays of type char and determine
                      which of the arrays, collectively, is 
                      lexicographically smaller.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>11.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise3
    {
        /*
            Method: compareLexicographically(a, b);

            Compare lexicographically the two arrays
            passed as parameters and print result.

            Comparison criteria:
            1. Arrays lengths. 
            2. Accumulated ASCII values of the array characters. 
        */
        static void compareLexicographically(char[] a, char[] b)
        {
            if (a.Length == b.Length) // same lengths
            {
                int suma = 0;
                int sumb = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    suma += a[i];
                    sumb += b[i];
                }

                if (suma == sumb)
                {
                    Console.WriteLine("Two arrays are lexicographically equal.\n");
                }
                else
                {
                    if (suma < sumb)
                    {
                        Console.WriteLine("First array lexicographically smaller than second.\n");
                    }
                    else
                    {
                        Console.WriteLine("First array lexicographically greater than second.\n");
                    }
                }
            }
            else // different lengths
            {
                if (a.Length < b.Length)
                {
                    Console.WriteLine("First array lexicographically smaller than second.\n");
                }
                else
                {
                    Console.WriteLine("First array lexicographically greater than second.\n");
                }
            }
        }

        //========================================================================================
        static void Main()
        {
            // define arrays
            char[] first = {'a', 'b', 'c' };
            char[] second = { 'a', 'b' , 'd'};

            // compare and print result
            compareLexicographically(first, second);
        }
    }
}
