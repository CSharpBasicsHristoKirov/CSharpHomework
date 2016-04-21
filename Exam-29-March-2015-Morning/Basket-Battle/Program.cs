/*
  <summary>    
  TITLE              Basket Battle                     Program.cs
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

namespace Basket_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int endPoints = 500;
            int NakovPoints = 0;
            bool NakovWins = false;
            int SimeonPoints = 0;
            bool SimeonWins = false;

            string first = Console.ReadLine();
            int rounds = int.Parse(Console.ReadLine());

            int remainder = (first == "Nakov") ? 1 : 0;
            int i;
            for (i = 1; i <= rounds; i++)
            {
                if (i % 2 == remainder)
                {
                    int FirstPoints = int.Parse(Console.ReadLine());
                    string FirstShot = Console.ReadLine();

                    if (FirstShot == "success")
                    {
                        if (NakovPoints + FirstPoints <= endPoints) NakovPoints += FirstPoints;

                        if (NakovPoints == endPoints)
                        { 
                            NakovWins = true;
                            break;
                        }
                    }

                    int SecondPoints = int.Parse(Console.ReadLine());
                    string SecondShot = Console.ReadLine();

                    if (SecondShot == "success")
                    {
                        if (SimeonPoints + SecondPoints <= endPoints) SimeonPoints += SecondPoints;

                        if (SimeonPoints == endPoints)
                        { 
                            SimeonWins = true;
                            break;
                        }
                    }
                }
                else
                {
                    int FirstPoints = int.Parse(Console.ReadLine());
                    string FirstShot = Console.ReadLine();

                    if (FirstShot == "success")
                    {
                        if (SimeonPoints + FirstPoints <= endPoints) SimeonPoints += FirstPoints;

                        if (SimeonPoints == endPoints)
                        {
                            SimeonWins = true;
                            break;
                        }
                    }

                    int SecondPoints = int.Parse(Console.ReadLine());
                    string SecondShot = Console.ReadLine();

                    if (SecondShot == "success")
                    {
                        if (NakovPoints + SecondPoints <= endPoints) NakovPoints += SecondPoints;

                        if (NakovPoints == endPoints)
                        {
                            NakovWins = true;
                            break;
                        }
                    }
                }
            }

            if (NakovWins)
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(i);
                Console.WriteLine(SimeonPoints);
            }

            if (SimeonWins)
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(i);
                Console.WriteLine(NakovPoints);
            }

            if (SimeonPoints == NakovPoints && !NakovWins && !SimeonWins)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(NakovPoints);
            }
            else if (SimeonPoints != NakovPoints && !NakovWins && !SimeonWins)
            {
                string name = (NakovPoints > SimeonPoints) ? "Nakov" : "Simeon";
                Console.WriteLine(name);
                Console.WriteLine(Math.Abs(NakovPoints - SimeonPoints));
            }
        }
    }
}
