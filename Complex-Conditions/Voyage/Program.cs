/*
  <summary>    
  TITLE              Voyage                            Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:           
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Voyage
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string ResultMessage = "Somewhere in ";
            if (budget <= 100)
            {
                ResultMessage += "Bulgaria\n";

                if (season == "summer")
                {
                    ResultMessage += "Camp - " + (Math.Round(budget * 0.30m, 2));
                }
                else if (season == "winter")
                {
                    ResultMessage += "Hotel - " + (Math.Round(budget * 0.70m, 2));
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                ResultMessage += "Balkans\n";

                if (season == "summer")
                {
                    ResultMessage += "Camp - " + (Math.Round(budget * 0.40m, 2));
                }
                else if (season == "winter")
                {
                    ResultMessage += "Hotel - " + (Math.Round(budget * 0.80m, 2));
                }
            }
            else if (budget > 1000 && budget <= 10000)
            {
                ResultMessage += "Europe\n";
                
                if (season == "summer")
                {
                    ResultMessage += "Hotel - " + (Math.Round(budget * 0.90m, 2));
                }
                else if (season == "winter")
                {
                    ResultMessage += "Hotel - " + (Math.Round(budget * 0.90m, 2));
                }
            }
            Console.WriteLine(ResultMessage);
        }
    }
}
