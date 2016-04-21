/*
  <summary>    
  TITLE              Swimming Pool Pipes                   Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06s.04.2016</datecreated>
*/
using System;

namespace Swimming_Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double FlowRate1 = double.Parse(Console.ReadLine());
            double FlowRate2 = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double VolumePipe1 = FlowRate1 * time;
            double VolumePipe2 = FlowRate2 * time;

            if ((VolumePipe1 + VolumePipe2) <= volume)
            {
                int PercentageFull = (int) ((VolumePipe1 + VolumePipe2) * 100 / volume);
                int PercentagePipe1 = (int) (VolumePipe1 * 100 / (VolumePipe1 + VolumePipe2));
                int PercentagePipe2 = (int) (VolumePipe2 * 100 / (VolumePipe1 + VolumePipe2));

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                                   PercentageFull,
                                   PercentagePipe1,
                                   PercentagePipe2);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                                   time, (VolumePipe1 + VolumePipe2) - volume);
            }
        }
    }
}
