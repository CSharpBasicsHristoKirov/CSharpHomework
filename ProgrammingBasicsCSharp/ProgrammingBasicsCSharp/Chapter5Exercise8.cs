/*
   <summary>    
   TITLE              Select input type        Chapter5Exercise8.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that reads preselected
                      input type. 
                       
                      If type int or double, increment.
                      If type string, append "*".

                      Print modified input.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>29.02.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise8
    {
        static void Main()
        {
            // read input
            Console.WriteLine("Select input type by typing a number:\n1.int\n2.double\n3.string");
            int selector = Convert.ToInt32(Console.ReadLine());
                
            switch (selector)
            {
                case 1:
                {
                    Console.WriteLine("Type an int value: ");

                    int intInput = int.Parse(Console.ReadLine());
                    Console.WriteLine("Incremented integer: " + (++intInput));
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Type a double value: ");

                    double douInput = double.Parse(Console.ReadLine());
                    Console.WriteLine("Incremented double: " + (++douInput));
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Type a string value: ");

                    string strInput = Console.ReadLine();
                    Console.WriteLine("Appended string: " + (strInput + "*"));
                    break;
                }
                default:
                {
                     Console.WriteLine("Type not supported!\n");
                     break;
                }
            }
        }
    }
}
