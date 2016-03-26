/*
   <summary>    
   TITLE             Change number bases      Chapter8Exercise13.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Given N, S, D , where 2 ≤ S, 16 ≥ D  
                      change the number N with base S to 
                      representation with base D.               
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
    class Chapter8Exercise13
    {
        /*
            Method: string decimalVal = toDecimal(src, srcBase);

            Assumes source base <= 16.
            It converts src with base: srcBase to decimal.
        */
        static int toDecimal(string src, int srcBase)
        {
            int dec = 0;

            int length = src.ToString().Length;
            for (int i = 0; i < length; i++)
            {
                int summand = 0;
                // from right to left
                switch (src[length - i - 1])
                {
                    case '0': summand = 0; break;
                    case '1': summand = 1; break;
                    case '2': summand = 2; break;
                    case '3': summand = 3; break;
                    case '4': summand = 4; break;
                    case '5': summand = 5; break;
                    case '6': summand = 6; break;
                    case '7': summand = 7; break;
                    case '8': summand = 8; break;
                    case '9': summand = 9; break;
                    case 'A': case 'a': summand = 10; break;
                    case 'B': case 'b': summand = 11; break;
                    case 'C': case 'c': summand = 12; break;
                    case 'D': case 'd': summand = 13; break;
                    case 'E': case 'e': summand = 14; break;
                    case 'F': case 'f': summand = 15; break;
                }
                // accumulate the decimal value as number within [0,15] * srcBase ^ index
                dec += summand * (int)Math.Pow(srcBase, i);
            }
            return dec;
        }

        //-------------------------------------------------------------------
        /*
            Method: string destVal = fromDecimal(src, destBase);

            It assumes positive integer as first parameter and
            destBase >= 16.
        */
        static string fromDecimal(int src, int destBase)
        {
            if (src == 0)
            {
                return "0";
            }

            string destinationString = string.Empty;

            while (src > 0)
            {
                int remainder = src % destBase;

                // only for hexadecimal 
                if (destBase == 16)
                {
                    if (remainder < 10)
                    {
                        destinationString = remainder.ToString() + destinationString;
                    }
                    else
                    {
                        string symbol = string.Empty;
                        switch (remainder)
                        {
                            case 10: symbol = "A"; break;
                            case 11: symbol = "B"; break;
                            case 12: symbol = "C"; break;
                            case 13: symbol = "D"; break;
                            case 14: symbol = "E"; break;
                            case 15: symbol = "F"; break;
                        }
                        destinationString = symbol + destinationString;
                    }
                }
                else // for any other base
                {
                    destinationString = remainder.ToString() + destinationString;
                }               

                src /= destBase;
            }

            return destinationString;
        }

        //-------------------------------------------------------------------
        /*
            Method: string dest = changeBase(src, startBase, endBase);

            It changes the string "src" from "startBase" to "endBase".
        */
        static string changeBase(string src, int startBase, int endBase)
        {
            return fromDecimal(toDecimal(src, startBase), endBase);
        }

        //===================================================================

        static void Main()
        {
            string src = "15";
            int sourceBase = 10;
            int destionationBase = 2;
            Console.WriteLine("{0}({1}) -> {2}({3})",
                              src, sourceBase, changeBase(src, sourceBase, destionationBase), destionationBase);
        }
    }
}
