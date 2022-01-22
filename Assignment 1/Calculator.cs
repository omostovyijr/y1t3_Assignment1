using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment_1
{
    public class Calculator
    {
        private static char[] isOperators = {'^', '*', '/', '+', '-'};
        private static Dictionary<char, int> _operators = new Dictionary<char, int>()
        {
            {'(', 0},
            {')', 0},
            {'+', 2},
            {'-', 2},
            {'/', 3},
            {'*', 3},
            {'^', 4},
        };
        
        public static CArray ConvertToPostfixnotation(string inputString)
        {
            inputString = Regex.Replace(inputString, @"\s", ""); // Create tokenization method
            var output = new CArray();
            var operators = new Stack<char>();
            
            foreach (var element in inputString)
            {
                bool elementIsInt = char.IsDigit(element);
                bool elementIsOperator = Array.Exists(isOperators, x => x == element);
                if (elementIsInt)
                {
                    output.Push(Char.GetNumericValue(element));
                }
                else if(elementIsOperator)
                {
                    if (operators.Count() != 0)
                    {
                        if (_operators[element] > _operators[operators.Peek()])
                        {
                            operators.Push(element);
                        }
                        else if (_operators[element] <= _operators[operators.Peek()])
                        {
                            output.Push(element);
                        }
                    }
                    else
                    {
                        operators.Push(element);
                    }
                }
                else if (element == '(')
                {
                    operators.Push(element);
                }
                else if (element == ')')
                {
                    while(operators.Count != 0 && operators.Peek() != ('('))
                    {
                        output.Push(operators.Pop());
                    }

                    operators.Pop();
                }
                else
                {
                    Console.Write("Error");
                }
            }
            
            while (operators.Count != 0)
            {
                output.Push(operators.Pop());
            }

            return output;
        }
        
    }
}