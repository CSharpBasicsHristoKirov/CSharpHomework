/*
   <summary>    
   TITLE        Algebraic Expression Parsing    Chapter11Exercise12
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Evaluate an algebraic expression contained in string.
               Input: (2+2-2)*5
              Output: Result = 10
                Note: Version 2.0   
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>07.01.2017</datecreated>
*/
using System;
using System.Collections.Generic;

namespace Chapter11Exercise12
{
    class ExpressionParsing
    {
        static void Main(string[] args)
        {
            string[] inputs = {  
                                "1+1",
                                "(2+2-2)*5" ,
                                "5 + ((1 + 2) * 4) - 3" ,
                                "1 + (3 * 4) - 3",
                                "5+8-(2*2)",
                                "10/2+3/2*4-2+4*3/4-9",
                                "6/2*4",
                                "3 + 4 * 2 / ( 1 - 5 ) " };


            for (int i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine("{0} = {1}", inputs[i], Calculate(inputs[i]));
            }
        }

        //-------------------------------------------------------------

        /*
            Method: PrecedenceLevel(char symbol)

            Returns precedence of the operation passed
            as an argument.
        */
        static int PrecedenceLevel(char symbol)
        {
            switch (symbol)
            {
                case '+':
                case '-':
                    return 2;
                case '*':
                case '/':
                    return 3;
                case '^':
                    return 4;
                case '(':
                case ')':
                case '#':
                    return 1;
                default:
                    Console.WriteLine("Operation: {0}, not supported: ", symbol);
                    return -1;
            }
        }
        //-------------------------------------------------------------

        /*
            Method: isOperator(char symbol)
        */
        static bool isOperator(char symbol)
        {
            switch (symbol)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '^':
                case '(':
                case ')':
                    return true;
                default:
                    return false;
            }
        }

        //-------------------------------------------------------------

        /*
            Method:  string Convert (string infixInput)
            
            Converts an expression from infix to postfix notation.
        */
        static string Convert(string infixInput)
        {
            char[] postfixOutput = new char[infixInput.Length];
            char currentSymbol = '0';
            int outputIndex = 0;
            Stack<char> expression = new Stack<char>();

            for (int inputIndex = 0; inputIndex < infixInput.Length; inputIndex++)
            {
                currentSymbol = infixInput[inputIndex];
                if (!isOperator(currentSymbol)) // if not operator, write to output stream
                {
                    postfixOutput[outputIndex] = currentSymbol;
                    outputIndex++;
                }
                else // check which operator is
                {
                    if (currentSymbol == '(') // if expression in parenthesses
                    {
                        expression.Push(currentSymbol);
                    }
                    else
                    {
                        if (currentSymbol == ')') // if expression in parenthesses
                        {
                            while (expression.Count != 0 && expression.Peek() != '(')  
                            {
                                postfixOutput[outputIndex] = expression.Pop();
                                outputIndex++;
                            }
                            expression.Pop(); // discard '('
                        }
                        else
                        {
                            if (expression.Count != 0 && PrecedenceLevel(currentSymbol) > PrecedenceLevel(expression.Peek()))  
                            {
                                expression.Push(currentSymbol); 
                            }
                            else
                            {
                                while (expression.Count != 0 && PrecedenceLevel(currentSymbol) <= PrecedenceLevel(expression.Peek()))
                                {
                                    postfixOutput[outputIndex] = expression.Pop(); // append first the operators with largest precedence
                                    outputIndex++;
                                }
                                expression.Push(currentSymbol);
                            }
                        }
                    }
                }
            }

            while (expression.Count != 0) // empty the rest of the temporary stack to the output
            {
                postfixOutput[outputIndex] = expression.Pop();
                outputIndex++;
            }

            return new string(postfixOutput); // convert char array to string and return
        }
        //-------------------------------------------------------------

        /*
            Method: string EvaluateExpression (string postfixInput)

            Evaluates the input string containing an expresion in postfix notation.
        */
        static string EvaluateExpression(string postfixInput)
        {
            Console.WriteLine("\nPostfix: {0}, size: {1}\n", postfixInput, postfixInput.Length);

            Stack<int> operands = new Stack<int>();
            for (int inputIndex = 0; inputIndex < postfixInput.Length; ++inputIndex)
            {
                char currentSymbol = postfixInput[inputIndex];

                if (char.IsDigit(currentSymbol))
                {
                    operands.Push(currentSymbol - '0'); // convert to int and store as operand
                }
                else
                {
                    int defaultValue = (currentSymbol == '+' || currentSymbol == '-') ? 0 : 1;

                    // retrieve operands in reversed order
                    int rhs = (operands.Count != 0) ? operands.Pop() : defaultValue;
                    int lhs = (operands.Count != 0) ? operands.Pop() : defaultValue;

                    // apply operation
                    switch (currentSymbol)
                    {
                        case '+':
                            operands.Push(lhs + rhs);
                            break;
                        case '-':
                            operands.Push(lhs - rhs);
                            break;
                        case '*':
                            operands.Push(lhs * rhs);
                            break;
                        case '/':
                            operands.Push(lhs / rhs);
                            break;
                        default:
                            Console.WriteLine("Operation {0}, not supported!", currentSymbol);
                            break;
                    }
                }
            }

            if (operands.Count > 1 || operands.Count == 0)
            {
                Console.WriteLine("Wrong Calculations: Stack elements != 1.");
            }
                 
            return operands.Pop().ToString(); // pop result
        }

        //-------------------------------------------------------------

        /*
            Method: string Calculate(string input)

        */
        static string Calculate(string input)
        {
            return EvaluateExpression(Convert(input));
        }
    }
}
