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
        static void Main()
        {
            Console.WriteLine("Type an integer: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Its least significand digit is: {0}", LastDigitName(n));
        }
        //---------------------------------------------------------------

        /*
           Method: LastDigitName()

           It returns the name of 
           the last digit of the
           input paramter.
       */
        static string LastDigitName(int n)
        {
            string[] names = {"zero", "one", "two", "three", "four",
                              "five", "six", "seven", "eight", "nine"};

            int LeastSignificantDigit = n % 10;

            return names[LeastSignificantDigit];
        }
    }
}
