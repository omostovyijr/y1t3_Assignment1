using System;

namespace Assignment_1
{
    public class Tokenizer
    {
        public static object Tokenize(string localString)
        {
            var tokens = new CArray();
            char[] operators = {'^', '*', '/', '+', '-', '(', ')'};
            var tokensList = localString.Split(" ");
            for (int i = 0; i < tokensList.Length; i++)
            {
                if (tokensList[i].Contains("("))
                {
                    var value = tokensList[i].Replace('(', ' ');
                    var trimValue = value.Trim(' ');
                    tokens.Push("(");
                    tokens.Push(trimValue);
                }
                else if (tokensList[i].Contains(")"))
                {
                    string value = tokensList[i].Replace(')', ' ');
                    var trimValue = value.Trim(' ');
                    tokens.Push(trimValue);
                    tokens.Push(")");
                }
                else
                {
                    tokens.Push(tokensList[i]);
                }
            }

            var tokensArray = new object[tokens.Length()];
            for (int i = 0; i < tokens.Length(); i++)
            {
                string value = tokens.GetAt(i);
                if (char.IsNumber(value, 0))
                {
                    if (char.IsDigit(value, 0))
                    {
                        tokensArray[i] = Convert.ToInt32(value);
                    }
                    else
                    {
                        tokensArray[i] = Convert.ToDouble(value);
                    }
                }

                foreach (char c in operators)
                {
                    if (value.Contains(c))
                    {
                        tokensArray[i] = Convert.ToChar(value);
                    }
                }
            }
            return tokensArray;
        }

    }
}
