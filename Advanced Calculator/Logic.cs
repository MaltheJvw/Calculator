using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Calculator
{
    internal class Logic
    {
        public static double Operator(string Problem)
        {
            List<string> Operators = new List<string>();
            

            foreach (char character in Problem)
            {
                if (character == '+')
                {
                    Operators.Add("+");
                }
                if (character == '-')
                {
                    while (!Problem.StartsWith('-'))
                    {
                        Operators.Add("-");
                        break;
                    }  
                }
                if (character == '*')
                {
                    Operators.Add("*");
                }
                if (character == '/')
                {
                    Operators.Add("/");
                }

            }

            return Split(Operators, Problem);
            Counter.Increment();

        }

        static double Split(List<string> Operators, string Problem)
        {
            //Making an Array for the numbers
            //To differentiate between operators and numbers, the Problem equation will be split from the already covered operators from the Operators list(Which gets converted to an array)
            string[] Expressions = Problem.Split(Operators.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            //A List for the Parsed expressions.
            List<string> ParsedExpressions = new List<string>();

            //A for-loop that will go through the expression array and them to the new parsedexpression list 
            for (int i = 0; i < Expressions.Length; i++)
            {
                // Add the current expression to the parsed expressions list
                ParsedExpressions.Add(Expressions[i]);

                // Check if there is a corresponding operator for the current expression
                if (i < Operators.Count)
                {
                    // Add the operator to the parsed expressions list
                    ParsedExpressions.Add(Operators[i]);
                }
            }
            //Calling the Evaluate Method to return a double result, with the help of the ParsedExpression list that holds the equation.
            double result = Evaluate(ParsedExpressions);
            
            return result;
            
        }
        static double Evaluate(List<string> ParsedExpressions)
        {
            //Parse the string of the first value in the ParsedExpressions list into a double.
            //the double result now has the value of the first number of the equation.
            double result = double.Parse(ParsedExpressions[0]);

            //A for-loop which starts at the second value, as the double result variable, already has the first value
            //the loop continues till there are no more elements in the string list.
            //increment of 2, so it skips the operators in the ParsedExpressions list.
            for (int i = 1; i < ParsedExpressions.Count; i += 2)
            {
                //Parse the next element 
                double nextNumber = double.Parse(ParsedExpressions[i + 1]);

                switch (ParsedExpressions[i])
                {
                    case "+":
                        result += nextNumber;
                        break;
                    case "-":
                        result -= nextNumber;
                        break;
                    case "*":
                        result *= nextNumber;
                        break;
                    case "/":
                        result /= nextNumber;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operator: " + ParsedExpressions[i]);
                }
            }

            return result;
        }
    }
}
