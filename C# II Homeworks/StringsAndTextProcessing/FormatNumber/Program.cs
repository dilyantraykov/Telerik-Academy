﻿/*
Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
*/

using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("{0, 15}", number);
        Console.WriteLine("{0, 15:X}", number);
        Console.WriteLine("{0, 15:P}", number);
        Console.WriteLine("{0, 15:E}", number);
    }
}
