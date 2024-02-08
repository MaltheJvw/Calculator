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
                    Operators.Add("-");
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
        }

        static double Split(List<string> Operators, string Problem)
        {
            string[] Expressions = Problem.Split(Operators.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> ParsedExpressions = new List<string>();

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

            double result = Evaluate(ParsedExpressions);
            return result;
            
        }
        static double Evaluate(List<string> expression)
        {
            double result = double.Parse(expression[0]);

            for (int i = 1; i < expression.Count; i += 2)
            {
                double nextNumber = double.Parse(expression[i + 1]);

                switch (expression[i])
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
                        throw new InvalidOperationException("Invalid operator: " + expression[i]);
                }
            }

            return result;
        }
    }
}
