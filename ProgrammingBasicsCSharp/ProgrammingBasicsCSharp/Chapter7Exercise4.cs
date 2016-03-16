/*
   <summary>     
   TITLE              Find subarray of identical elements     Chapter7Exercise4.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: The longest subarray consisted of same consecutive elements.
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
    class Chapter7Exercise4
    {
        static void Main()
        {
            int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int startingIndex = 0;
            int longestSequence = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                int currentIndex = i;
                int currentLength = 1;
                // count the number of identical elements
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // check if consecutive elements are equal
                    if (numbers[i] == numbers[j])
                    {
                        ++currentLength;
                    }
                    else
                    {
                        break;
                    }
                }
                // store longest sequence of identical elements
                if (currentLength > longestSequence)
                {
                    longestSequence = currentLength;
                    startingIndex = i;
                }
            }
            // print sequence
            for (int i = startingIndex; i < startingIndex + longestSequence; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }
    }
}
