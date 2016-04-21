/*
  <summary>    
  TITLE              Torrent Pirate                    Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>20.04.2016</datecreated>
*/
using System;

namespace Exam_29_March_2015_Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            int dataSize = int.Parse(Console.ReadLine());
            int price = int.Parse(Console.ReadLine());
            int moneyPerHour = int.Parse(Console.ReadLine());

            decimal downloadTime = dataSize / 2m / 60m / 60m;
            decimal priceForDownload = downloadTime * moneyPerHour;

            decimal numberOfMovies = dataSize / 1500m;
            decimal priceForCinema = numberOfMovies * price;

            if (priceForDownload <= priceForCinema)
            {
                Console.WriteLine("mall -> {0:f2}lv", priceForDownload);
            }
            else
            {
                Console.WriteLine("cinema -> {0:f2}lv", priceForCinema);
            }
        }
    }
}
