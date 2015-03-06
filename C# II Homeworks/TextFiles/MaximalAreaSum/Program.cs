/*
Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
Example:

input	        output
4               17
2 3 3 4 
0 2 3 4 
3 7 1 2 
4 3 3 2	        
*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        var reader = new StreamReader("../../input.txt");
        int n = int.Parse(reader.ReadLine());
        int[,] matrix = new int[n, n];
        string line = reader.ReadLine();
        int currentRow = 0;
        while (line != null)
        {
            string[] row = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int currentCol = 0; currentCol < row.Length; currentCol++)
            {
                matrix[currentRow, currentCol] = int.Parse(row[currentCol]);
            }
            currentRow++;
            line = reader.ReadLine();
        }
        reader.Close();
        int maxSum = 0;
        for (int row = 0; row < n - 1; row++)
        {
            for (int col = 0; col < n - 1; col++)
            {
                int sum = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
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
        var writer = new StreamWriter("../../output.txt");
        writer.Write(maxSum);
        writer.Close();
        Console.WriteLine(maxSum);
    }
}
