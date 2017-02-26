/*
   <summary>    
   TITLE              Print curent day of week   Chapter11Exercise3
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print curent date where days are printed like
                      days of week.
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise3
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Today is: {0:dddd/MM/yyyy}", now);
        }
    }
}
