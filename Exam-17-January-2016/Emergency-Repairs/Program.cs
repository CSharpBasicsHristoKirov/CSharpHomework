/*
  <summary>    
  TITLE              Emergency Repairs                 Program.cs
  Basic Level - Programming Basics - Exam_17_January_2016_Morning
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>22.04.2016</datecreated>
*/
using System;

namespace Emergency_Repairs
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong initialFence = ulong.Parse(Console.ReadLine());
            string fenceAsBinary = Convert.ToString((long)initialFence, 2);

            char[] fence = new char[64];

            int index = 0;
            for (int i = 0; i < 64; i++)
            {
                if (i < 64 - fenceAsBinary.Length)
                {
                    fence[i] = '0';
                }
                else
                {
                    fence[i] = fenceAsBinary[index];
                    index++;
                }
            }

            int emergencyKits = int.Parse(Console.ReadLine());
            int numberOFAttacks = int.Parse(Console.ReadLine());

            // attacks
            for (int i = 0; i < numberOFAttacks; i++)
            {
                int bitNumber = int.Parse(Console.ReadLine());

                if (bitNumber < fence.Length)
                {
                    fence[fence.Length - 1 - bitNumber] = '0';
                }
            }

            // repairs
            for (int i = 0; i < fence.Length - 1; i++)
            {
                if (fence[fence.Length - 1 - i] == '0' && fence[fence.Length - 2 - i] == '0')
                {
                    
                    if (emergencyKits > 0)
                    {
                        fence[fence.Length - 1 - i] = '1';
                        emergencyKits--;
                    }
                    else
                    {
                        break;
                    }

                    if (emergencyKits > 0)
                    {
                        fence[fence.Length - 2 - i] = '1';
                        emergencyKits--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // recovered fence
            string receveredFence = string.Empty;
            for (int i = 0; i < fence.Length; i++)
            {
                receveredFence += fence[i];
            }
            
            Console.WriteLine(Convert.ToUInt64(receveredFence, 2));
        }
    }
}
