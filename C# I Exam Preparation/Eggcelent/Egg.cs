using System;

class Egg
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int height = 2 * N;
        int width = 3 * N + 1;
        int eggWidth = N - 1;
        char[,] matrix = new char[height, width];
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                bool case1 = (i == 0 || i == height - 1) && j >= N + 1 && j <= 2 * N - 1;
                bool case2 = ((j == 1 || j == width - 2) && i >= N / 2 && i <= height - N / 2 - 1);
                if (case1 || case2)
                {
                    matrix[i, j] = '*';
                }
                else
                {
                    matrix[i, j] = '.';
                }
            }
        }
        int currentRow = N / 2 - 1;
        int currentCol = 3;
        while (true)
        {
            matrix[currentRow, currentCol] = '*';
            if (currentRow == 0)
            {
                break;
            }
            currentRow--;
            currentCol += 2;
        }
        currentRow = height - N / 2;
        currentCol = 3;
        while (true)
        {
            matrix[currentRow, currentCol] = '*';
            if (currentRow == height - 1)
            {
                break;
            }
            currentRow++;
            currentCol += 2;
        }
        currentRow = height - 1;
        currentCol = 2 * N - 1;
        while (true)
        {
            matrix[currentRow, currentCol] = '*';
            if (currentCol == width - 2)
            {
                break;
            }
            currentRow--;
            currentCol += 2;
        }
        currentRow = 1;
        currentCol = 2 * N + 1;
        while (true)
        {
            matrix[currentRow, currentCol] = '*';
            if (currentCol == width - 2)
            {
                break;
            }
            currentRow++;
            currentCol += 2;
        }
        currentRow = N - 1;
        currentCol = 2;
        while (true)
        {
            matrix[currentRow, currentCol] = '@';
            if (currentCol == width - 3)
            {
                break;
            }
            currentCol += 2;
        }
        currentRow = N;
        currentCol = 3;
        while (true)
        {
            matrix[currentRow, currentCol] = '@';
            if (currentCol == width - 4)
            {
                break;
            }
            currentCol += 2;
        }
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

