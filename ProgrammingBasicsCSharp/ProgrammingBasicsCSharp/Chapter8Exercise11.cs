/*
   <summary>    
   TITLE             Roman to Arab numerals   Chapter8Exercise11.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Convert a Roman numeral to its Arab representation. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>26.03.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise11
    {
        static void Main()
        {
            Console.WriteLine("Type a valid Roman numeral:");
            string roman = Console.ReadLine();

            Console.WriteLine("{0}(Roman) -> {1}(Arabic)", roman, RomanToArabic(roman));
        }
        //---------------------------------------------------------------------------------

        /*
            Class data member: Dictionary<char, int> roman;

            It establishes a connections between Roman
            and Arabic numerals.
        */
        static Dictionary<char, int> roman = new Dictionary<char, int>
        {
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1}
        };
        //---------------------------------------------------------------------------------

        /*
            Method: RomanToArabic(n);
            
            It converts a Roman numeral to Arabic 
            representation by implementing the rules
            for calculating roman numerals.
            Assumes input is a valid Roman numeral.
        */
        static int RomanToArabic(string n)
        {
            int result = 0;

            // traverse the Roman numeral from left to right
            int length = n.Length - 1;
            for (int i = 0; i < length; i++)
            {
                // compare two adjacent digits
                if (roman[n[i]] < roman[n[i + 1]]) // if right digit > left left digit
                {
                    result -= roman[n[i]];
                }
                else
                {
                    result += roman[n[i]];
                }
            }

            // add the value of the rightmost digit
            result += roman[n[n.Length - 1]];

            return result;
        }
    }
}
