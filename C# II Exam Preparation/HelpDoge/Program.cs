/*
Condition
*/

using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int N = dimensions[0];
        int M = dimensions[1];
        int[] foodCoord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int Fx = foodCoord[0];
        int Fy = foodCoord[1];
        int K = int.Parse(Console.ReadLine());
        BigInteger[,] field = new BigInteger[N, M];
        for (int i = 0; i < K; i++)
        {
            int[] enemyCoord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            field[enemyCoord[0], enemyCoord[1]] = -1;
        }

        field[0, 0] = 1;

        for (int i = 1; i < N; i++)
        {
            if (field[i, 0] != -1 && field[i - 1, 0] != 0)
            {
                field[i, 0] = 1;
            }
            else
            {
                field[i, 0] = 0;
            }
        }

        for (int i = 1; i < M; i++)
        {
            if (field[0, i] != -1 && field[0, i - 1] != 0)
            {
                field[0, i] = 1;
            }
            else
            {
                field[0, i] = 0;
            }
        }

        for (int row = 1; row < N; row++)
        {
            for (int col = 1; col < M; col++)
            {
                if (field[row, col] == -1)
                {
                    field[row, col] = 0;
                    continue;
                }
                else
                {
                    field[row, col] = field[row - 1, col] + field[row, col - 1];
                }
            }
        }
        Console.WriteLine(field[Fx, Fy]);
    }
}
