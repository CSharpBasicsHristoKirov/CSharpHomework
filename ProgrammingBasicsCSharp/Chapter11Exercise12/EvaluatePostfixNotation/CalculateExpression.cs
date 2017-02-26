/*
   <summary>    
   TITLE        Algebraic Expression Parsing    Chapter11Exercise12
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Evaluate an algebraic expression contained 
                      in string preserving operation presedence.

                      3. Evaluate the postfix expression and print the result.
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.10.2016</datecreated>
*/
using System;
using System.Collections.Generic;
using Chapter11Exercise12.Tokenization;

namespace Chapter11Exercise12.EvaluatePostfixNotation
{
    /// <summary>
    /// Class CalculateExpression
    /// 
    /// It evaluates an algebraic expression
    /// written in postfix notation and returns
    /// the result as an integer.
    /// https://en.wikipedia.org/wiki/Reverse_Polish_notation
    /// </summary>
    class CalculateExpression
    {
        // constuctor
        public CalculateExpression(List<Token> postFixNotation)
        {
            Evaluate(postFixNotation);
        }
        // member methods
        //-----------------------------------------------------

        public int GetResult() { return finalResult; }

        /*
            Method : Evaluate(List<Token> postFixNotation)

            Untill all the elements of the postfix notation
            list are traversed the algorithm aggregates 
            operands on a stack and applies to them the
            operator following them, then it returns the 
            accumulated result back to the stack.

            The elements of the list are either operands or operations.
        */
        private void Evaluate(List<Token> postFixNotation)
        {
            int length = postFixNotation.Count;
            for (int i = 0; i < length; i++)
            {
                if (postFixNotation[i].GetTokenType() == 'o') // if operand
                {
                    operands.Push(postFixNotation[i]);
                }
                else // otherwise is an operator
                {
                    // resolve the operation
                    char operation = postFixNotation[i].GetTokenType();

                    // apply the operation on all stack elements till is emptied
                    int? result = operands.Pop().GetValue();
                    while (operands.Count > 0)
                    {
                        int? right = operands.Pop().GetValue();

                        if (operation == '+')
                        {
                            result += right;
                        }
                        else if (operation == '-')
                        {
                            result = right - result;
                        }
                        else if (operation == '/')
                        {
                            result = right / result;
                        }
                        else if (operation == '*')
                        {
                            result *= right;
                        }
                        else if (operation == '%')
                        {
                            result = right % result;
                        }
                        else if (operation == '^')
                        {
                             // to be implemented
                        }
                        else
                        {
                            Console.WriteLine("Operator not supported!");
                        }
                    }

                    // push result on stack
                    operands.Push(new Token('o', (int)result));
                }
            }
            finalResult = (int) operands.Pop().GetValue();
        }
        //-----------------------------------------------------
        // member data
        private int finalResult;
        private Stack<Token> operands = new Stack<Token>();
    }
}
