/*
Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
*/

using System;

class Program
{
    static void Main()
    {
        //Console.Write("Input number of rows: ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Input number of cols: ");
        //int m = int.Parse(Console.ReadLine());
        //string[,] matrix = new string[n, m];
        string[,] matrix = { {"ha", "fifi", "ho", "xxx"},
                             {"xxx", "ha", "xax", "xx"},
                             {"xx", "xxx", "ha", "xx"},
                             {"xxx", "fifi", "ho", "xxl"}};
        int longestSequence = 0;
        string currentString = "";
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentRow = row;
                int currentCol = col;
                int sequence = 0;
                while (currentRow < matrix.GetLength(0))
                {
                    if (matrix[currentRow, currentCol] == matrix[row, col])
                    {
                        sequence++;
                    }
                    else
                    {
                        break;
                    }
                    currentRow++;
                }
                if (sequence > longestSequence)
                {
                    longestSequence = sequence;
                    currentString = matrix[row, col];
                }

                currentRow = row;
                currentCol = col;
                sequence = 0;
                while (currentCol < matrix.GetLength(1))
                {
                    if (matrix[currentRow, currentCol] == matrix[row, col])
                    {
                        sequence++;
                    }
                    else
                    {
                        break;
                    }
                    currentCol++;
                }
                if (sequence > longestSequence)
                {
                    longestSequence = sequence;
                    currentString = matrix[row, col];
                }

                currentRow = row;
                currentCol = col;
                sequence = 0;
                while (currentRow < matrix.GetLength(0) && currentCol < matrix.GetLength(1))
                {
                    if (matrix[currentRow, currentCol] == matrix[row, col])
                    {
                        sequence++;
                    }
                    else
                    {
                        break;
                    }
                    currentRow++;
                    currentCol++;
                }
                if (sequence > longestSequence)
                {
                    longestSequence = sequence;
                    currentString = matrix[row, col];
                }

                currentRow = row;
                currentCol = col;
                sequence = 0;
                while (currentRow < matrix.GetLength(0) && currentCol >= 0)
                {
                    if (matrix[currentRow, currentCol] == matrix[row, col])
                    {
                        sequence++;
                    }
                    else
                    {
                        break;
                    }
                    currentRow++;
                    currentCol--;
                }
                if (sequence > longestSequence)
                {
                    longestSequence = sequence;
                    currentString = matrix[row, col];
                }
            }
        }
        for (int i = 0; i < longestSequence; i++)
        {
            Console.Write(currentString + (i == longestSequence - 1 ? "" : ", "));
        }
        Console.WriteLine();
    }
}

