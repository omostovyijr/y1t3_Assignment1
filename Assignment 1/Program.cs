using System;
using Assignment_1;

while (true)
{
    Console.WriteLine("|Ver 1.0| Please, enter equation (Supported only ints from 0-9 and operators + - / * () ^): ");
    string input = Console.ReadLine();
    var result = Calculator.CalculatePostfixnotation(Calculator.ConvertToPostfixnotation(input));
    Console.WriteLine("Result: ");
    Console.WriteLine(result.Pop());
    Console.WriteLine("One more? Y/N");
    var oneMore = Console.ReadLine();
    if (oneMore == "N")
    {
        break;
    }
    
}




