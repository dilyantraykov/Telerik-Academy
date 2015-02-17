/*
Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
      b)
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Input matrix size: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = counter;
                }
                else
                {
                    matrix[n - row - 1, col] = counter;
                }
                counter++;
            }
        }
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, -2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
