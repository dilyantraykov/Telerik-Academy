// Problem 13. Binary to Decimal Number

// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Insert a binary number: ");
        string input = Console.ReadLine();
        long sum = 0;
        for (int i = input.Length; i > 0; i--)
        {
            if (input[input.Length - i] == '1')
            {
                sum += (long)Math.Pow(2, i-1);
            }
        }
        Console.WriteLine("Decimal: ");
        Console.WriteLine(sum);
    }
}

