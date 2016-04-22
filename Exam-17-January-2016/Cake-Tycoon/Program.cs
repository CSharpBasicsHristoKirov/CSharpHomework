/*
  <summary>    
  TITLE              Cake Tycoon                       Program.cs
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

namespace Cake_Tycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong numberOfWantedCakes = ulong.Parse(Console.ReadLine());
            decimal kgNeededForOneCake = decimal.Parse(Console.ReadLine());
            uint kgAvailable = uint.Parse(Console.ReadLine());
            uint trufflesAvailable = uint.Parse(Console.ReadLine());
            decimal priceOfTruffle= uint.Parse(Console.ReadLine());

            ulong producedCakes = (ulong)(kgAvailable / kgNeededForOneCake);
            decimal totalTruffleCost = trufflesAvailable * priceOfTruffle;
            decimal singleCakePrice = (totalTruffleCost / numberOfWantedCakes) * 1.25m;

            if (producedCakes >= numberOfWantedCakes)
            {
                Console.WriteLine("All products available, price of a cake: {0:f2}", singleCakePrice);
            }
            else
            {
                decimal difference = (numberOfWantedCakes * kgNeededForOneCake) - kgAvailable;
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", producedCakes, difference);
            }

        }
    }
}
