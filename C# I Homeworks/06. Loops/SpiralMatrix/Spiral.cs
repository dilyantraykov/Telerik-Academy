// Problem 19.** Spiral Matrix

// Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral.

using System;

class Spiral
{
    static void Main()
    {
        Console.WriteLine("Insert matrix size:");
        int n = int.Parse(Console.ReadLine());
        int[,] spiral = new int[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        int numbers = n * n;

        for (int i = 1; i <= numbers; i++)
        {
            if (direction == "right" && (col > n - 1 || spiral[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || spiral[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || spiral[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && row < 0 || spiral[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
            }

            spiral[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                Console.Write("{0,-3}", spiral[x, y]);
            }
            Console.WriteLine();
        }
    }
}
