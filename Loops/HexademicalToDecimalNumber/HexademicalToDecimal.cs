// Problem 15. Hexadecimal to Decimal Number

// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;

class HexademicalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Insert a hexadecimal number: ");
        string input = Console.ReadLine();
        long sum = 0;
        for (int i = input.Length; i > 0; i--)
        {
            int hex;
            switch (input[input.Length-i])
            {
                case 'A':
                    hex = 10;
                    break;
                case 'B':
                    hex = 11;
                    break;
                case 'C':
                    hex = 12;
                    break;
                case 'D':
                    hex = 13;
                    break;
                case 'E':
                    hex = 14;
                    break;
                case 'F':
                    hex = 15;
                    break;
                default:
                    hex = int.Parse(Convert.ToString(input[input.Length - i]));
                    break;
            }
            sum += (long)Math.Pow(16, i - 1)*hex;
        }
        Console.WriteLine("Decimal:");
        Console.WriteLine(sum);
    }
}

