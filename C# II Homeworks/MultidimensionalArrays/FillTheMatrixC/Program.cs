/*
Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
      c)
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
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
        int currentRow = 0;
        int currentCol = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            currentRow = i;
            currentCol = 0;
            while (currentRow < n && currentCol < n)
            {
                matrix[currentRow, currentCol] = counter;
                currentRow++;
                currentCol++;
                counter++;
            }
        }

        for (int j = 1; j < n; j++)
        {
            currentRow = j;
            currentCol = 0;
            while (currentRow < n && currentCol < n)
            {
                matrix[currentCol, currentRow] = counter;
                currentRow++;
                currentCol++;
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
