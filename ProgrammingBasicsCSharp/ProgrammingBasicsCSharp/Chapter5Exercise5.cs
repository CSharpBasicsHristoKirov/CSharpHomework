/*
   <summary>  
   TITLE              Name of digit            Chapter5Exercise5.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that reads a single digit
                      integer and prints its name. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>29.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise5
    {
        /*
            Method: nameOfDigit(n);

            It prints the name of the
            digit n.
        */
        static string nameOfDigit(int n)
        {
            switch (n)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Value not supported!\n";
            }
        }

        static void Main()
        {
            string promt = "Type a single digit integer:";
            string sentinel = "q";

            // input loop
            Console.WriteLine("Find name of digit; exit with 'q'.");
            while (true)
            {
                // read input
                Console.WriteLine(promt);
                string input = Console.ReadLine();

                // exit input loop
                if (input == sentinel)
                {
                    break;
                }

                // learn digit name
                int number;
                if (int.TryParse(input, out number))
                {
                    Console.WriteLine("You've typed {0}.", nameOfDigit(number));
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
            }
        }
    }
}
