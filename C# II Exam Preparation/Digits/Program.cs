/*
Condition
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        byte[,] matrix = new byte[N, N];
        for (int i = 0; i < N; i++)
        {
            string digits = Console.ReadLine().Replace(" ", "");
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = (byte)(digits[j] - '0');
            }
        }
        int[] patterns = new int[10];
        for (int i = 0; i < N - 4; i++)
        {
            for (int j = 0; j < N - 2; j++)
            {
                if(matrix[i, j] == 0 && matrix[i, j + 1] == 0 && matrix[i, j + 2] == 0
                    && matrix[i + 1, j] == 0 && matrix[i + 1, j + 2] == 0
                    && matrix[i + 2, j] == 0 && matrix[i + 2, j + 2] == 0
                    && matrix[i + 3, j] == 0 && matrix[i + 3, j + 2] == 0
                    && matrix[i + 4, j] == 0 && matrix[i + 4, j + 1] == 0 && matrix[i + 4, j + 2] == 0)
                {
                    patterns[0] += 1;
                }
                if (matrix[i, j + 2] == 1
                    && matrix[i + 1, j + 1] == 1 && matrix[i + 1, j + 2] == 1
                    && matrix[i + 2, j] == 1 && matrix[i + 2, j + 2] == 1
                    && matrix[i + 3, j + 2] == 1
                    && matrix[i + 4, j + 2] == 1)
                {
                    patterns[1] += 1;
                }
                if (matrix[i, j + 1] == 2
                    && matrix[i + 1, j] == 2 && matrix[i + 1, j + 2] == 2
                    && matrix[i + 2, j + 2] == 2
                    && matrix[i + 3, j + 1] == 2
                    && matrix[i + 4, j] == 2 && matrix[i + 4, j + 1] == 2 && matrix[i + 4, j + 2] == 2)
                {
                    patterns[2] += 1;
                }
                if (matrix[i, j] == 3 && matrix[i, j + 1] == 3 && matrix[i, j + 2] == 3
                && matrix[i + 1, j + 2] == 3
                && matrix[i + 2, j + 1] == 3 && matrix[i + 2, j + 2] == 3
                && matrix[i + 3, j + 2] == 3
                && matrix[i + 4, j] == 3 && matrix[i + 4, j + 1] == 3 && matrix[i + 4, j + 2] == 3)
                {
                    patterns[3] += 1;
                }
                if (matrix[i, j] == 4 && matrix[i, j + 2] == 4
                && matrix[i + 1, j] == 4 && matrix[i + 1, j + 2] == 4
                && matrix[i + 2, j] == 4 && matrix[i + 2, j + 1] == 4 && matrix[i + 2, j + 2] == 4
                && matrix[i + 3, j + 2] == 4
                && matrix[i + 4, j + 2] == 4)
                {
                    patterns[4] += 1;
                }
                if (matrix[i, j] == 5 && matrix[i, j + 1] == 5 && matrix[i, j + 2] == 5
                && matrix[i + 1, j] == 5
                && matrix[i + 2, j] == 5 && matrix[i + 2, j + 1] == 5 && matrix[i + 2, j + 2] == 5
                && matrix[i + 3, j + 2] == 5
                && matrix[i + 4, j] == 5 && matrix[i + 4, j + 1] == 5 && matrix[i + 4, j + 2] == 5)
                {
                    patterns[5] += 1;
                }
                if (matrix[i, j] == 6 && matrix[i, j + 1] == 6 && matrix[i, j + 2] == 6
                && matrix[i + 1, j] == 6
                && matrix[i + 2, j] == 6 && matrix[i + 2, j + 1] == 6 && matrix[i + 2, j + 2] == 6
                && matrix[i + 3, j] == 6 && matrix[i + 3, j + 2] == 6
                && matrix[i + 4, j] == 6 && matrix[i + 4, j + 1] == 6 && matrix[i + 4, j + 2] == 6)
                {
                    patterns[6] += 1;
                }
                if (matrix[i, j] == 7 && matrix[i, j + 1] == 7 && matrix[i, j + 2] == 7
                && matrix[i + 1, j + 2] == 7
                && matrix[i + 2, j + 1] == 7
                && matrix[i + 3, j + 1] == 7
                && matrix[i + 4, j + 1] == 7)
                {
                    patterns[7] += 1;
                }
                if (matrix[i, j] == 8 && matrix[i, j + 1] == 8 && matrix[i, j + 2] == 8
                    && matrix[i + 1, j] == 8 && matrix[i + 1, j + 2] == 8
                    && matrix[i + 2, j + 1] == 8
                    && matrix[i + 3, j] == 8 && matrix[i + 3, j + 2] == 8
                    && matrix[i + 4, j] == 8 && matrix[i + 4, j + 1] == 8 && matrix[i + 4, j + 2] == 8)
                {
                    patterns[8] += 1;
                }
                if (matrix[i, j] == 9 && matrix[i, j + 1] == 9 && matrix[i, j + 2] == 9
                    && matrix[i + 1, j] == 9 && matrix[i + 1, j + 2] == 9
                    && matrix[i + 2, j + 1] == 9 && matrix[i + 2, j + 2] == 9
                    && matrix[i + 3, j + 2] == 9
                    && matrix[i + 4, j] == 9 && matrix[i + 4, j + 1] == 9 && matrix[i + 4, j + 2] == 9)
                {
                    patterns[9] += 1;
                }
            }
        }
        int sum = 0;
        for (int i = 0; i < patterns.Length; i++)
        {
            sum += i * patterns[i];
        }
        Console.WriteLine(sum);
    }
}
