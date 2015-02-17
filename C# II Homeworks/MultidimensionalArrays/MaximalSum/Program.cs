/*
Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Input number of rows: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input number of cols: ");
        int m = int.Parse(Console.ReadLine());
        if (n < 3 || m < 3)
        {
            Console.WriteLine("Enter a matrix big at least 3X3!");
            return;
        }
        int[,] matrix = new int[n, m];
        int counter = 1;
        for (int col = 0; col < m; col++)
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

        int maxSum = 0;
        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                int sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
			        {
                        sum += matrix[row + i, col + j];
			        }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0, -2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine(maxSum);
    }
}
