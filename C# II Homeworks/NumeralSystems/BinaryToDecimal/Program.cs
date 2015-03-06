/*
Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        Console.WriteLine("{0} = {1}", binaryNumber, BinaryToDecimal(binaryNumber));
    }

    static long BinaryToDecimal(string binaryNumber)
    {
        long result = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            result += (long.Parse(binaryNumber[binaryNumber.Length - 1 - i].ToString())) * (long)Math.Pow(2, i);
        }
        return result;
    }
}

