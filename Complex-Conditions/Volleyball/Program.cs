/*
  <summary>    
  TITLE              Volleyball                         Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read year type: "leap"/ "normal", number of bank holidays
                     and number of weekends at home city.
                     Calculate how many times a person is playing 
                     volleyball, if:

                     - playing every Saturday at Sofia, in 3/4 of the weekends (when not working).
                     - every Sunday when at home.
                     - +15% if year is leap.

                     Print the result rounded down.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            float BankHolidaysNumber = float.Parse(Console.ReadLine());
            float WeekendsAtHome = float.Parse(Console.ReadLine());

            float AvailableWeekends = 48f;
            float TotalGamesPlayed = 0f;

            float WeekendsAtSofia = AvailableWeekends - WeekendsAtHome;

            // not working 3/4 of the weekends at Sofia, thus playing volleyball 
            TotalGamesPlayed = WeekendsAtSofia * 3.0f / 4f;

            // playing volleyball evert Sunday at Home 
            TotalGamesPlayed += WeekendsAtHome;

            // playing in 2/3 of the Bank Holidays
            TotalGamesPlayed += BankHolidaysNumber * 2.0f / 3f;

            // if leap year there are + 15% more games
            if (year == "leap")
            {
                TotalGamesPlayed += TotalGamesPlayed * 0.15f;
            }

            // print result rounded down
            Console.WriteLine(Math.Truncate(TotalGamesPlayed));
        }
    }
}
