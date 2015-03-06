/*
Condition
*/

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = dimensions[0];
        int cols = dimensions[1];
        int K = int.Parse(Console.ReadLine());
        int[,] coins = new int[rows, cols];
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < K; i++)
        {
            int[] coord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            matrix[coord[0], coord[1]]++;
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int maxAbove = 0;
                int maxLeft = 0;
                if(row - 1 >= 0)
                {
                    maxAbove = matrix[row - 1, col];
                }

                if(col - 1 >= 0)
                {
                    maxLeft = matrix[row, col - 1];
                }

                matrix[row, col] += Math.Max(maxAbove, maxLeft);
            }
        }
        Console.WriteLine(matrix[rows - 1, cols - 1]);
    }
}
