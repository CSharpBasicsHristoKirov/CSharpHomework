/*
   <summary>    
   TITLE        Algebraic Expression Parsing    Chapter11Exercise12
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Evaluate an algebraic expression contained in string.
               Input: (2+2-2)*5
              Output: Result = 10
                Note: It needs debugging, it fails at the 5th string expression.     
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.10.2016</datecreated>
*/
using System;
using System.Collections.Generic;
using Chapter11Exercise12.Tokenization;
using Chapter11Exercise12.ToReversePolishNotation;
using Chapter11Exercise12.EvaluatePostfixNotation;

namespace Chapter11Exercise12
{
    class AlgebraicExpressionParsing
    {
        /*
        static void Main(string[] args)
        {
            string[] inputs = { "(2+2-2)*5" , 
                                "5 + ((1 + 2) * 4) - 3" ,
                                "1 + (3 * 4) - 3",
                                "5+8-(2*2)",
                                "10/2+3/2*4-2+4*3/4-9",
                                "6/2*4",
                                "3 + 4 * 2 / ( 1 - 5 ) " };
            foreach (var input in inputs)
            {
                Console.WriteLine("Initial expression:");
                Console.WriteLine(input);

                Tokenize t = new Tokenize(input);
                List<Token> tokenizedExpr = t.GetTokenizedExpression();

                ShuntingYard sh = new ShuntingYard(tokenizedExpr);
                List<Token> postfixExpr = sh.GetExpressionInPostfixNotation();
                
                foreach (var item in postfixExpr)
                {
                    if (item.GetTokenType() == 'o') Console.Write(item.GetValue());
                    else Console.Write(item.GetTokenType());
                }

                CalculateExpression ce = new CalculateExpression(postfixExpr);
                Console.WriteLine("\nResult = {0}\n", ce.GetResult());
            }
        }
        */
    }
}

