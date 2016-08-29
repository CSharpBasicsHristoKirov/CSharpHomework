/*
   <summary>    
   TITLE              Sign, mantissa and exponent   Chapter8Exercise15.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Display float's sign, mantissa and exponent. 
                             
                      Bit address                    LSB
                      31  30    23 22                  0
                      -   -------- ---------------------
                      sign exponent mantissa

                      Checked from here: http://www.h-schmidt.net/FloatConverter/IEEE754.html

               Input: -27.15f
              Output: 
                Floating number = -27.15 bits are:

                знак: 1
                ескпонента: 10000011
                мантиса: 10110010011001100110011
                Press any key to continue . . .

   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.03.2016</datecreated>
*/
using System; 
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise15
    {
        static void Main()
        {
            float n = -27.15f; // Example Output: знак = 1, експонента = 10000011, мантиса = 10110100000000000000000.
            Console.WriteLine("Floating number = {0} bits are: ", n);
            ΕxtractBits(n);
        }
        //-----------------------------------------------------------------------------------------------------------

        /*
            Method: ΕxtractBits(n);

            It prints n's sign, mantissa and exponent. 
        */
        static void ΕxtractBits(float n)
        {
            byte[] byteArray = BitConverter.GetBytes(n);
            int val = BitConverter.ToInt32(byteArray, 0);

            Console.OutputEncoding = Encoding.UTF8;

            int length = sizeof(int) * 8;
            for (int i = length - 1; i >= 0; i--)
            {
                if (i == 31)
                {
                    Console.Write("\nзнак: ");
                }

                if (i == 30)
                {
                    Console.Write("\nескпонента: ");
                }

                if (i == 22)
                {
                    Console.Write("\nмантиса: ");
                }
                Console.Write(val >> i & 1);
            }
            Console.WriteLine();
        }

    }
}
