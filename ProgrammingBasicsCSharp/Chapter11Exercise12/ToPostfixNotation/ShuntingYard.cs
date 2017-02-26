/*
   <summary>    
   TITLE        Algebraic Expression Parsing    Chapter11Exercise12
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Evaluate an algebraic expression contained 
                      in string preserving operation presedence.

                      2. Convert to postfix (Reversed polish) notations.
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.10.2016</datecreated>
*/
using System;
using System.Collections.Generic;
using Chapter11Exercise12.Tokenization;

namespace Chapter11Exercise12.ToReversePolishNotation
{
    /// <summary>
    /// Class ShuntingYard
    /// 
    /// Converts an algebraic expression
    /// written in infix notation to
    /// postfix (Reversed Polish) notation.
    /// https://en.wikipedia.org/wiki/Shunting-yard_algorithm
    /// 
    /// It accounts for operator/function precedence
    /// and associativity.
    /// </summary>
    class ShuntingYard
    {
        // constuctor
        public ShuntingYard (List<Token> tokenizedExpression)
        {
            InitOperators();
            ConvertFromInfixToPostfix(tokenizedExpression);
        }
        // member methods
        //------------------------------------------------------

        public List<Token> GetExpressionInPostfixNotation() { return expressionInPostFixNotation; }
        //------------------------------------------------------

        /*
            Method: ConvertFromInfixToPostfix()

            It applies Dijkstra's "Shunting Yard" algorithm to
            convert infix to postfix notation (Reversed Polish Notation).
        */
        private void ConvertFromInfixToPostfix(List<Token> tokenizedExpression)
        {
            int length = tokenizedExpression.Count;
            for (int i = 0; i < length; i++)
            {
                if (tokenizedExpression[i].GetTokenType() == 'o')  // if operand or opening parenthesis append to postfix notation
                {
                    expressionInPostFixNotation.Add(tokenizedExpression[i]);
                }
                else if (tokenizedExpression[i].GetTokenType() == '(')  // of opening parenthesis push on temporaty stack
                {
                    sortHelper.Push(tokenizedExpression[i]);
                }
                else if (tokenizedExpression[i].GetTokenType() == ')')  // of closing parenthesis  
                {
                    // while at top of stack are operators move them to output
                    while (sortHelper.Count > 0 && sortHelper.Peek().GetTokenType() != '(')
                    {
                        expressionInPostFixNotation.Add(sortHelper.Pop());
                    }
                    // get rid of the '('
                    sortHelper.Pop();
                }
                else if (IsOperator(tokenizedExpression[i].GetTokenType())) // if operation compare with the one on the top of the stack
                {
                    // get an object with the grammar properties
                    Operator currentInputOperator = null;

                    if (!operators.TryGetValue(tokenizedExpression[i].GetTokenType(), out currentInputOperator))
                    {
                        Console.WriteLine("No properties for such operator defined!");
                        break;
                    }
                    
                    Operator operatorOnTopOfStack = null;
                    // while on top of stack is an operator with higher precedence move it to output
                    while (sortHelper.Count > 0 && operators.TryGetValue(sortHelper.Peek().GetTokenType(), out operatorOnTopOfStack))
                    {
                        // if operator on top of stack with equal or higher precedence: pop to output and then push current on helper stack
                        if ((currentInputOperator < operatorOnTopOfStack || currentInputOperator == operatorOnTopOfStack) ||
                            (currentInputOperator.GetAssociativity() == 'r' && currentInputOperator < operatorOnTopOfStack))
                        {
                            expressionInPostFixNotation.Add(sortHelper.Pop());
                        }
                    }

                    // if there are no more operators on top of stack -> push current operator 
                    sortHelper.Push(tokenizedExpression[i]);
                }
            }

            // move any left operators on the stack to the output
            while (sortHelper.Count > 0)
            {
                expressionInPostFixNotation.Add(sortHelper.Pop());
            }
        }
        // helper functions
        //------------------------------------------------------

        private bool IsOperator(char c)
        {
            if (operators.ContainsKey(c))
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
            // operator type, precedence, associativity, arity
            // operators.Add('(', new Operator('(', 1, 'l', 'u'));

            operators.Add('=', new Operator('=', 2, 'l', 'u')); // sentinel

            operators.Add('+', new Operator('+', 3, 'l', 'b'));
            operators.Add('-', new Operator('-' , 3, 'l' , 'b'));


            operators.Add('*', new Operator('*', 4, 'l', 'b'));
            operators.Add('/', new Operator('/', 4, 'l', 'b'));
            operators.Add('%', new Operator('%', 4, 'l', 'b'));

            // operators.Add(new Operator('!', 5, 'l', 'u')); // factorial
            operators.Add('^', new Operator('^', 5, 'r', 'u')); // exponentiation

            // operators.Add(')', new Operator(')', 6, 'r', 'u'));
        }
        // data members
        //------------------------------------------------------

        /* Provides operator grammar ensured by the properties: precedence, associativity, etc. */
        SortedDictionary<char, Operator> operators = new SortedDictionary<char, Operator>();

        /* Stores operators, functions temporary to facilitate notation convertion. */
        Stack<Token> sortHelper = new Stack<Token>();
        
        /* Stores expression converted in reversed polish notation. */
        List<Token> expressionInPostFixNotation = new List<Token>();
    }
}
//=======================================================================================

/// <summary>
/// Class Operator
/// 
/// Defines operator properties
/// needed for expression-evaluation grammar.
/// </summary>
public class Operator
{
    // constructor
    public Operator(char t, int p, char asso, char arit)
    {
        type = t;
        precedenceLevel = p;
        associativity = asso;
        arity = arit;
    }
    // member methods
    //--------------------------------------------------------

    public char GetTokenType() { return type; }
    public int GetPrecedence() { return precedenceLevel; }
    public char GetAssociativity() { return associativity; }
    public char GetArity() { return arity; }
    // overloaded operators
    //--------------------------------------------------------

    public static bool operator< (Operator a, Operator b)
    {
        if (a.GetPrecedence() < b.GetPrecedence())
        {
            return true;
        }
        else if (a.GetPrecedence() == b.GetPrecedence() &&
                 a.GetAssociativity() == 'l')
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator> (Operator a, Operator b)
    {
        return !(a < b);
    }

    public static bool operator ==(Operator a, Operator b)
    {
        if (a.GetPrecedence() == b.GetPrecedence() && 
            a.GetAssociativity() == b.GetAssociativity())
        {
            return true;
        }
        else  
        {
            return false;
        }
    }

    public static bool operator !=(Operator a, Operator b)
    {
        return !(a == b);
    }
    // data members
    //--------------------------------------------------------

    private char type;
    private int precedenceLevel;
    private char associativity;
    private char arity;
}
