/*
Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
      a)
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
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
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[col, row] = counter;
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
