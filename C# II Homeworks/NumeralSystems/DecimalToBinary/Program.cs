/*
Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} = {1}", number, DecimalToBinary(number));
    }

    static string DecimalToBinary(int input)
    {
        string result = "";
        if (input == 0)
        {
            result = "0";
        }
        else
        {
            while (input > 0)
            {
                result = input % 2 + result;
                input /= 2;
            }
        }
        
        return result;
    }
}
