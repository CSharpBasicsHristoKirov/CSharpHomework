/*
   <summary>     
   TITLE              Index of letter         Chapter7Exercise15.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Type a word and print the indexes of each
                      of the letters that compose it.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise15
    {
        static void Main()
        {
            Console.WriteLine("Type a word:");
            string word = Console.ReadLine();

            Console.WriteLine("The letter indexes are:");
            for (int i = 0; i < word.Length; i++)
            {
                // utilize Unicode character ordering and convert each character to its int value
                // translate it to the start by subtracting the character with the smallest int value
                Console.WriteLine("letter: {0} index: {1}", word[i], (int)word[i] - (int)'a');
            }
        }
        
    }
}
