/*
   <summary>    
   TITLE             Working Days                Chapter11Exercise9
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that returns the number of
                      working days between two dates.
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.10.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace Chapter11Exercise8
{
    class WorkingDays
    {
        static void Main(string[] args)
        {
            InitializeBankHoliday();
            DateTime wantedDate = new DateTime(2017, 1, 1);
            Console.WriteLine("Working days till: {0:dd/mm/yyyy} are: {1}.", wantedDate, GetWorkingDays(wantedDate));
        }
        //----------------------------------------------------------------

        /* Data structures to contain a list of Bank Holidays */
        private static HashSet<DateTime> BankHolidays = new HashSet<DateTime>();

        //----------------------------------------------------------------
        /*
            Method: GetWorkingDays(DateTime futureDate)

            Returns number of working days from now to
            futureDate.
        */
        private static int GetWorkingDays(DateTime futureDate)
        {
            DateTime now = DateTime.Now;
            return GetWorkingDays(now, futureDate);
        }
        //----------------------------------------------------------------

        /*
            Method: GetWorkingDays(DateTime initial, DateTime final)

            Returns number of working days from some initial to
            some future date.
        */
        private static int GetWorkingDays(DateTime initial, DateTime final)
        {
            DateTime now = DateTime.Now;
            int numberOfWorkingDays = 0;
            for (DateTime i = initial.Date; i <= final.Date; i = i.AddDays(1))
            {
                if (!IsWeekend(i) && !IsBankHoliday(i,BankHolidays))
                {
                    ++numberOfWorkingDays;
                }
            }
            return numberOfWorkingDays;
        }
        //----------------------------------------------------------------

        /*
            Method: IsWeekend(DateTime day)

            Returns true if day is Saturday or Sunday.
        */
        private static bool IsWeekend(DateTime day)
        {
            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //----------------------------------------------------------------

        /*
            Method: IsBankHoliday(DateTime day, DateTime[] Holidays)

            Returns true if day is withing the list of the Bank Holidays.
        */
        private static bool IsBankHoliday(DateTime day, HashSet<DateTime> Holidays)
        {
            if (Holidays.Contains(day))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //----------------------------------------------------------------

        /*
            Method: InitializeBankHoliday()

            Loads bank holidays.
        */
        private static void InitializeBankHoliday()
        {
            // Movable Easter Monday and Friday not included

            BankHolidays.Add(new DateTime(2016, 1, 1)); // New Years Day
            BankHolidays.Add(new DateTime(2016, 3, 3)); // Liberation Day
            BankHolidays.Add(new DateTime(2016, 5, 1)); // Labour Day
            BankHolidays.Add(new DateTime(2016, 5, 6)); // St Georges Day
            BankHolidays.Add(new DateTime(2016, 5, 24));// Day of Bulgarian Enlightment and Culture and of Slavonic Alphabet
            BankHolidays.Add(new DateTime(2016, 9, 6)); // Unification of Eastern Rumelia with Bulgaria 1885
            BankHolidays.Add(new DateTime(2016, 9, 22));// Independance from the Ottoman Empire in 1908
            BankHolidays.Add(new DateTime(2016, 12, 24));// Christmas Eve
            BankHolidays.Add(new DateTime(2016, 12, 25));// Christmas Day
            BankHolidays.Add(new DateTime(2016, 12, 26));// Christmas Second Day
        }
    }
}
