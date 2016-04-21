/*
  <summary>    
  TITLE              Trade Comission                   Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Trade_Comission
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());

            switch (city)
            {
                case "sofia":
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.05);
                        return;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.07);
                        return;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.08);
                        return;
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.12);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("error"); return;
                    }
                }
                case "varna":
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.045);
                        return;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.075);
                        return;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.1);
                        return;
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.13);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("error"); return;
                    }
                }
                case "plovdiv":
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.055);
                        return;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.08);
                        return;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.12);
                        return;
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.145);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("error"); return;
                    }
                }
                default: Console.WriteLine("error"); return;
            }

        }
    }
}
