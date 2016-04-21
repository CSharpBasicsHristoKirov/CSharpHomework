/*
   <summary>    
   TITLE              Polynomial addition        Chapter9Exercise12 
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

namespace Chapter9Exercise12
{
    public class Program
    {
        /*
            Method: ConstructPolynomial();

            It promts the user to type the
            coefficients of a polynomial as
            a set of whitespace separated 
            floating point numbers on a single
            line, starting from the constant coefficient.
            It returns an array representing a polynomial.
        */
        public static int[] ConstructPolynomial()
        {
            string prompt = "Type the coefficients, starting from the constant, on a single line separated by whitespace:";
            while (true)
            {
                Console.WriteLine(prompt);
                string[] tokens = Console.ReadLine().Split();

                int CarriageReturn = 0;
                if (tokens.Length == 1 && !int.TryParse(tokens[0], out CarriageReturn))
                {
                    Console.WriteLine("Zero polynomial!");
                }
                else
                {
                    int[] polynomial = new int[tokens.Length];

                    int length = tokens.Length;
                    for (int i = 0; i < length; i++)
                    {
                        if (!int.TryParse(tokens[i], out polynomial[i]))
                        {
                            Console.WriteLine("Wrong input format!");
                            break;
                        }
                    }
                    return polynomial;
                }
            }
        }
        //---------------------------------------------------------------

        /*
            Method: SumPolynomials(int[] a, int[] b);

            It returns an array representing the sum of the two
            polynomials passed as int arrays.

        */
        public static int[] SumPolynomials(int[] a, int[] b)
        {
            int length = Math.Max(a.Length, b.Length);
            int[] result = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                int lhs = (i < a.Length) ? a[i] : 0;
                int rhs = (i < b.Length) ? b[i] : 0;

                result[i] = lhs + rhs;
            }

            return result;
        }
        //---------------------------------------------------------------

        /*
            Method: PrintPolynomial(int[] poly);

            It prints the terms of the polynomial
            passed as int array.

            Input format: {0, 1, 2, 3}
            Output format: 3x^2 + 2x + x = 0
        */
        public static void PrintPolynomial(int[] poly)
        {
            int length = poly.Length - 1;
            for (int i = length; i >= 0; i--)
            {
                if (poly[i] != 0)
                {
                    if (poly[i] == 1 && i == 1)
                    {
                        Console.Write("x");
                    }
                    else if (i == 1)
                    {
                        Console.Write("{0}x", poly[i]);
                    }
                    else if (poly[i] == 1)
                    {
                        Console.Write("x^{0}", i);
                    }
                    else if (i == 0)
                    {
                        Console.Write("{0}", poly[i]);
                    }
                    else
                    {
                        Console.Write("{0}x^{1}", poly[i], i);
                    }
                }

                if (i - 1 >= 0 && poly[i - 1] != 0)
                {
                    if (poly[i - 1] > 0)
                    {
                        Console.Write("+");
                    }
                }
            }
            // Console.WriteLine(" = 0");
        }
        //===============================================================

        static void Main(string[] args)
        {
            // 3x^3 + 2x^2 + x 
            int[] lhs = {-3, 1, 3};
            // x^3 + 2x^2 + 3x
            int[] rhs = {-1, 1};

            PrintPolynomial(lhs);

            Console.Write(" +\n");

            PrintPolynomial(rhs);

            Console.Write(" =\n");

            var result = SumPolynomials(lhs, rhs);
            PrintPolynomial(result);

            Console.WriteLine();
        }
    }
}
