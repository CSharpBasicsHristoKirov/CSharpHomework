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
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string promt = "Избери цифра:";
            string sentinel = "q";

            // input loop
            Console.WriteLine("Научи името на цифрата; излез с 'ч'.");
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

                // learn digit's name
                int number;
                if (int.TryParse(input, out number))
                {
                    Console.WriteLine("Натиснали сте: {0}.", nameOfDigit(number));
                }
                else
                {
                    Console.WriteLine("Данни от грешен тип!");
                }
            }
        }
        //---------------------------------------------------------------------------------------

        /*
           Method: nameOfDigit(n);

           It prints the name of the
           digit n.
        */
        static string nameOfDigit(int n)
        {
            switch (n)
            {
                case 0: return "нула";
                case 1: return "едно";
                case 2: return "две";
                case 3: return "три";
                case 4: return "четири";
                case 5: return "пет";
                case 6: return "шест";
                case 7: return "седем";
                case 8: return "осем";
                case 9: return "девет";
                default: return "Непозната стойност!\n";
            }
        }
    }
}
