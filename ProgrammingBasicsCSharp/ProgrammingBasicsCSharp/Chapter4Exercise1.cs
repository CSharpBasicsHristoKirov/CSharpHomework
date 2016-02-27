/*
   <summary>  
   TITLE              Sum of ints              Chapter4Exercise1.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read 3 ints from std Input and
                      print their sum.   
               Input: 1 
                      2 
                      3 
              Output: Sum: 6
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise1
    {
        static void Main()
        {
            // read input
            Console.WriteLine("Type three integers each on a new line:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // print sum
            Console.WriteLine("Sum: " + (a + b + c));
        }
    }
}
