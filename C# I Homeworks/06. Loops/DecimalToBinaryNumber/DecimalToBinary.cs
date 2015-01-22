// Problem 14. Decimal to Binary Number

// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Insert a decimal number: ");
        long n = long.Parse(Console.ReadLine());
        string bin = "";
        while (n > 0)
        {
            bin += (n % 2).ToString();
            n /= 2;
        }
        string reverse = "";
        for (int i = bin.Length - 1; i >= 0; i--)
        {
            reverse += bin[i];
        }
        Console.WriteLine("Binary:");
        Console.WriteLine(reverse);
    }
}

