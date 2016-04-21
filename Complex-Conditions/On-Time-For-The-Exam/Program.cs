/*
  <summary>    
  TITLE              On Time For The Exam              Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read Exam Hour and Arrival Hour and print:
                     "Late" 
                     "On time" 
                     "Early"             
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace On_Time_For_The_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int ExamHour = int.Parse(Console.ReadLine());
            int ExamMinute = int.Parse(Console.ReadLine());
            int ExamInMinutes = ExamHour * 60 + ExamMinute;

            int ArrivingHour = int.Parse(Console.ReadLine());
            int ArrivingMinute = int.Parse(Console.ReadLine());
            int ArrivingInMinutes = ArrivingHour * 60 + ArrivingMinute;

            int Difference = ArrivingInMinutes - ExamInMinutes;

            if (Difference > 0)
            {
                Console.WriteLine("Late");

                if (Difference > 59)
                {
                    Console.WriteLine("{0}:{1:0#} hours after the start", (Math.Abs(Difference) / 60) % 24, Math.Abs(Difference) % 60);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", Math.Abs(Difference) % 60);
                }
            }
            else if (Difference <=0 && Difference >= -30)
            {
                Console.WriteLine("On time");
                if (Difference != 0)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(Difference) % 60);
                }
            }
            else  
            {
                Console.WriteLine("Early");
                if (Math.Abs(Difference) > 59)
                {
                    Console.WriteLine("{0}:{1:0#} hours before the start", (Math.Abs(Difference) / 60) % 24, Math.Abs(Difference) % 60);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(Difference) % 60);
                }
            }
        }
    }
}
