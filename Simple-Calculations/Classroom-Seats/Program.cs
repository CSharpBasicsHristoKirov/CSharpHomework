/*
  <summary>    
  TITLE              Classroom seats                   Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read length and width of room.
                     Calculate number of clasroom seats,
                     given the bondary conditions.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Classroom_Seats
{
    class Program
    {
        /*
            Method:int setsNumber = calculateSeats(h, w);

            It returns the number of seats that can be put
            in a room with legth: h and width: w.
        */
        static int calculateSeats(double h, double w)
        {
            // convert to cm
            h = h * 100;
            w = w * 100;

            // for the integer division
            int roomH = (int)h;
            int roomW = (int)w;

            // account for the corridor
            roomW -= 100;

            // desk size (in cm)
            int deskH = 120;
            int deskW = 70;

            // columns and rows
            int columns = roomH / deskH;
            int rows = roomW / deskW;

            int doorAndTeackerDeskSeats = 3;
            return (columns * rows) - doorAndTeackerDeskSeats;
        }

        //======================================================

        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine(calculateSeats(h, w));
        }
    }
}
