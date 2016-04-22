/*
  <summary>    
  TITLE              Mater Herbalist                   Program.cs
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

namespace Master_Herbalist
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dailyExpences = int.Parse(Console.ReadLine());

            decimal totalMoney = 0;
            int days = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season Over")
                {
                    break;
                }

                char delimeter = ' ';
                object[] tokens = input.Split(delimeter);

                int hours = Convert.ToInt32(tokens[0]);
                string path = Convert.ToString(tokens[1]);
                decimal price = Convert.ToDecimal(tokens[2]);

                int index = 0;
                int numberOfHerbs = 0;

                for (int i = 0; i < hours; i++)
                {
                    if (path[index] == 'H')
                    {
                        numberOfHerbs++;
                    }

                    index = (index < path.Length - 1) ? index + 1 : 0;
                }

                totalMoney += numberOfHerbs * price;
                ++days;
            }

            decimal averageEarnings = totalMoney / days;

            
            if (averageEarnings >= dailyExpences)
            {
                decimal extraMoney = averageEarnings - dailyExpences;
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", extraMoney);
            }
            else
            {
                decimal moneyNeeded = (dailyExpences * days) - totalMoney;
                Console.WriteLine("We are in the red. Money needed: {0}.", Math.Round(moneyNeeded,0));
            }
        }
    }
}
