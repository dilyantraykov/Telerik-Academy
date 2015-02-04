// (1+9)%6-(7%2)*8=

using System;

class Enigma
{
    static void Main()
    {
        string input = Console.ReadLine();
        int i = 0;
        int sum = 0;
        int bracketSum = 0;
        char operation = '+';
        char bracketOperation = '+';
        bool inBrackets = false;
        while (input[i] != '=')
		{
            if (inBrackets)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '%' || input[i] == '*')
                {
                    bracketOperation = input[i];
                }
                else if (input[i] >= '0' && input[i] <= '9')
                {
                    switch(bracketOperation)
                    {
                        case '+':
                            bracketSum += int.Parse(input[i].ToString());
                            break;
                        case '-':
                            bracketSum -= int.Parse(input[i].ToString());
                            break;
                        case '*':
                            bracketSum *= int.Parse(input[i].ToString());
                            break;
                        case '%':
                            bracketSum %= int.Parse(input[i].ToString());
                            break;
                    }
                }
                else if (input[i] == ')')
                {
                    switch (operation)
                    {
                        case '+':
                            sum += bracketSum;
                            break;
                        case '-':
                            sum -= bracketSum;
                            break;
                        case '*':
                            sum *= bracketSum;
                            break;
                        case '%':
                            sum %= bracketSum;
                            break;
                    }
                    inBrackets = false;
                    bracketSum = 0;
                    operation = '+';
                }
            }
            else
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '%' || input[i] == '*')
                {
                    operation = input[i];
                }
                else if (input[i] >= '0' && input[i] <= '9')
                {
                    switch (operation)
                    {
                        case '+':
                            sum += int.Parse(input[i].ToString());
                            break;
                        case '-':
                            sum -= int.Parse(input[i].ToString());
                            break;
                        case '*':
                            sum *= int.Parse(input[i].ToString());
                            break;
                        case '%':
                            sum %= int.Parse(input[i].ToString());
                            break;
                    }
                }
                else if (input[i] == '(')
                {
                    inBrackets = true;
                    bracketOperation = '+';
                }
            }
            i++;
		}
        Console.WriteLine("{0:F3}", sum);
    }
}
