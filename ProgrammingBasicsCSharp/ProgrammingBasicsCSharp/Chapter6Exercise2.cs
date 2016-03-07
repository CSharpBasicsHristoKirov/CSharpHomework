/*
   <summary>    
   TITLE              Print N numbers except   Chapter6Exercise2.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read a number n. 
                      Print all the numbers from 1 to n,
                      except the ones divisible by 3 and 7.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>05.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise2
    {
        static void Main()
        { 
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
		    {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
		    }
        }
    }
}
