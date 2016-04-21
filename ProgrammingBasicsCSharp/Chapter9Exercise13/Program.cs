/*
   <summary>    
   TITLE              Polynomial multiplication  Chapter9Exercise13 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Polynomials are represented as arrays where the 
                      index represents the degree of the indeterminate 
                      (e.g x^2 -> index == 2) and the corresponding 
                      value the coefficient (e.g 2x -> arr[1] = 2).    
                      The larger the degree of the term the larger 
                      the index of the value of its coefficient.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>05.04.2016</datecreated>
*/
using System;

namespace Chapter9Exercise13
{
    class Program
    {
        /*
            Method: MultiplyPolynomials(int[] a, int[] b);

            It returns an array representing the product 
            of the two input arrays, which in turn represrent
            two polynomials.
        */
        public static int[] MultiplyPolynomials(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];

            int length1 = Math.Max(a.Length, b.Length);
            for (int i = 0; i < length1; i++)
            {
                int[] PartialProduct = new int[result.Length];

                int length2 = Math.Min(a.Length, b.Length);
                for (int j = 0; j < length2; j++)
                {
                    int multiplicand = (a.Length < b.Length) ? b[i] : a[i];
                    int multiplier = (a.Length < b.Length) ? a[j] : b[j];

                    int product = PartialProduct[i + j] + multiplicand * multiplier;

                    PartialProduct[i + j] = product;
                }
                result = Chapter9Exercise12.Program.SumPolynomials(result, PartialProduct);
            }
            return result;
        }
        //============================================================

        static void Main(string[] args)
        {
            // 3x^2 + x - 3
            int[] lhs = { -3, 1, 3 };
            // x - 1
            int[] rhs = { -1, 1 };

            Chapter9Exercise12.Program.PrintPolynomial(lhs);

            Console.Write(" *\n");

            Chapter9Exercise12.Program.PrintPolynomial(rhs);

            Console.Write(" =\n");

            var result = MultiplyPolynomials(lhs, rhs);
            Chapter9Exercise12.Program.PrintPolynomial(result);

            Console.WriteLine();
        }
    }
}
