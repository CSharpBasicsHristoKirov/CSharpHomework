/*
   <summary>     
   TITLE              Find subarray of increasing elements    Chapter7Exercise5.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: The longest subarray consisted of
                      concesutively increasing (with +1) elements.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>11.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise5
    {
        static void Main()
        {
            int[] numbers = { 3, 2, 3, 4, 2, 2, 4 };

            int startingIndex = 0;
            int longestSequence = 0;

            for (int i = 0; i < numbers.Length -1; ++i)
            {
                int currentIndex = i;
                int currentLength = 1;
                // count the number of identical elements
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // check if consecutive elements have distance + 1
                    if (numbers[i] == numbers[j] - currentLength)
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
