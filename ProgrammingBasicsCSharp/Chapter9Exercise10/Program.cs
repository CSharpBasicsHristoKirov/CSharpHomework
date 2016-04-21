/*
   <summary>    
   TITLE              Factorial of 100          Chapter9Exercise10  
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find factorial of the numbers [1, 100].
                      Hint: BingInteger or Array Representation. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>02.04.2016</datecreated>
*/
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Chapter9Exercise10
{
    class Program
    {
        /*
            Method: ToDigitArray(int n);

            It returns an array storing the digits
            in the input parameter in Little - Endian
            representation.
        */
        public static int[] ToDigitArray(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException();
            }

            if (n == 0)
            {
                return new int[1] { 0 };
            }

            var Digits = new List<int>();
            for (; n != 0; n /= 10)
            {
                Digits.Add(n % 10);
            }

            return Digits.ToArray();
        }

        //=================================================================================

        /*
            Method: ValidDigitArraysInput(int[] lhs, int[] rhs, int[] result);

        */
        public static bool ValidDigitArraysInput(int[] lhs, int[] rhs, int[] result)
        {
            int length = Math.Max(lhs.Length, rhs.Length);

            // result exceeds maximum allowed digits 10.000
            int MaximumInputDigits = 5000;
            if (length > MaximumInputDigits)
            {
                Console.WriteLine("Multiply::Size!");
                return false;
            }

            // result may overflow
            if (result.Length < 2 * length)
            {
                Console.WriteLine("Multiply::Overflow!");
                return false;
            }

            return true;
        }
        //--------------------------------------------------------

        /*
           Method: MultiplyDigitArrays(int[] lhs, int[] rhs, int[] result);

           It mulitplies two numbers whose digits are 
           stored in lhs and rhs arrays using 
           Little - Endian representation 
           (i.e. ones -> index 0, tens -> index 1m, etc)
           and stores the product in the array: result. 
        */
        public static int[] MultiplyDigitArrays(int[] lhs, int[] rhs)
        {
            int[] result = new int[Math.Max(lhs.Length, rhs.Length) * 2 + 1];

            if (!ValidDigitArraysInput(lhs, rhs, result))
            {
                // throw new ArgumentException();
            }

            int length1 = Math.Max(lhs.Length, rhs.Length);
            for (int i = 0; i < length1; i++)
            {
                int[] PartialProduct = new int[result.Length];

                int length2 = Math.Min(lhs.Length, rhs.Length);
                for (int j = 0; j < length2; j++)
                {
                    int multiplicand = (lhs.Length < rhs.Length) ? rhs[i] : lhs[i];
                    int multiplier = (lhs.Length < rhs.Length) ? lhs[j] : rhs[j];

                    int product = PartialProduct[i + j] + multiplicand * multiplier;

                    PartialProduct[i + j] = product % 10;
                    int carry = product / 10;

                    if (i + j + 1 < PartialProduct.Length)
                    {
                        PartialProduct[i + j + 1] = PartialProduct[i + j + 1] + carry;
                    }
                }
                result = Chapter9Exercise8.Program.SumDigitArraysDifferentSize(PartialProduct, result);
            }

            var TrimToActualValue = TrimToMatchTheValue(result);

            return TrimToActualValue;
        }
        //=================================================================================

        /*
           Method: ValidInput(int n);

        */
        public static bool ValidFactorialInput(int n)
        {
            return n >= 1 && n <= 100;
        }
        //--------------------------------------------------------

        /*
            Method: Factorial(int n);

            It returns the value of n!,
            where n [1, 100].
        */
        public static int[] Factorial(int n)
        {
            if (!ValidFactorialInput(n))
            {
                throw new ArgumentOutOfRangeException();
            }

            int[] Initial = ToDigitArray(1);
            Stack<int[]> factorials = new Stack<int[]>();
            factorials.Push(Initial);

            for (int i = 1; i <= n; i++)
            {
                var last = factorials.Pop();
                var ith = ToDigitArray(i);

                var current = MultiplyDigitArrays(last, ith);

                var TrimToActualValue = TrimToMatchTheValue(current);

                factorials.Push(TrimToActualValue);
            }             
            return factorials.Pop();
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

        //=================================================================================

        /*
            Method: PrintArray(int[] Array);

        */
        public static void PrintArray(int[] arr)
        {
            int SkipLeadingZereos = arr.Length - 1;
            while (arr[SkipLeadingZereos] == 0)
            {
                --SkipLeadingZereos;
            }

            int EndIndex = SkipLeadingZereos;
            for (int i = EndIndex; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
        //=================================================================================

        public static BigInteger FactorialBagInteger(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *=  i;
            }
            return result;
        }

        //=================================================================================
        static void Main(string[] args)
        {            
            try
            {
                int n = 100;

                int[] factorial = Factorial(n);

                Console.WriteLine("Factorial where large numbers represented as arrays:");
                PrintArray(factorial);

                Console.WriteLine("\nFactorial where large numbers represented as BigInteger:");
                Console.WriteLine(FactorialBagInteger(n).ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Multiply Digit Arrays Exception Caught");
            }
        }
    }
}






/*
    Class MyBigInteger
    
    Represents Lagre Numbers.

    For further developement...
*/
//========================================================================================================
namespace Chapter9Exercise10
{
    public class MyBigInteger
    {
        // default constructor
        public MyBigInteger()
        {
            value = DefaultArray();
        }

        // constructor from integer number
        public MyBigInteger(int n)
        {
            value = ToDigitArray(n);
        }

        // constructor from integer array
        public MyBigInteger(params int[] array)
        {
            value = array;
        }

        // overloaded operator+
        public static MyBigInteger operator +(MyBigInteger lhs, MyBigInteger rhs)
        {
            return new MyBigInteger(SumDigitArrays(lhs.value, rhs.value));
        }

        // overloaded operator*
        public static MyBigInteger operator *(MyBigInteger lhs, MyBigInteger rhs)
        {
            return new MyBigInteger(MultiplyDigitArrays(lhs.value, rhs.value));
        }

        //-----------------------------???? to be overloaded as postfix operator as factorial
        public static MyBigInteger operator !(MyBigInteger n)
        {
            int asInt = ToInteger(n);
            return new MyBigInteger(Factorial(asInt));
        }

        // print the value of the data member
        public void PrintMyBigInteger()
        {
            PrintArray(value);
        }

        //=========================================================================
        // Helper functions

        /*
            Method: DefaultArray();

            It initializes the default
            constructor.
        */
        private int[] DefaultArray()
        {
            return new int[1] { 0 };
        }
        //-------------------------------------------------------------------------

        /*
            Method: ToDigitArray(int n);

            It returns an array storing the digits
            in the input parameter in Little - Endian
            representation.
        */
        private static int[] ToDigitArray(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException();
            }

            if (n == 0)
            {
                return new int[1] { 0 };
            }

            var Digits = new List<int>();
            for (; n != 0; n /= 10)
            {
                Digits.Add(n % 10);
            }

            return Digits.ToArray();
        }
        //-------------------------------------------------------------------------

        /*
            Method: ToInteger(MyBigInteger n);

            It returns an integer representing 
            the digits stored in the input 
            parameter in Little - Endian
            representation.
        */
        private static int ToInteger(MyBigInteger n)
        {
            int result = 0;

            int length = n.value.Length;

            if (length > 31)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < length; i++)
            {
                result += n.value[i] * (int) Math.Pow(10, i);
            }

            return result;
        }
        //-------------------------------------------------------------------------

        /*
           Method: SumDigitArrays(int[] a, int[] b)

           It returns an array storing the sum* of 
           the two input arrays, that represent large numbers
           stored Little - Endian representation.
       */
        private static int[] SumDigitArrays(int[] a, int[] b)
        {
            int[] result = new int[Math.Max(a.Length, b.Length) + 1];

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
        //--------------------------------------------------------

        /*
           Method: MultiplyDigitArrays(int[] lhs, int[] rhs, int[] result);

           It mulitplies two numbers whose digits are 
           stored in lhs and rhs arrays using 
           Little - Endian representation 
           (i.e. ones -> index 0, tens -> index 1m, etc)
           and stores the product in the array: result. 
        */
        private static int[] MultiplyDigitArrays(int[] lhs, int[] rhs)
        {
            int[] result = new int[Math.Max(lhs.Length, rhs.Length) * 2 + 1];

            if (!ValidDigitArraysInput(lhs, rhs, result))
            {
                // throw new ArgumentException();
            }

            int length1 = Math.Max(lhs.Length, rhs.Length);
            for (int i = 0; i < length1; i++)
            {
                int[] PartialProduct = new int[result.Length];

                int length2 = Math.Min(lhs.Length, rhs.Length);
                for (int j = 0; j < length2; j++)
                {
                    int multiplicand = (lhs.Length < rhs.Length) ? rhs[i] : lhs[i];
                    int multiplier = (lhs.Length < rhs.Length) ? lhs[j] : rhs[j];

                    int product = PartialProduct[i + j] + multiplicand * multiplier;

                    PartialProduct[i + j] = product % 10;
                    int carry = product / 10;

                    if (i + j + 1 < PartialProduct.Length)
                    {
                        PartialProduct[i + j + 1] = PartialProduct[i + j + 1] + carry;
                    }
                }
                result = Chapter9Exercise8.Program.SumDigitArraysDifferentSize(PartialProduct, result);
            }
            var TrimToActualValue = TrimToMatchTheValue(result);
            return TrimToActualValue;
        }
        //-----------------------------------------------------------

        /*
            Method: ValidDigitArraysInput(int[] lhs, int[] rhs, int[] result);

        */
        private static bool ValidDigitArraysInput(int[] lhs, int[] rhs, int[] result)
        {
            int length = Math.Max(lhs.Length, rhs.Length);

            // result exceeds maximum allowed digits 10.000
            int MaximumInputDigits = 5000;
            if (length > MaximumInputDigits)
            {
                Console.WriteLine("Multiply::Size!");
                return false;
            }

            // result may overflow
            if (result.Length < 2 * length + 1)
            {
                Console.WriteLine("Multiply::Overflow!");
                return false;
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
        private static int[] TrimToMatchTheValue(int[] current)
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
        //-------------------------------------------------------------------------

        /*
           Method: ValidInput(int n);

        */
        private static bool ValidFactorialInput(int n)
        {
            return n >= 1 && n <= 100;
        }
        //-------------------------------------------------------------------------

        /*
            Method: Factorial(int n);

            It returns the value of n!,
            where n [1, 100].
        */
        private static int[] Factorial(int n)
        {
            if (!ValidFactorialInput(n))
            {
                throw new ArgumentOutOfRangeException();
            }

            int[] Initial = ToDigitArray(1);
            Stack<int[]> factorials = new Stack<int[]>();
            factorials.Push(Initial);

            for (int i = 1; i <= n; i++)
            {
                var last = factorials.Pop();
                var ith = ToDigitArray(i);

                var current = MultiplyDigitArrays(last, ith);

                var TrimToActualValue = TrimToMatchTheValue(current);
                factorials.Push(TrimToActualValue);
            }
            return factorials.Pop();
        }
        //-------------------------------------------------------------------------

        /*
            Method: PrintArray(int[] Array);

        */
        private static void PrintArray(int[] arr)
        {
            int SkipLeadingZereos = arr.Length - 1;
            while (arr[SkipLeadingZereos] == 0)
            {
                --SkipLeadingZereos;
            }

            int EndIndex = SkipLeadingZereos;
            for (int i = EndIndex; i >= 0; i--)
            {
                    Console.Write(arr[i]);
            }
        }
        //=========================================================================

        // data member
        private int[] value;
    }
}


