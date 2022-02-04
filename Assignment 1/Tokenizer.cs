namespace Assignment_1;

public class Tokenizer
{
    CArray Tokenize(string localString)
    {
        var tokens = new CArray();
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

        return tokens;
    }
}
