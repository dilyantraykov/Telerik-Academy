/*
Problem 8. Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a short number: ");
        short shortNumber = short.Parse(Console.ReadLine());

        string shortToBinary = ShortToBinary(shortNumber);

        Console.WriteLine("{0} = {1}", shortNumber, shortToBinary);
    }

    static string ShortToBinary(short number)
    {
        byte[] bytesInput = BitConverter.GetBytes(number);
        string shortToBinary = "";
        for (int i = 0; i < bytesInput.Length; i++)
        {                                          
            shortToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + shortToBinary;
        }
        return shortToBinary;
    }
}
