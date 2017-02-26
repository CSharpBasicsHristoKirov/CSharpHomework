/*
   <summary>    
   TITLE              Time Elapsed              Chapter11Exercise4
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print time elapsed since system is on.
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise4
{
    class TimeElapsed
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:dd\\.hh\\:mm\\:ss} days (hours, min, sec) since machine start.", 
                               TimeSpan.FromMilliseconds(Environment.TickCount).ToString());
        }
    }
}
