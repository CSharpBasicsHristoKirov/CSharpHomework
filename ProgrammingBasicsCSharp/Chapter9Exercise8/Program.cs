/*
   <summary>    
   TITLE              Sum Large Numbers           Chapter9Exercise8  
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a method that sums two numbers whose
                      digits are stored in an array, 
                      in Little - Endian representation, i.e
                      ones are in index 0, tens - index 1 etc. 
                      Limit the number of elements to 10000.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>02.04.2016</datecreated>
*/
using System;

namespace Chapter9Exercise8
{
    public class Program
    {
        /*
           Method: MatchArraySize(int[] a, int[] b);

           It resizes the size of the smaller array
           to the size of the larger array, initializing
           the remaining elements to 0.
        */
        public static void MatchArraySize(int[] a, int[] b)
        {
            if (a.Length < b.Length)
            {
                Array.Resize(ref a, b.Length);
            }
            else
            {
                Array.Resize(ref b, a.Length);
            }
            Console.WriteLine("lhs.Length {0}, rhs.Lenght {1}", a.Length, b.Length);
        }

        //-----------------------------------------------------------
        /*
            Method: ValidInput(int[] a, int[] b, int[] result)

            It checks whether:
            - the arrays are of equal size; 
              if not it resizes the smaller to match the size of the larger.
            - the size of the input arrays is < 10000.
            - the size of the output array is larger than the input arrays.  
        */
        public static bool ValidInput(int[] a, int[] b, int[] result)
        {
            // Array Length mismatch
            if (a.Length != b.Length)
            {
                MatchArraySize(a, b);
            }

            int length = a.Length;

            // Array Length > 10.000
            if (length > 9999)
            {
                return false;
            }

            // Result may overflow!
            if (length >= result.Length)
            {
                return false;
            }

            return true;
        }

        //-----------------------------------------------------------
        /*
            Method: SumDigitArrays(int[] a, int[] b)

            It returns an array storing the sum* of 
            the two input arrays, that represent large numbers
            stored Little - Endian representation.
        */
        public static int[] SumDigitArrays(int[] a, int[] b)
        {
            int[] result = new int[Math.Max(a.Length, b.Length) + 1];

            if (!ValidInput(a, b, result))
            {
                throw new System.ArgumentException();
            }

            int length = a.Length;
            for (int i = 0; i < length; i++)
            {
                int Sum = result[i] + a[i] + b[i];

                result[i] = Sum % 10;
                result[i + 1] += Sum / 10;
            }

            // resize the array storing the result to match the value stored
            var index = result.Length - 1;
            while (result[index] == 0)
            {
                --index;
            }

            var TrimToActualValue = new int[index + 1];
            Array.Copy(result, TrimToActualValue, index + 1);

            return TrimToActualValue;
        }
        //===========================================================

        /*
            Method: SumDigitArraysDifferentSize(int[] a, int[] b)

            It returns an array storing the sum* of 
            the two input arrays, that represent large numbers
            stored Little - Endian representation.
        */
        public static int[] SumDigitArraysDifferentSize(int[] a, int[] b)
        {
            int[] result = new int[Math.Max(a.Length, b.Length) + 1];

            if (!ValidInputDifferentSize(a, b, result))
            {
                throw new System.ArgumentException();
            }

            int length = Math.Max(a.Length, b.Length);
            for (int i = 0; i < length; i++)
            {
                int lhs = (i < a.Length) ? a[i] : 0;
                int rhs = (i < b.Length) ? b[i] : 0;

                int sum = result[i] + lhs + rhs;
                result[i] = sum % 10;

                int carry = sum / 10;

                if (i + 1 < result.Length)
                {
                    result[i + 1] = result[i + 1] + carry;
                }
            }
            return result;
        }
        //-----------------------------------------------------------

        /*
            Method: ValidInputDifferentSize(int[] a, int[] b, int[] result);

            It checks whether:
            - the size of the input arrays is < 10000.
            - the size of the output array is larger than the input arrays.
        */
        public static bool ValidInputDifferentSize(int[] a, int[] b, int[] result)
        {
            int length = Math.Max(a.Length, b.Length);
            // Array Length > 10.000
            if (length > 9999)
            {
                Console.WriteLine("Sum::Size out of Limit!");
                return false;
            }
            // Result may overflow!
            if (length >= result.Length)
            {
                // Console.WriteLine("Sum::Possible Overflow!");
                // return false;
            }
            return true;
        }

        //---------------------------------------------------------------------------------
        /*
            Method: TrimToMatchTheValue(int[] arr);

            It return an array with size matching 
            the value of the number stored, in 
            Little - Endian representation.
        */
        public static int[] TrimToMatchTheValue(int[] current)
        {
            var EndIndex = current.Length - 1;
            while (current[EndIndex] == 0)
            {
                --EndIndex;
            }

            var TrimToActualValue = new int[EndIndex + 1];
            Array.Copy(current, TrimToActualValue, EndIndex + 1);

            return TrimToActualValue;
        }
        //-----------------------------------------------------------

        /*
            Method: PrintArray(int[] Array);

        */
        public static void PrintArray(int[] Array)
        {
            int length = Array.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(Array[i]);
               
            }
        }
        //============================================================
         
        static void Main(string[] args)
        {
            int[] lhs = { 9, 9 , 9, 9};
            int[] rhs = { 9, 9, 9, 9};

            try
            {
                PrintArray(lhs);
                Console.Write(" + ");
                PrintArray(rhs);
                Console.Write(" = ");

                int[] result = SumDigitArraysDifferentSize(lhs, rhs);

                PrintArray(result);

                Console.WriteLine();
                Console.WriteLine(9999 + 9999);

                Console.WriteLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Argument Exception Caught!");
            }
        }
    }
}
