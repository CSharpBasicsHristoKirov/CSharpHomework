/*
   <summary>    
   TITLE              NameOfLastDigit()        Chapter9Exercise3.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement a method that returns 
                      the name of the last digit of the
                      input paramter.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter9Exercise3
    {
        /*
            Method: NameOfLastDigit()

            It returns the name of 
            the last digit of the
            input paramter.
        */
        static string NameOfLastDigit(int n)
        {
            string[] names = {"zero", "one", "two", "three", "four",
                              "five", "six", "seven", "eight", "nine"};

            int LeastSignificantDigit = n % 10;

            return names[LeastSignificantDigit];
        }
        //=============================================================

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(NameOfLastDigit(n));
        }
    }
}
