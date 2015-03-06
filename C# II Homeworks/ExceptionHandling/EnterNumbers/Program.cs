/*
Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;

class Program
{
    static void Main()
    {
        try
        {
            int start = 1;
            int end = 100;
            for (int i = 0; i < 10; i++)
            {
                start = ReadNumber(start, end);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static int ReadNumber(int start, int end)
    {
        int n = int.Parse(Console.ReadLine());
        if (n < start || n > end)
        {
            string message = String.Format("Number should be in range [{0},{1}].", start, end);
            throw new ArgumentException(message);
        }
        return n;
    }
}
