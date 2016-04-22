/*
  <summary>    
  TITLE              Beer Stock                        Program.cs
  Basic Level - Programming Basics - Exam_17_January_2016_Morning
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>22.04.2016</datecreated>
*/
using System;

namespace Beer_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            long reserved = long.Parse(Console.ReadLine());
            long available = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Exam Over")
                {
                    break;
                }

                char delimeter = ' ';
                object[] tokens = input.Split(delimeter);

                long amount = Convert.ToInt32(tokens[0]);
                string package = Convert.ToString(tokens[1]);

                if (package == "beers")
                {
                    available += amount;
                }
                else if (package == "sixpacks")
                {
                    available += (amount * 6);
                }
                else if (package == "cases")
                {
                    available += (amount * 24);
                }
            }

            available = available - (available / 100);

            if (available >= reserved)
            {
                long left = available - reserved;

                long cases = left / 24;
                long sixpacks = (left % 24) / 6;
                long beers = (left % 24) % 6;

                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
            }
            else
            {
                long needed = reserved - available;

                long cases = needed / 24;
                long sixpacks = (needed % 24) / 6;
                long beers = (needed % 24) % 6;

                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
            }
        }
    }
}
