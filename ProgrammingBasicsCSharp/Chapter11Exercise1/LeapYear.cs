/*
   <summary>    
   TITLE              Check if leap year         Chapter11Exercise1
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read a year from console and check if it's  leap.
               Input: 01.01.2016
              Output: Friday-01-2016 is a leap year.
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise1
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("{0:dddd/MM/yyyy} is", date);
            if (!IsLeapYear(date.Year))
            {
                Console.Write(" not");
            }
            Console.WriteLine(" a leap year.");
        }
        //------------------------------------------------------------

        /*
            Method: IsLeapYear()

            Based on the fact that one year is 365.242196 days,
            so we compensate (0.2421 = 0.25) 1 day every 4 years 
            and the residue of 0,01 we compensate every 400 years.
        */
        private static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
