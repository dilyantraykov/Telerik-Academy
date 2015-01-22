// Problem 11.* Numbers in Interval Dividable by Given Number

// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersInIntervalDividableByNumber
{
    static void Main()
    {
        Console.WriteLine("Insert start number: ");
        uint start = uint.Parse(Console.ReadLine());
        Console.WriteLine("Insert end number: ");
        uint end = uint.Parse(Console.ReadLine());
        int count = 0;
        for (uint i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("There are {0} numbers between {1} and {2} divisible by 5.", count, start, end);
    }
}

