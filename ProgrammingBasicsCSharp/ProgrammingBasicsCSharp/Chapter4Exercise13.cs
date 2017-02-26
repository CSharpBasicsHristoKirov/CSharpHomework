/*
   <summary>  
   TITLE              Harmonic series         Chapter4Exercise13.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Accumulate the first 1000 terms of the 
                      Harmonic series.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise13
    {
        static void Main()
        {
            /*
            // info and variables
            Console.WriteLine("Approximate the Harmonic number up to the 3rd digit.");
            double epsilon = 0.001;         // determines precision
            int term = 1;                   // summand
            double lastSum = 0;             
            double currentSum = 0;

            // accumulate sum
            int iterations = 0;
            while(true)
            {
                currentSum += (1.0 / term++);

                if (Math.Abs(currentSum - lastSum) < epsilon)
                {
                    break;
                }

                lastSum = currentSum;

                ++iterations;
            }  

            // print result
            Console.WriteLine("Current precision exceeded after {0} iterations, H converges to: {1:F3}", iterations, currentSum);
            */
            double eps = 0.005;
            Console.WriteLine("Precision: {0}, Needed terms: {1}", eps, numberOfTermsForGivenPrecision(eps));
        }
        //-----------------------------------------------------------------------------------------------------------------------

        /*
            Method: numberOfTermsForGivenPrecision(double epsilon)


        */
        static long numberOfTermsForGivenPrecision(double epsilon)
        {
            double lastSum = 0, currentSum = 0;
            long term = 1, iterations = 0;
            while (true)
            {
                // \sum \frac{1}{n^4}
                // currentSum += (1.0 / Math.Pow(term++, 4));

                // \sum \frac{1}{e^n}
                // currentSum += (1.0 / Math.Pow(Math.E, term++));

                // \sum \frac{1}{n * ln^{2}(n)}
                // currentSum += (1.0 / term * Math.Pow(Math.Log(term), 2));

                // \sum \frac{ln(n)}{n^2}
                // currentSum += Math.Log(term) / Math.Pow(term, 2);

                // \sum \frac{(-1)^{n-1}}{n^{3}}
                // currentSum += Math.Pow(-1, term) / Math.Pow(term, 3);

                // \sum \frac{(-1)^{n-1}}{n^{4}}
                currentSum += Math.Pow(-1, term) / Math.Pow(term, 4);

                term++;

                if (Math.Abs(currentSum - lastSum) < epsilon)
                {
                    break;
                }
                Console.WriteLine("tems: {0}, diff = {1}, sum = {2}", iterations, Math.Abs(currentSum - lastSum), currentSum);
                lastSum = currentSum;

                ++iterations;
                
            }
            return iterations;
        }

    }
}
