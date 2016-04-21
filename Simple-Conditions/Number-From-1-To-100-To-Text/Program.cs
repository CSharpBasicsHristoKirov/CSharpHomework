/*
  <summary>    
  TITLE              Number From 1 To 100 To Text      Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read an integer [1, 100] and print its name.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>05.04.2016</datecreated>
*/
using System;

namespace Number_From_1_To_100_To_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ones = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = {"", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = {"", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string number = Console.ReadLine();

            int n = int.Parse(number);
            
            if (n < 0)
            {
                Console.WriteLine("invalid number");
                return;
            }


            if (number.Length == 1)
            {
                int index = int.Parse(number);
                Console.WriteLine(ones[index]);
            }
            else if (number.Length == 2)
            {
                if (number[1] == '0')
                {
                    int index = (int) (number[0] - '0');
                    Console.WriteLine(tens[index]);
                }
                else if (number[0] == '1')
                {
                    int index = (int) (number[1] - '0');
                    Console.WriteLine(teens[index]);
                }
                else if (number[0] != '1' && number[1] != '0')
                {
                    int LeftDigit = (int)(number[0] - '0');
                    int RightDigit = (int)(number[1] - '0');

                    Console.WriteLine(tens[LeftDigit] +" "+ ones[RightDigit]);
                }
            }
            else if (number.Length == 3)
            {
                if (number[0] == '1' && number[1] == '0' && number[2] == '0')
                {
                    Console.WriteLine("one hundred");
                }
                else
                {
                    Console.WriteLine("invalid number");
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
