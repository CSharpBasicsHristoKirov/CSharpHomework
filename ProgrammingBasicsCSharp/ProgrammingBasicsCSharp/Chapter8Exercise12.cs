/*
   <summary>    
   TITLE              Arab to Roman numerals   Chapter8Exercise12.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Convert a Arab numeral to its Roman representation. 
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
    class Chapter8Exercise12
    {
        static void Main()
        {
            int upperBound = 4000;
            for (int i = 1; i <= upperBound; ++i)
            {
                Console.WriteLine("{0}(Arabic) -> {1}(Roman)", i, arabicToRoman(i));
                Console.ReadKey();
            }
        }
        //----------------------------------------------------------------------------

        /*
            Class data member:  List<Tuple<int, string>> arabic;

            It establishes a connections between Roman
            and Arabic numerals.
        */
        static List<Tuple<int, string>> arabic = new List<Tuple<int, string>>
        {
            new Tuple<int, string>(1000, "M"),
            new Tuple<int, string>(900, "CM"),
            new Tuple<int, string>(500, "D"),
            new Tuple<int, string>(400,  "CD"),
            new Tuple<int, string>(100, "C"),
            new Tuple<int, string>(90, "XC"),
            new Tuple<int, string>(50, "L"),
            new Tuple<int, string>(40, "XL"),
            new Tuple<int, string>(10, "X"),
            new Tuple<int, string>(9, "IX"),
            new Tuple<int, string>(5, "V"),
            new Tuple<int, string>(4, "IV"),
            new Tuple<int, string>(1, "I")
        };
        //----------------------------------------------------------------------------

        /*
            Method: arabicToRoman(n);

            Assumes input is a positive integer <= 4000.

            It converts an Arabic numeral to Roman
            by successively searching for the nearest
            value matching n, when found, this value is
            subtracted from n and its matching Roman
            numeral appended to the result.
        */
        static string arabicToRoman(int n)
        {
            string result = string.Empty;

            int length = arabic.Count;
            for (int i = 0; i < length; i++)
            {
                // search for nearest (from left)
                while (n >= arabic[i].Item1)
                {
                    // append roman digit
                    result += arabic[i].Item2;

                    // subtract value corresponding to appended digit
                    n -= arabic[i].Item1;
                }
            }
            return result;
        }

    }
}
