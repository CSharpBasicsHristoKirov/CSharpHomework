/*
  <summary>    
  TITLE              Cheap Transport                   Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Calculate the cheapest travelling expense
                     depending on the distance and the time of
                     the day.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Cheap_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 0;

            if (distance < 20) // taxi
            {
                price += 0.70;
                if (time == "day")
                {
                    price += distance * 0.79;
                }
                else if (time == "night")
                {
                    price += distance * 0.90;
                }
            }
            else if (distance >= 20 && distance < 100) // bus
            {
                price += distance * 0.09;
            }
            else if (distance >= 100) // train
            {
                price += distance * 0.06;
            }

            Console.WriteLine(price);
        }
    }
}
