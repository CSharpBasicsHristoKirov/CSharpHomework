/*
   <summary>    
   TITLE        Algebraic Expression Parsing    Chapter11Exercise12
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Evaluate an algebraic expression contained 
                      in string preserving operation presedence.

                      1. Tokenize: discern input sumbols into:
                      - operands: values (e.g.: 1, 3.3,) 
                      - operators: parenthesses, algebraic operations (+, - , *, /, %, ^, !), functions, sentinel (end of input).
                      - determine: operator precedence and associativity (left to right, right to left, non-associative(no chaining))
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.10.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace Chapter11Exercise12.Tokenization
{
    /// <summary>
    /// Class Token
    /// 
    /// Defines tokens of algebraic expression 
    /// Operand: integer value, variable
    /// Operator: algebraic operation (+, - , *, /, %, ^, !),
    /// </summary>
    public class Token
    {
        // constructors
        public Token(char t) // instantiate operator
        {
            type = t; // type matches the operator itself
            identifier = null;
            value = null;
        }
        
        public Token(char t, string name) // instantiate function
        {
            type = t; // 'f' marks function
            identifier = name;
            value = null;
        }

        public Token(char t, int v) // instantiate operand
        {
            type = t; // 'o' marks operand
            identifier = null;
            value = v;
        }
        // member methods
        //------------------------------------------------------

        public char GetTokenType() { return type; }
        public string GetID() { return identifier; }
        public int? GetValue() { return value; }
        // data members
        //------------------------------------------------------

        private char type;
        private string identifier;
        private int? value;
    }
    //=================================================================================

    /// <summary>
    /// Class Tokenize
    /// 
    /// Converts string input containing algebraic
    /// expression in list of object of type Token.
    /// </summary>
    class Tokenize
    {
        // constuctor
        public Tokenize(string input)
        {
            InitFunctions();
            InitOperators();
            InitDigits();

            ConvertToListOfTokens(input);
        }
        // member methods
        //------------------------------------------------------

        public List<Token> GetTokenizedExpression() { return tokenizedExpression; }
        //------------------------------------------------------

        /*
            Method: bool ConvertToListOfTokens()

            Classifies input symbols into algebraic-
            operation tokens.
        */
        private void ConvertToListOfTokens(string input)
        {
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                if (char.IsWhiteSpace(input[i])) // if whitespace: skip
                {
                    continue;
                }
                else if (IsOperand(input[i])) // if digit try accumulating and parsing for value
                {
                    string candidateOperand = null;
                    while (i < length && IsOperand(input[i]))
                    {
                        candidateOperand += input[i];
                        if (i < length ) ++i;
                    }

                    --i;
                    int value = int.Parse(candidateOperand);
                    tokenizedExpression.Add(new Token('o', value));
                }
                else if (IsOperator(input[i])) // if valid operator 
                {
                    tokenizedExpression.Add(new Token(input[i]));
                }
                else if (char.IsLetter(input[i])) // check if valid identifier matching any function name / variable identifier ?
                {
                    string candidateFunction = null;
                    while (i < length && char.IsLetter(input[i]))
                    {
                        candidateFunction += input[i];
                        if (i < length) ++i;
                    }

                    --i;
                    if (IsFunction(candidateFunction))
                    {
                        tokenizedExpression.Add(new Token('f', candidateFunction));
                    }
                    else
                    {
                        Console.WriteLine("Identifier doesn't match any of the supported functions!");
                        tokenizedExpression = null;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid token!");
                    tokenizedExpression = null;
                }
            }
        }
        // helper functions
        //------------------------------------------------------

        private bool IsOperator(char c)
        {
            if (operators.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsFunction(string identifier)
        {
            if (functions.Contains(identifier))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsOperand(char v)
        {
            if (digits.Contains(v))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void InitOperators()
        {
            operators.Add('+');
            operators.Add('-');
            operators.Add('*');
            operators.Add('/');
            operators.Add('%');
            operators.Add('!'); // factorial
            operators.Add('^'); // exponentiation
            operators.Add('(');
            operators.Add(')');
            operators.Add('='); // sentinel
        }

        private void InitFunctions()
        {
            functions.Add("sin");
            functions.Add("cos");
            functions.Add("sqrt");
            // extension to more functions
        }

        private void InitDigits()
        {
            digits.Add('.'); // allow floating point ?
            digits.Add('0');
            digits.Add('1');
            digits.Add('2');
            digits.Add('3');
            digits.Add('4');
            digits.Add('5');
            digits.Add('6');
            digits.Add('7');
            digits.Add('8');
            digits.Add('9');
            // extension to roman numerals, greek numerals, etc.
        }

        public void PrintTokens()
        {
            foreach (var item in tokenizedExpression)
            {
                Console.WriteLine("Token type: {0}, identifier = {1}, value = {2}.",
                                  item.GetTokenType(), item.GetID(), item.GetValue());
            }
        }
        // data members
        //------------------------------------------------------

        /* Stores all supported operations. */
        HashSet<char> operators = new HashSet<char>();

        /* Stores the names of all supported functions. */
        HashSet<string> functions = new HashSet<string>();

        /* Stores digit alphabet through which values could be defined. */
        HashSet<char> digits = new HashSet<char>();

        /* Stores tokenized output expression */
        List<Token> tokenizedExpression = new List<Token>();
    }
}
