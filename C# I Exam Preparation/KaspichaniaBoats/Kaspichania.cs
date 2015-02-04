/*
Condition
*/

using System;

class Kaspichania
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 6 + ((n - 3) / 2) * 3;
        int width = n * 2 + 1;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == (height * 2) / 3 - 1 || j == width / 2)
                {
                    Console.Write('*');
                }
                else if (i == height -1 && (j >= (width - n) / 2 && j < (width + n) / 2))
                {
                    Console.Write('*');
                }
                else if (j == n - i || j == n + i)
                {
                    Console.Write('*');
                }
                else if (j == i - n || i + j == n * 3)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
        Console.WriteLine();
        }
    }
}

