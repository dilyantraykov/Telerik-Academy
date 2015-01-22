// Problem 16. Decimal to Hexadecimal Number

// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Insert a decimal number: ");
        long n = long.Parse(Console.ReadLine());
        string bin = "";
        while (n > 0)
        {
            switch (n % 16)
            {
                case 15:
                    bin += "F";
                    break;
                case 14:
                    bin += "E";
                    break;
                case 13:
                    bin += "D";
                    break;
                case 12:
                    bin += "C";
                    break;
                case 11:
                    bin += "B";
                    break;
                case 10:
                    bin += "A";
                    break;
                default:
                    bin += (n % 16).ToString();
                    break;
            }
            n /= 16;
        }
        string reverse = "";
        for (int i = bin.Length - 1; i >= 0; i--)
        {
            reverse += bin[i];
        }
        Console.WriteLine("Hexadecimal:");
        Console.WriteLine(reverse);
    }
}

