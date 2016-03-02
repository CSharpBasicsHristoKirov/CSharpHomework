/*
   <summary>    
   TITLE              Apply the rules         Chapter5Exercise10.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: If a number is:
                      0 or > 9 : display error number.
                      [1, 3] : multiply by 10.
                      [4, 6] : multiply by 100.
                      [7, 9] : multiply by 1000.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>01.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise10
    {
        static void Main()
        {
            const int size = 11;
            int[] set = new int[size] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // apply the rules
            int length = size;
            for (int i = 0; i < length; i++)
            {
                if (set[i] == 0 || set[i] > 9)
                {
                    Console.Error.WriteLine("Points 0 or > 9!");
                }

                if (set[i] >= 1 && set[i] <= 3)
                {
                    set[i] *= 10;
                }

                if (set[i] >= 4 && set[i] <= 6)
                {
                    set[i] *= 100;
                }

                if (set[i] >= 7 && set[i] <= 9)
                {
                    set[i] *= 1000;
                }
            }

            // print after applying the rules 
            foreach (var item in set)
            {
                Console.Write(item + "\n");
            }
        }
    }
}
