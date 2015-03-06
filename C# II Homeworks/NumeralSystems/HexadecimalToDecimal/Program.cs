/*
Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine().ToUpper();

        Console.WriteLine("{0} = {1}", hexNumber, HexadecimalToDecimal(hexNumber));
    }

    static long HexadecimalToDecimal(string hexNumber)
    {
        long decimalNumber = 0;
        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            switch (hexNumber[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    decimalNumber += (long.Parse(hexNumber[i].ToString())) * (long)Math.Pow(16, hexNumber.Length - 1 - i);
                    break;
                case 'A':
                    decimalNumber += 10 * (long)Math.Pow(16, hexNumber.Length - 1 - i);
                    break;
                case 'B':
                    decimalNumber += 11 * (long)Math.Pow(16, hexNumber.Length - 1 - i);
                    break;
                case 'C':
                    decimalNumber += 12 * (long)Math.Pow(16, hexNumber.Length - 1 - i);
                    break;
                case 'D':
                    decimalNumber += 13 * (long)Math.Pow(16, hexNumber.Length - 1 - i);
                    break;
                case 'E':
                    decimalNumber += 14 * (long)Math.Pow(16, hexNumber.Length - 1 - i);
                    break;
                case 'F':
                    decimalNumber += 15 * (long)Math.Pow(16, hexNumber.Length - 1 - i);
                    break;
            }
        }
        return decimalNumber;
    }
}

