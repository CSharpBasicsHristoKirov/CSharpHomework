/*
	TITLE           Fruit Market     Exam14042014FruitMarket.cs
	COMMENT
		Objective : https://judge.softuni.bg/Contests/9/CSharp-Basics-Exam-14-April-2014-Evening
			Input : -
		   Output : -
		   Author : Chris B.Kirov
			 Date : 02.03.2016
*/
using System;
using System.Text;


namespace CSharpExamPractice
{
    class Exam14042014FruitMarket
    {
        /*
            Method: findDiscount(day, product)

            Applies the rules for discount and 
            returns a value corresponding to the
            relative price after the discount.
        */
        static double findDiscount(string day, string product)
        {
            if (day == "Tuesday" &&
               (product == "banana" || product == "orange" || product == "apple"))
            {
                return 0.80;
            }

            if (day == "Wednesday" &&
                    (product == "cucumber" || product == "tomato"))
            {
                return 0.90;
            }

            if (day == "Thursday" &&
                     product == "banana")
            {
                return 0.70;
            }

            if (day == "Friday")
            {
                return 0.90;
            }

            if (day == "Sunday")
            {
                return 0.95;
            }
            // no discount
            return 1.00;
        }

        /*
            Method: findPrice(product)

            It returns the price of the
            product passed as argument.
        */
        static double findPrice(string product)
        {
            string[] products = { "banana", "cucumber", "tomato", "orange", "apple" };
            double[] prices =   {     1.80,       2.75,     3.20,     1.60,    0.86 };

            int numberOfProcucts = 5;
            for (int i = 0; i < numberOfProcucts; i++)
            {
                if (product == products[i])
                {
                    return prices[i];
                }
            }
            return 0;
        }

        static void Main()
        {
            // read input
            string day = Console.ReadLine();
           
            // calculate total price
            double totalPrice = 0;
            int length = 3;
            for (int i = 0; i < length; i++)
            {
                double buyerQuantity = double.Parse(Console.ReadLine());
                string buyerProduct = Console.ReadLine();

                double price = findPrice(buyerProduct);
                double todayDiscount = findDiscount(day, buyerProduct);

                totalPrice += todayDiscount * price * buyerQuantity;
            }

            // print result
            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
