/*
   <summary>    
   TITLE             Playing cards             Chapter6Exercise4.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print all possible 52 playing cars.
                      There are 13 ranks and 4 colours
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>06.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise4
    {
        static void Main()
        {

            string[] cardColours = { "spades", "hearts", "diamonds", "clubs" };
            string[] cardRanks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int colours = 0; colours < 4; colours++)
            {
                for (int ranks = 0; ranks < 13; ranks++)
                {
                    Console.WriteLine(cardColours[colours] +" "+ cardRanks[ranks]);
                }
            }
        }
    }
}
