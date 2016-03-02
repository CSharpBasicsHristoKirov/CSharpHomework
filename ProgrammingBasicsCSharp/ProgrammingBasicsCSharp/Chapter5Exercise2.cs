/*
   <summary>  
   TITLE              Product sign             Chapter5Exercise2.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that shows the sign of the
                      product of three real numbers, without 
                      actually multiplying them. 
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
    class Chapter5Exercise2
    {
        /*
            Method: isSignOfProductPositive()
            
            Returns true if the number of elements
            in the array with negative sign is even,
            i.e. the their product is positive.     
        */
        static bool isSignOfProductPositive(int[] numbers)
        {
            // count the number of negative signs
            int negativeSigns = 0;
            foreach (int val in numbers)
            {
                if (val < 0)
                {
                    ++negativeSigns; 
                }
            }

            // check if odd or even
            return negativeSigns % 2 == 0;
        }

        static void Main()
        {
            const int size = 3;
            int[] numbers = new int[size] { -1, 2, -3 };

            bool isPositive = isSignOfProductPositive(numbers);

            if (isPositive)
            {
                Console.WriteLine("Product has positive sign");
            }
            else
            {
                Console.WriteLine("Product has negative sign");
            }
        }
    }
}
