///<summary> 
///TITLE              Print date   Chapter1Exercise8.cs 
///    COMMENT
///        Objective: Print current date.
///            Input: -
///           Output: date at time of execution.
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>15.02.2016</datecreated>
using System;
using System.Text;
using System.Globalization;

namespace ProgrammingBasicsCSharp
{
    class Chapter1Exercise8
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
        }
    }
}


