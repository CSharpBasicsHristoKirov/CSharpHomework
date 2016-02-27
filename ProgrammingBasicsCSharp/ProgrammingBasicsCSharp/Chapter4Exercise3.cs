/*
   <summary>  
   TITLE             Company details          Chapter4Exercise3.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read: company 
                      name, address, phone number, fax number, web site,
                      and manager. Where manager has: 
                      first name, last name, phone number.

                      Print the collected information.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise3
    {
        static void Main()
        {
            string institution= "Company";
            string member = "Manager";

            const int size1 = 4;
            string[] institutionData = new string[size1] {"name", "phone number", "fax number", "website"};
            string[] institutionCollectedData = new string[size1];

            const int size2 = 3;
            string[] memberData = new string[size2] {"first name", "last name", "phone number"};
            string[] memberCollectedData = new string[size2];

            // read company input 
            int count1 = 0;
            foreach (string element in institutionData)
            {
                Console.WriteLine("Type "+ institution +" "+ element +": ");
                institutionCollectedData[count1++] = Console.ReadLine();
            }

            // read manager input
            int count2 = 0;
            foreach (string element in memberData)
            {
                Console.WriteLine("Type "+ member +" "+ element +": ");
                memberCollectedData[count2++] = Console.ReadLine();
            }

            // print company information
            for (int i = 0; i < size1; i++)
            {
                Console.WriteLine(institution +" "+ institutionData[i] +": "+ institutionCollectedData[i]);
            }

            // print manager information
            for (int i = 0; i < size2; i++)
            {
                Console.WriteLine(member +" "+ memberData[i] +": "+ memberCollectedData[i]);
            }
        }
    }
}
