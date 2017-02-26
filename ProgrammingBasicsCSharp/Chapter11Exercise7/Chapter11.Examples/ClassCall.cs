/*
   <summary>    
   TITLE             Namespaces and Classes     Chapter11Exercise7
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Define a namespace: Chapter11 and populate it
                      with the two classes: Cat and Sequence defined
                      in the chapter. 
                      Define another namespace: Chapter11.Example
                      and within it utilize the two classes.
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise7.Chapter11.Examples
{
    class ClassCall
    {
        static void Main()
        {
            /* Exericse 7 
            Cat cat = new Cat("Johny", "White & Black");
            cat.SayMiau();


            int length = 10;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(Sequence.NextValue());
            }
            */

            /* Exercise 8 */
            int numberOfObjects = 10;
            Cat[] cats = new Cat[numberOfObjects];

            for (int i = 0; i < numberOfObjects; i++)
            {
                string name = "Cat" + Sequence.NextValue().ToString();
                cats[i] = new Cat(name, "white");
                cats[i].SayMiau();
            }
        }
    }
}
