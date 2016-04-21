/*
  <summary>    
  TITLE               Dream Item                       Program.cs
  Basic Level  -  Programming Basics - Exam_29_March_2015_Evening
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>21.04.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace Dream_Item
{
    class Program
    {
        static Dictionary<string, int> monthsDays = new Dictionary<string, int>
        {
            {"Jan", 31 },
            {"Feb", 28 },
            {"March", 31 },
            {"Apr", 30 },
            {"May", 31 },
            {"June", 30 },
            {"July", 31 },
            {"Aug", 31 },
            {"Sept", 30 },
            {"Oct", 31 },
            {"Nov", 30 },
            {"Dec", 31 }
        };

        static void Main(string[] args)
        {
            object[] tokens = new object[4];
            string input = Console.ReadLine();

            char delimeter = '\\';
            tokens = input.Split(delimeter);

            int daysInMonth = monthsDays[Convert.ToString(tokens[0])];
            decimal moneyPerHour = Convert.ToDecimal(tokens[1]);
            int hoursPerDay = Convert.ToInt32(tokens[2]);
            decimal itemPrice = Convert.ToDecimal(tokens[3]);
            decimal moneyEarned = (daysInMonth - 10) * moneyPerHour * hoursPerDay;

            if (moneyEarned > 700)
            {
                moneyEarned += moneyEarned * 0.10m;
            }

            decimal difference = moneyEarned - itemPrice;

            if (difference >= 0)
            {
                Console.WriteLine("Money left = {0:f2} leva.", Math.Round(difference, 3));
            }
            else
            {
                Console.WriteLine("Not enough money. {0:f2} leva needed.", Math.Round(Math.Abs(difference), 3));
            }
        }
    }
}
