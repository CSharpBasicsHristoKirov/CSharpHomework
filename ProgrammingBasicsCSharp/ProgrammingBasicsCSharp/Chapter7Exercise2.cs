/*
   <summary>     
   TITLE              Arrays comparison        Chapter7Exercise2.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Define and populate arrays.
                      Compare whether their elements are identical.
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
    class Chapter7Exercise2
    {
        static void Main()
        {
            int size = 2;
            int[] array1 = new int[size];
            int[] array2 = new int[size];

            Console.WriteLine("Populate first int array of size {0}.", size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Type an element:");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Populate second int array of size {0}.", size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Type an element:");
                array2[i] = int.Parse(Console.ReadLine());
            }

            // compare array elements
            Console.Write("Arrays are ");
            for (int i = 0; i < size; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.Write("not ");
                }
            }
            Console.Write("identical.\n");
        }
    }
}
